Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Security.Cryptography



Public Class MainApp

    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loads the api key on first load.
        Try
            API_Form.API_KEY.Text = My.Settings.API_KEY
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Payments_Refresh_Btn_Click(sender As Object, e As EventArgs) Handles Payments_Refresh.Click

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
            ' If errors occur they'll tell the user here.
            MessageBox.Show(output)
        End Try

    End Sub
    Private Sub LogIn_Btn_Click(sender As Object, e As EventArgs) Handles LogIn_Btn.Click
        API_Form.ShowDialog()
    End Sub
    Private Sub Products_Refresh_Click(sender As Object, e As EventArgs) Handles Products_Refresh.Click

        ' Sets the API list strings


        Dim output As String

        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo With {
            .CreateNoWindow = True,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .FileName = "CMD.exe",
            .Arguments = "/c curl.exe --url https://api.vultr.com/v1/server/list -H ""API-Key:" & API_Form.API_KEY.Text & """"
        }
        process.StartInfo = startInfo
        process.Start()
        output = process.StandardOutput.ReadToEnd()
        Clipboard.SetText(output)
        process.WaitForExit()

        Try
            prod_tabs.TabPages.Clear()


        Catch ex As Exception
            MessageBox.Show("Final Error 1")
        End Try


        'Try
        Dim Count As Integer
            Dim json = output
            Dim reports = JsonConvert.DeserializeObject(Of Dictionary(Of String, ReportData))(json)
        For Each pair In reports

            Dim NewTab As New TabPage
            NewTab.Name = $"{pair.Key}"
            NewTab.Text = NewTab.Name
            Count += 1
            prod_tabs.Controls.Add(NewTab)

            Dim Data As New TextBox With {
                .[ReadOnly] = True,
                .Multiline = True,
                .Dock = DockStyle.Fill,
                .Font = New Font("Microsoft Sans Serif", 13),
                .ScrollBars = ScrollBars.Vertical
            }
            Dim fontName As FontFamily = Data.Font.FontFamily
            Data.Text &= "Operating System: " & $"{pair.Value.os}"
            Data.Text &= Environment.NewLine & "Ram: " & $"{pair.Value.ram}"
            Data.Text &= Environment.NewLine & "Main IP: " & $"{pair.Value.main_ip}"
            Data.Text &= Environment.NewLine & "Virtual CPU Count: " & $"{pair.Value.vcpu_count}"
            Data.Text &= Environment.NewLine & "Server Location: " & $"{pair.Value.location}"
            Data.Text &= Environment.NewLine & "DCID: " & $"{pair.Value.DCID}"
            Data.Text &= Environment.NewLine & "Machine Default Password: " & $"{pair.Value.default_password}"
            Data.Text &= Environment.NewLine & "Date Created: " & $"{pair.Value.date_created}"
            Data.Text &= Environment.NewLine & "Pending Charges: $" & $"{pair.Value.pending_charges}"
            Data.Text &= Environment.NewLine & "Status: " & $"{pair.Value.status}"
            Data.Text &= Environment.NewLine & "Cost Per Month: $" & $"{pair.Value.cost_per_month}"
            Data.Text &= Environment.NewLine & "Current Bandwidth GB: " & $"{pair.Value.current_bandwidth_gb}" & " GB"
            Data.Text &= Environment.NewLine & "Allowed Bandwidth GB: " & $"{pair.Value.allowed_bandwidth_gb}" & " GB"
            Data.Text &= Environment.NewLine & "Gateway V4: " & $"{pair.Value.gateway_v4}"
            Data.Text &= Environment.NewLine & "Power Status: " & $"{pair.Value.power_status}"
            Data.Text &= Environment.NewLine & "Server State: " & $"{pair.Value.server_state}"
            Data.Text &= Environment.NewLine & "VPS Plan ID: " & $"{pair.Value.VPSPLANID}"
            Data.Text &= Environment.NewLine & "V6 Main IP: " & $"{pair.Value.v6_main_ip}"
            Data.Text &= Environment.NewLine & "V6 Network: " & $"{pair.Value.v6_network}"
            Data.Text &= Environment.NewLine & "V6 Networks: " & $"{pair.Value.v6_networks}"
            Data.Text &= Environment.NewLine & "Label: " & $"{pair.Value.label}"
            Data.Text &= Environment.NewLine & "Internal IP: " & $"{pair.Value.internal_ip}"
            Data.Text &= Environment.NewLine & "KVM URL: " & $"{pair.Value.kvm_url}"
            Data.Text &= Environment.NewLine & "Auto Backups: " & $"{pair.Value.auto_backups}"
            Data.Text &= Environment.NewLine & "Tags: " & $"{pair.Value.tag}"
            Data.Text &= Environment.NewLine & "OSID: " & $"{pair.Value.OSID}"
            Data.Text &= Environment.NewLine & "APPID: " & $"{pair.Value.APPID}"
            Data.Text &= Environment.NewLine & "Firewall Group ID: " & $"{pair.Value.FIREWALLGROUPID}"
            NewTab.Controls.Add(Data)
            prod_tabs.SelectedIndex = prod_tabs.TabCount - 1

        Next
        'Catch ex As Exception
        '    MessageBox.Show("Final Error 2")
        'End Try



    End Sub
End Class

Public Class ReportData
    <JsonProperty("VM_ID")>
    Public Property VM_ID As String
    Public Property os As String
    Public Property ram As String
    Public Property main_ip As String
    Public Property vcpu_count As String
    Public Property location As String
    Public Property DCID As String
    Public Property default_password As String
    Public Property date_created As String
    Public Property pending_charges As String
    Public Property status As String
    Public Property cost_per_month As String
    Public Property current_bandwidth_gb As String
    Public Property allowed_bandwidth_gb As String
    Public Property netmask_v4 As String
    Public Property gateway_v4 As String
    Public Property power_status As String
    Public Property server_state As String
    Public Property VPSPLANID As String
    Public Property v6_main_ip As String
    Public Property v6_network_size As String
    Public Property v6_network As String
    Public Property v6_networks As Object
    Public Property label As String
    Public Property internal_ip As String
    Public Property kvm_url As String
    Public Property auto_backups As String
    Public Property tag As String
    Public Property OSID As String
    Public Property APPID As String
    Public Property FIREWALLGROUPID As String

    ' --- Storing for later use ---
    ' Dim json = output
    ' Dim reports = JsonConvert.DeserializeObject(Of Dictionary(Of String, ReportData))(json)
    ' $"{pair.Key} {pair.Value.VM_ID}"


    '    Dim json = File.ReadAllText("test.json")
    '    Dim reports = JsonConvert.DeserializeObject(Of Dictionary(Of String, ReportData))(json)

    '    For Each pair In reports
    '        Console.WriteLine($"{pair.Key}: {pair.Value.ApiKey}")
    '    Next

End Class