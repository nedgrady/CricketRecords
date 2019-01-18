<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me._btnNewPlayer = New System.Windows.Forms.Button()
        Me._btnEditPlayers = New System.Windows.Forms.Button()
        Me._btnAddMatch = New System.Windows.Forms.Button()
        Me._btnCompare = New System.Windows.Forms.Button()
        Me._btnPickTeam = New System.Windows.Forms.Button()
        Me._btnAddLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_btnNewPlayer
        '
        Me._btnNewPlayer.Location = New System.Drawing.Point(69, 3)
        Me._btnNewPlayer.Name = "_btnNewPlayer"
        Me._btnNewPlayer.Size = New System.Drawing.Size(89, 48)
        Me._btnNewPlayer.TabIndex = 0
        Me._btnNewPlayer.Text = "New Player"
        Me._btnNewPlayer.UseVisualStyleBackColor = True
        '
        '_btnEditPlayers
        '
        Me._btnEditPlayers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._btnEditPlayers.Location = New System.Drawing.Point(216, 3)
        Me._btnEditPlayers.Name = "_btnEditPlayers"
        Me._btnEditPlayers.Size = New System.Drawing.Size(89, 48)
        Me._btnEditPlayers.TabIndex = 1
        Me._btnEditPlayers.Text = "Edit Players"
        Me._btnEditPlayers.UseVisualStyleBackColor = True
        '
        '_btnAddMatch
        '
        Me._btnAddMatch.Location = New System.Drawing.Point(15, 79)
        Me._btnAddMatch.Name = "_btnAddMatch"
        Me._btnAddMatch.Size = New System.Drawing.Size(89, 48)
        Me._btnAddMatch.TabIndex = 2
        Me._btnAddMatch.Text = "Add Match"
        Me._btnAddMatch.UseVisualStyleBackColor = True
        '
        '_btnCompare
        '
        Me._btnCompare.Location = New System.Drawing.Point(69, 160)
        Me._btnCompare.Name = "_btnCompare"
        Me._btnCompare.Size = New System.Drawing.Size(89, 48)
        Me._btnCompare.TabIndex = 3
        Me._btnCompare.Text = "Compare Players"
        Me._btnCompare.UseVisualStyleBackColor = True
        '
        '_btnPickTeam
        '
        Me._btnPickTeam.Location = New System.Drawing.Point(255, 79)
        Me._btnPickTeam.Name = "_btnPickTeam"
        Me._btnPickTeam.Size = New System.Drawing.Size(89, 48)
        Me._btnPickTeam.TabIndex = 4
        Me._btnPickTeam.Text = "Pick Team"
        Me._btnPickTeam.UseVisualStyleBackColor = True
        '
        '_btnAddLogin
        '
        Me._btnAddLogin.Location = New System.Drawing.Point(216, 160)
        Me._btnAddLogin.Name = "_btnAddLogin"
        Me._btnAddLogin.Size = New System.Drawing.Size(89, 48)
        Me._btnAddLogin.TabIndex = 5
        Me._btnAddLogin.Text = "Add Login Details"
        Me._btnAddLogin.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CricketRecords.My.Resources.Resources.SCBTC_Logo
        Me.ClientSize = New System.Drawing.Size(380, 220)
        Me.Controls.Add(Me._btnAddLogin)
        Me.Controls.Add(Me._btnPickTeam)
        Me.Controls.Add(Me._btnCompare)
        Me.Controls.Add(Me._btnAddMatch)
        Me.Controls.Add(Me._btnEditPlayers)
        Me.Controls.Add(Me._btnNewPlayer)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _btnNewPlayer As System.Windows.Forms.Button
    Friend WithEvents _btnEditPlayers As System.Windows.Forms.Button
    Friend WithEvents _btnAddMatch As System.Windows.Forms.Button
    Friend WithEvents _btnCompare As System.Windows.Forms.Button
    Friend WithEvents _btnPickTeam As System.Windows.Forms.Button
    Friend WithEvents _btnAddLogin As System.Windows.Forms.Button
End Class
