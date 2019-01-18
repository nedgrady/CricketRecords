<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickTeam
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
        Me.btnPickTeam = New System.Windows.Forms.Button()
        Me._lstPlayers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._btnPrintTeam = New System.Windows.Forms.Button()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPickTeam
        '
        Me.btnPickTeam.Location = New System.Drawing.Point(12, 334)
        Me.btnPickTeam.Name = "btnPickTeam"
        Me.btnPickTeam.Size = New System.Drawing.Size(93, 108)
        Me.btnPickTeam.TabIndex = 0
        Me.btnPickTeam.Text = "Suggest Team"
        Me.btnPickTeam.UseVisualStyleBackColor = True
        '
        '_lstPlayers
        '
        Me._lstPlayers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._lstPlayers.FormattingEnabled = True
        Me._lstPlayers.Location = New System.Drawing.Point(12, 12)
        Me._lstPlayers.Name = "_lstPlayers"
        Me._lstPlayers.Size = New System.Drawing.Size(192, 316)
        Me._lstPlayers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bat " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Avg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bowl" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Avg"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CricketRecords.My.Resources.Resources.SCBTC_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(473, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 72)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        '_btnPrintTeam
        '
        Me._btnPrintTeam.Location = New System.Drawing.Point(111, 334)
        Me._btnPrintTeam.Name = "_btnPrintTeam"
        Me._btnPrintTeam.Size = New System.Drawing.Size(93, 108)
        Me._btnPrintTeam.TabIndex = 6
        Me._btnPrintTeam.Text = "Print Team"
        Me._btnPrintTeam.UseVisualStyleBackColor = True
        '
        'PrintDocument
        '
        '
        'PickTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(571, 454)
        Me.Controls.Add(Me._btnPrintTeam)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._lstPlayers)
        Me.Controls.Add(Me.btnPickTeam)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "PickTeam"
        Me.Text = "PickTeam"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPickTeam As System.Windows.Forms.Button
    Friend WithEvents _lstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _btnPrintTeam As System.Windows.Forms.Button
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
End Class
