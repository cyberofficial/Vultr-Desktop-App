<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogIn_Btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Refresh_Btn = New System.Windows.Forms.Button()
        Me.VM_Tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LastPA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastPDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.charges_txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.balance_txt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VM_Tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.LogIn_Btn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 609)
        Me.Panel1.TabIndex = 0
        '
        'LogIn_Btn
        '
        Me.LogIn_Btn.AutoSize = True
        Me.LogIn_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogIn_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogIn_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LogIn_Btn.Location = New System.Drawing.Point(0, 100)
        Me.LogIn_Btn.Name = "LogIn_Btn"
        Me.LogIn_Btn.Size = New System.Drawing.Size(100, 44)
        Me.LogIn_Btn.TabIndex = 0
        Me.LogIn_Btn.Text = "Log In" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "API Key"
        Me.LogIn_Btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Vultr_Desktop_App.My.Resources.Resources.amde2_8tq4y
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Refresh_Btn
        '
        Me.Refresh_Btn.AutoSize = True
        Me.Refresh_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Refresh_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Refresh_Btn.Location = New System.Drawing.Point(6, 6)
        Me.Refresh_Btn.Name = "Refresh_Btn"
        Me.Refresh_Btn.Size = New System.Drawing.Size(95, 27)
        Me.Refresh_Btn.TabIndex = 2
        Me.Refresh_Btn.Text = "Refresh Info"
        Me.Refresh_Btn.UseVisualStyleBackColor = True
        '
        'VM_Tabs
        '
        Me.VM_Tabs.Controls.Add(Me.TabPage1)
        Me.VM_Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VM_Tabs.Location = New System.Drawing.Point(100, 0)
        Me.VM_Tabs.Name = "VM_Tabs"
        Me.VM_Tabs.SelectedIndex = 0
        Me.VM_Tabs.Size = New System.Drawing.Size(624, 609)
        Me.VM_Tabs.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LastPA)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.LastPDate)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.charges_txt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.balance_txt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Refresh_Btn)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Payment Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LastPA
        '
        Me.LastPA.AutoSize = True
        Me.LastPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LastPA.Location = New System.Drawing.Point(226, 108)
        Me.LastPA.Name = "LastPA"
        Me.LastPA.Size = New System.Drawing.Size(16, 24)
        Me.LastPA.TabIndex = 3
        Me.LastPA.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(2, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Payment Ammount: "
        '
        'LastPDate
        '
        Me.LastPDate.AutoSize = True
        Me.LastPDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LastPDate.Location = New System.Drawing.Point(226, 84)
        Me.LastPDate.Name = "LastPDate"
        Me.LastPDate.Size = New System.Drawing.Size(16, 24)
        Me.LastPDate.TabIndex = 3
        Me.LastPDate.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(2, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Payment Date: "
        '
        'charges_txt
        '
        Me.charges_txt.AutoSize = True
        Me.charges_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.charges_txt.Location = New System.Drawing.Point(226, 60)
        Me.charges_txt.Name = "charges_txt"
        Me.charges_txt.Size = New System.Drawing.Size(45, 24)
        Me.charges_txt.TabIndex = 3
        Me.charges_txt.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(2, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pending Charges: "
        '
        'balance_txt
        '
        Me.balance_txt.AutoSize = True
        Me.balance_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.balance_txt.Location = New System.Drawing.Point(226, 36)
        Me.balance_txt.Name = "balance_txt"
        Me.balance_txt.Size = New System.Drawing.Size(45, 24)
        Me.balance_txt.TabIndex = 3
        Me.balance_txt.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(2, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Balance: "
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(724, 609)
        Me.Controls.Add(Me.VM_Tabs)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(740, 648)
        Me.Name = "MainApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vultr - Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VM_Tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogIn_Btn As Button
    Friend WithEvents Refresh_Btn As Button
    Friend WithEvents VM_Tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LastPA As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LastPDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents charges_txt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents balance_txt As Label
    Friend WithEvents Label1 As Label
End Class
