<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLogInForm
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
        Me._lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._txtUsername = New System.Windows.Forms.TextBox()
        Me._txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me._txtPassword = New System.Windows.Forms.TextBox()
        Me._btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lblUser
        '
        Me._lblUser.AutoSize = True
        Me._lblUser.Location = New System.Drawing.Point(24, 95)
        Me._lblUser.Name = "_lblUser"
        Me._lblUser.Size = New System.Drawing.Size(83, 13)
        Me._lblUser.TabIndex = 0
        Me._lblUser.Text = "New Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password:"
        '
        '_txtUsername
        '
        Me._txtUsername.Location = New System.Drawing.Point(126, 95)
        Me._txtUsername.Name = "_txtUsername"
        Me._txtUsername.Size = New System.Drawing.Size(155, 20)
        Me._txtUsername.TabIndex = 3
        '
        '_txtConfirmPassword
        '
        Me._txtConfirmPassword.Location = New System.Drawing.Point(126, 172)
        Me._txtConfirmPassword.Name = "_txtConfirmPassword"
        Me._txtConfirmPassword.Size = New System.Drawing.Size(155, 20)
        Me._txtConfirmPassword.TabIndex = 4
        '
        '_txtPassword
        '
        Me._txtPassword.Location = New System.Drawing.Point(126, 132)
        Me._txtPassword.Name = "_txtPassword"
        Me._txtPassword.Size = New System.Drawing.Size(155, 20)
        Me._txtPassword.TabIndex = 5
        '
        '_btnSubmit
        '
        Me._btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me._btnSubmit.Location = New System.Drawing.Point(63, 210)
        Me._btnSubmit.Name = "_btnSubmit"
        Me._btnSubmit.Size = New System.Drawing.Size(168, 62)
        Me._btnSubmit.TabIndex = 6
        Me._btnSubmit.Text = "Add Details"
        Me._btnSubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CricketRecords.My.Resources.Resources.SCBTC_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(113, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 77)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'AddLogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(293, 298)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me._btnSubmit)
        Me.Controls.Add(Me._txtPassword)
        Me.Controls.Add(Me._txtConfirmPassword)
        Me.Controls.Add(Me._txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._lblUser)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "AddLogInForm"
        Me.Text = "Add Admin Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents _txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents _txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents _btnSubmit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
