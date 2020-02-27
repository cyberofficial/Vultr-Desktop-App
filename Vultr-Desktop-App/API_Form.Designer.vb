<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class API_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(API_Form))
        Me.API_KEY = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.forget_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'API_KEY
        '
        Me.API_KEY.Dock = System.Windows.Forms.DockStyle.Top
        Me.API_KEY.Location = New System.Drawing.Point(0, 0)
        Me.API_KEY.Name = "API_KEY"
        Me.API_KEY.Size = New System.Drawing.Size(437, 20)
        Me.API_KEY.TabIndex = 0
        '
        'save_btn
        '
        Me.save_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.save_btn.Location = New System.Drawing.Point(0, 20)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(311, 22)
        Me.save_btn.TabIndex = 1
        Me.save_btn.Text = "Click to Save - If you do not want to save just close the form."
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'forget_btn
        '
        Me.forget_btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.forget_btn.Location = New System.Drawing.Point(370, 20)
        Me.forget_btn.Name = "forget_btn"
        Me.forget_btn.Size = New System.Drawing.Size(67, 22)
        Me.forget_btn.TabIndex = 2
        Me.forget_btn.Text = "Forget Key"
        Me.forget_btn.UseVisualStyleBackColor = True
        '
        'API_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(437, 42)
        Me.Controls.Add(Me.forget_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.API_KEY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(453, 81)
        Me.Name = "API_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "API Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents API_KEY As TextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents forget_btn As Button
End Class
