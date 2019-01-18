<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMatch
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
        Me._lstBatsmen = New System.Windows.Forms.ListBox()
        Me._btnUpdateBatsmen = New System.Windows.Forms.Button()
        Me._lstBowlers = New System.Windows.Forms.ListBox()
        Me._btnUpdateBowlers = New System.Windows.Forms.Button()
        Me._lblName = New System.Windows.Forms.Label()
        Me._lblRunsScored = New System.Windows.Forms.Label()
        Me._lblBallsFaced = New System.Windows.Forms.Label()
        Me._lblNotOut = New System.Windows.Forms.Label()
        Me._lblConcededRuns = New System.Windows.Forms.Label()
        Me._lblOversBowled = New System.Windows.Forms.Label()
        Me._lblBowlName = New System.Windows.Forms.Label()
        Me._lblWicketsTaken = New System.Windows.Forms.Label()
        Me._lblBatsmenRoster = New System.Windows.Forms.Label()
        Me._lblBowlRoster = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lstBatsmen
        '
        Me._lstBatsmen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._lstBatsmen.FormattingEnabled = True
        Me._lstBatsmen.Location = New System.Drawing.Point(477, 69)
        Me._lstBatsmen.Name = "_lstBatsmen"
        Me._lstBatsmen.Size = New System.Drawing.Size(120, 199)
        Me._lstBatsmen.TabIndex = 0
        '
        '_btnUpdateBatsmen
        '
        Me._btnUpdateBatsmen.Location = New System.Drawing.Point(22, 84)
        Me._btnUpdateBatsmen.Name = "_btnUpdateBatsmen"
        Me._btnUpdateBatsmen.Size = New System.Drawing.Size(100, 25)
        Me._btnUpdateBatsmen.TabIndex = 1
        Me._btnUpdateBatsmen.Text = "Update Batsmen"
        Me._btnUpdateBatsmen.UseVisualStyleBackColor = True
        '
        '_lstBowlers
        '
        Me._lstBowlers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._lstBowlers.FormattingEnabled = True
        Me._lstBowlers.Location = New System.Drawing.Point(1050, 69)
        Me._lstBowlers.Name = "_lstBowlers"
        Me._lstBowlers.Size = New System.Drawing.Size(120, 212)
        Me._lstBowlers.TabIndex = 2
        '
        '_btnUpdateBowlers
        '
        Me._btnUpdateBowlers.Location = New System.Drawing.Point(630, 12)
        Me._btnUpdateBowlers.Name = "_btnUpdateBowlers"
        Me._btnUpdateBowlers.Size = New System.Drawing.Size(106, 23)
        Me._btnUpdateBowlers.TabIndex = 3
        Me._btnUpdateBowlers.Text = "Update Bowlers"
        Me._btnUpdateBowlers.UseVisualStyleBackColor = True
        '
        '_lblName
        '
        Me._lblName.AutoSize = True
        Me._lblName.Location = New System.Drawing.Point(50, 50)
        Me._lblName.Name = "_lblName"
        Me._lblName.Size = New System.Drawing.Size(35, 13)
        Me._lblName.TabIndex = 4
        Me._lblName.Text = "Name"
        '
        '_lblRunsScored
        '
        Me._lblRunsScored.AutoSize = True
        Me._lblRunsScored.Location = New System.Drawing.Point(205, 37)
        Me._lblRunsScored.Name = "_lblRunsScored"
        Me._lblRunsScored.Size = New System.Drawing.Size(41, 26)
        Me._lblRunsScored.TabIndex = 5
        Me._lblRunsScored.Text = " Runs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scored" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        '_lblBallsFaced
        '
        Me._lblBallsFaced.AutoSize = True
        Me._lblBallsFaced.Location = New System.Drawing.Point(262, 37)
        Me._lblBallsFaced.Name = "_lblBallsFaced"
        Me._lblBallsFaced.Size = New System.Drawing.Size(37, 26)
        Me._lblBallsFaced.TabIndex = 6
        Me._lblBallsFaced.Text = " Balls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Faced"
        '
        '_lblNotOut
        '
        Me._lblNotOut.AutoSize = True
        Me._lblNotOut.Location = New System.Drawing.Point(305, 37)
        Me._lblNotOut.Name = "_lblNotOut"
        Me._lblNotOut.Size = New System.Drawing.Size(24, 39)
        Me._lblNotOut.TabIndex = 7
        Me._lblNotOut.Text = "Not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Out" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        '_lblConcededRuns
        '
        Me._lblConcededRuns.AutoSize = True
        Me._lblConcededRuns.Location = New System.Drawing.Point(876, 37)
        Me._lblConcededRuns.Name = "_lblConcededRuns"
        Me._lblConcededRuns.Size = New System.Drawing.Size(56, 26)
        Me._lblConcededRuns.TabIndex = 10
        Me._lblConcededRuns.Text = "    Runs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conceded"
        '
        '_lblOversBowled
        '
        Me._lblOversBowled.AutoSize = True
        Me._lblOversBowled.Location = New System.Drawing.Point(828, 37)
        Me._lblOversBowled.Name = "_lblOversBowled"
        Me._lblOversBowled.Size = New System.Drawing.Size(42, 26)
        Me._lblOversBowled.TabIndex = 9
        Me._lblOversBowled.Text = " Overs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bowled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        '_lblBowlName
        '
        Me._lblBowlName.AutoSize = True
        Me._lblBowlName.Location = New System.Drawing.Point(668, 50)
        Me._lblBowlName.Name = "_lblBowlName"
        Me._lblBowlName.Size = New System.Drawing.Size(35, 13)
        Me._lblBowlName.TabIndex = 8
        Me._lblBowlName.Text = "Name"
        '
        '_lblWicketsTaken
        '
        Me._lblWicketsTaken.AutoSize = True
        Me._lblWicketsTaken.Location = New System.Drawing.Point(937, 37)
        Me._lblWicketsTaken.Name = "_lblWicketsTaken"
        Me._lblWicketsTaken.Size = New System.Drawing.Size(46, 26)
        Me._lblWicketsTaken.TabIndex = 12
        Me._lblWicketsTaken.Text = "Wickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Taken"
        '
        '_lblBatsmenRoster
        '
        Me._lblBatsmenRoster.AutoSize = True
        Me._lblBatsmenRoster.Location = New System.Drawing.Point(492, 50)
        Me._lblBatsmenRoster.Name = "_lblBatsmenRoster"
        Me._lblBatsmenRoster.Size = New System.Drawing.Size(82, 13)
        Me._lblBatsmenRoster.TabIndex = 13
        Me._lblBatsmenRoster.Text = "Batsmen Roster"
        '
        '_lblBowlRoster
        '
        Me._lblBowlRoster.AutoSize = True
        Me._lblBowlRoster.Location = New System.Drawing.Point(1067, 50)
        Me._lblBowlRoster.Name = "_lblBowlRoster"
        Me._lblBowlRoster.Size = New System.Drawing.Size(73, 13)
        Me._lblBowlRoster.TabIndex = 14
        Me._lblBowlRoster.Text = "Bowler Roster"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CricketRecords.My.Resources.Resources.SCBTC_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1186, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 73)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'AddMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1277, 603)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me._lblBowlRoster)
        Me.Controls.Add(Me._lblBatsmenRoster)
        Me.Controls.Add(Me._lblWicketsTaken)
        Me.Controls.Add(Me._lblConcededRuns)
        Me.Controls.Add(Me._lblOversBowled)
        Me.Controls.Add(Me._lblBowlName)
        Me.Controls.Add(Me._lblNotOut)
        Me.Controls.Add(Me._lblBallsFaced)
        Me.Controls.Add(Me._lblRunsScored)
        Me.Controls.Add(Me._lblName)
        Me.Controls.Add(Me._btnUpdateBowlers)
        Me.Controls.Add(Me._lstBowlers)
        Me.Controls.Add(Me._btnUpdateBatsmen)
        Me.Controls.Add(Me._lstBatsmen)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "AddMatch"
        Me.Text = "AddMatch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _lstBatsmen As System.Windows.Forms.ListBox
    Friend WithEvents _btnUpdateBatsmen As System.Windows.Forms.Button
    Friend WithEvents _lstBowlers As System.Windows.Forms.ListBox
    Friend WithEvents _btnUpdateBowlers As System.Windows.Forms.Button
    Friend WithEvents _lblName As System.Windows.Forms.Label
    Friend WithEvents _lblRunsScored As System.Windows.Forms.Label
    Friend WithEvents _lblBallsFaced As System.Windows.Forms.Label
    Friend WithEvents _lblNotOut As System.Windows.Forms.Label
    Friend WithEvents _lblConcededRuns As System.Windows.Forms.Label
    Friend WithEvents _lblOversBowled As System.Windows.Forms.Label
    Friend WithEvents _lblBowlName As System.Windows.Forms.Label
    Friend WithEvents _lblWicketsTaken As System.Windows.Forms.Label
    Friend WithEvents _lblBatsmenRoster As System.Windows.Forms.Label
    Friend WithEvents _lblBowlRoster As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
