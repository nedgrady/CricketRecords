<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCricketers
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.GroupRequired = New System.Windows.Forms.GroupBox()
        Me.OptionalGroup = New System.Windows.Forms.GroupBox()
        Me.lblDefault = New System.Windows.Forms.Label()
        Me.txtBallsBowled = New System.Windows.Forms.TextBox()
        Me.lblBallsBowled = New System.Windows.Forms.Label()
        Me.txtBowledInns = New System.Windows.Forms.TextBox()
        Me.lblBowlInnings = New System.Windows.Forms.Label()
        Me.txtWickets = New System.Windows.Forms.TextBox()
        Me.lblWickets = New System.Windows.Forms.Label()
        Me.txtConcededRuns = New System.Windows.Forms.TextBox()
        Me.lblConcededRuns = New System.Windows.Forms.Label()
        Me.txtBallsFaced = New System.Windows.Forms.TextBox()
        Me.lblBallsFaced = New System.Windows.Forms.Label()
        Me.txtRunsScored = New System.Windows.Forms.TextBox()
        Me.lblScoredRuns = New System.Windows.Forms.Label()
        Me.txtNotOut = New System.Windows.Forms.TextBox()
        Me.lblNotOut = New System.Windows.Forms.Label()
        Me.txtMatches = New System.Windows.Forms.TextBox()
        Me.txtBatInns = New System.Windows.Forms.TextBox()
        Me.lblMatches = New System.Windows.Forms.Label()
        Me.lblBatInnings = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstAddedPlayers = New System.Windows.Forms.ListBox()
        Me.GroupRequired.SuspendLayout()
        Me.OptionalGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Forename:"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(82, 35)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(100, 20)
        Me.txtForename.TabIndex = 1
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(82, 61)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(15, 64)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname:"
        '
        'GroupRequired
        '
        Me.GroupRequired.Controls.Add(Me.txtForename)
        Me.GroupRequired.Controls.Add(Me.txtSurname)
        Me.GroupRequired.Controls.Add(Me.lblName)
        Me.GroupRequired.Controls.Add(Me.lblSurname)
        Me.GroupRequired.Location = New System.Drawing.Point(12, 12)
        Me.GroupRequired.Name = "GroupRequired"
        Me.GroupRequired.Size = New System.Drawing.Size(200, 100)
        Me.GroupRequired.TabIndex = 4
        Me.GroupRequired.TabStop = False
        Me.GroupRequired.Text = "Required Fields"
        '
        'OptionalGroup
        '
        Me.OptionalGroup.Controls.Add(Me.lblDefault)
        Me.OptionalGroup.Controls.Add(Me.txtBallsBowled)
        Me.OptionalGroup.Controls.Add(Me.lblBallsBowled)
        Me.OptionalGroup.Controls.Add(Me.txtBowledInns)
        Me.OptionalGroup.Controls.Add(Me.lblBowlInnings)
        Me.OptionalGroup.Controls.Add(Me.txtWickets)
        Me.OptionalGroup.Controls.Add(Me.lblWickets)
        Me.OptionalGroup.Controls.Add(Me.txtConcededRuns)
        Me.OptionalGroup.Controls.Add(Me.lblConcededRuns)
        Me.OptionalGroup.Controls.Add(Me.txtBallsFaced)
        Me.OptionalGroup.Controls.Add(Me.lblBallsFaced)
        Me.OptionalGroup.Controls.Add(Me.txtRunsScored)
        Me.OptionalGroup.Controls.Add(Me.lblScoredRuns)
        Me.OptionalGroup.Controls.Add(Me.txtNotOut)
        Me.OptionalGroup.Controls.Add(Me.lblNotOut)
        Me.OptionalGroup.Controls.Add(Me.txtMatches)
        Me.OptionalGroup.Controls.Add(Me.txtBatInns)
        Me.OptionalGroup.Controls.Add(Me.lblMatches)
        Me.OptionalGroup.Controls.Add(Me.lblBatInnings)
        Me.OptionalGroup.Location = New System.Drawing.Point(269, 12)
        Me.OptionalGroup.Name = "OptionalGroup"
        Me.OptionalGroup.Size = New System.Drawing.Size(228, 286)
        Me.OptionalGroup.TabIndex = 5
        Me.OptionalGroup.TabStop = False
        Me.OptionalGroup.Text = "Optional Fields"
        '
        'lblDefault
        '
        Me.lblDefault.AutoSize = True
        Me.lblDefault.Location = New System.Drawing.Point(126, 16)
        Me.lblDefault.Name = "lblDefault"
        Me.lblDefault.Size = New System.Drawing.Size(89, 13)
        Me.lblDefault.TabIndex = 18
        Me.lblDefault.Text = "Default Value = 0"
        '
        'txtBallsBowled
        '
        Me.txtBallsBowled.Location = New System.Drawing.Point(121, 202)
        Me.txtBallsBowled.Name = "txtBallsBowled"
        Me.txtBallsBowled.Size = New System.Drawing.Size(100, 20)
        Me.txtBallsBowled.TabIndex = 13
        '
        'lblBallsBowled
        '
        Me.lblBallsBowled.AutoSize = True
        Me.lblBallsBowled.Location = New System.Drawing.Point(35, 205)
        Me.lblBallsBowled.Name = "lblBallsBowled"
        Me.lblBallsBowled.Size = New System.Drawing.Size(70, 13)
        Me.lblBallsBowled.TabIndex = 16
        Me.lblBallsBowled.Text = "Balls Bowled:"
        '
        'txtBowledInns
        '
        Me.txtBowledInns.Location = New System.Drawing.Point(122, 176)
        Me.txtBowledInns.Name = "txtBowledInns"
        Me.txtBowledInns.Size = New System.Drawing.Size(100, 20)
        Me.txtBowledInns.TabIndex = 11
        '
        'lblBowlInnings
        '
        Me.lblBowlInnings.AutoSize = True
        Me.lblBowlInnings.Location = New System.Drawing.Point(37, 179)
        Me.lblBowlInnings.Name = "lblBowlInnings"
        Me.lblBowlInnings.Size = New System.Drawing.Size(68, 13)
        Me.lblBowlInnings.TabIndex = 14
        Me.lblBowlInnings.Text = "Bowled Inns:"
        '
        'txtWickets
        '
        Me.txtWickets.Location = New System.Drawing.Point(122, 254)
        Me.txtWickets.Name = "txtWickets"
        Me.txtWickets.Size = New System.Drawing.Size(100, 20)
        Me.txtWickets.TabIndex = 17
        '
        'lblWickets
        '
        Me.lblWickets.AutoSize = True
        Me.lblWickets.Location = New System.Drawing.Point(57, 257)
        Me.lblWickets.Name = "lblWickets"
        Me.lblWickets.Size = New System.Drawing.Size(49, 13)
        Me.lblWickets.TabIndex = 12
        Me.lblWickets.Text = "Wickets:"
        '
        'txtConcededRuns
        '
        Me.txtConcededRuns.Location = New System.Drawing.Point(122, 228)
        Me.txtConcededRuns.Name = "txtConcededRuns"
        Me.txtConcededRuns.Size = New System.Drawing.Size(100, 20)
        Me.txtConcededRuns.TabIndex = 15
        '
        'lblConcededRuns
        '
        Me.lblConcededRuns.AutoSize = True
        Me.lblConcededRuns.Location = New System.Drawing.Point(19, 231)
        Me.lblConcededRuns.Name = "lblConcededRuns"
        Me.lblConcededRuns.Size = New System.Drawing.Size(87, 13)
        Me.lblConcededRuns.TabIndex = 10
        Me.lblConcededRuns.Text = "Conceded Runs:"
        '
        'txtBallsFaced
        '
        Me.txtBallsFaced.Location = New System.Drawing.Point(121, 146)
        Me.txtBallsFaced.Name = "txtBallsFaced"
        Me.txtBallsFaced.Size = New System.Drawing.Size(100, 20)
        Me.txtBallsFaced.TabIndex = 9
        '
        'lblBallsFaced
        '
        Me.lblBallsFaced.AutoSize = True
        Me.lblBallsFaced.Location = New System.Drawing.Point(40, 149)
        Me.lblBallsFaced.Name = "lblBallsFaced"
        Me.lblBallsFaced.Size = New System.Drawing.Size(65, 13)
        Me.lblBallsFaced.TabIndex = 8
        Me.lblBallsFaced.Text = "Balls Faced:"
        '
        'txtRunsScored
        '
        Me.txtRunsScored.Location = New System.Drawing.Point(122, 116)
        Me.txtRunsScored.Name = "txtRunsScored"
        Me.txtRunsScored.Size = New System.Drawing.Size(100, 20)
        Me.txtRunsScored.TabIndex = 7
        '
        'lblScoredRuns
        '
        Me.lblScoredRuns.AutoSize = True
        Me.lblScoredRuns.Location = New System.Drawing.Point(33, 119)
        Me.lblScoredRuns.Name = "lblScoredRuns"
        Me.lblScoredRuns.Size = New System.Drawing.Size(72, 13)
        Me.lblScoredRuns.TabIndex = 6
        Me.lblScoredRuns.Text = "Runs Scored:"
        '
        'txtNotOut
        '
        Me.txtNotOut.Location = New System.Drawing.Point(122, 90)
        Me.txtNotOut.Name = "txtNotOut"
        Me.txtNotOut.Size = New System.Drawing.Size(100, 20)
        Me.txtNotOut.TabIndex = 5
        '
        'lblNotOut
        '
        Me.lblNotOut.AutoSize = True
        Me.lblNotOut.Location = New System.Drawing.Point(53, 93)
        Me.lblNotOut.Name = "lblNotOut"
        Me.lblNotOut.Size = New System.Drawing.Size(52, 13)
        Me.lblNotOut.TabIndex = 4
        Me.lblNotOut.Text = "Not Outs:"
        '
        'txtMatches
        '
        Me.txtMatches.Location = New System.Drawing.Point(122, 38)
        Me.txtMatches.Name = "txtMatches"
        Me.txtMatches.Size = New System.Drawing.Size(100, 20)
        Me.txtMatches.TabIndex = 1
        '
        'txtBatInns
        '
        Me.txtBatInns.Location = New System.Drawing.Point(122, 64)
        Me.txtBatInns.Name = "txtBatInns"
        Me.txtBatInns.Size = New System.Drawing.Size(100, 20)
        Me.txtBatInns.TabIndex = 3
        '
        'lblMatches
        '
        Me.lblMatches.AutoSize = True
        Me.lblMatches.Location = New System.Drawing.Point(54, 41)
        Me.lblMatches.Name = "lblMatches"
        Me.lblMatches.Size = New System.Drawing.Size(51, 13)
        Me.lblMatches.TabIndex = 0
        Me.lblMatches.Text = "Matches:"
        '
        'lblBatInnings
        '
        Me.lblBatInnings.AutoSize = True
        Me.lblBatInnings.Location = New System.Drawing.Point(39, 67)
        Me.lblBatInnings.Name = "lblBatInnings"
        Me.lblBatInnings.Size = New System.Drawing.Size(66, 13)
        Me.lblBatInnings.TabIndex = 2
        Me.lblBatInnings.Text = "Batting Inns:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 144)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 75)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Add Player"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(143, 144)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 75)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(398, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstAddedPlayers
        '
        Me.lstAddedPlayers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstAddedPlayers.FormattingEnabled = True
        Me.lstAddedPlayers.Location = New System.Drawing.Point(12, 240)
        Me.lstAddedPlayers.Name = "lstAddedPlayers"
        Me.lstAddedPlayers.Size = New System.Drawing.Size(240, 82)
        Me.lstAddedPlayers.TabIndex = 9
        '
        'AddCricketers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 340)
        Me.Controls.Add(Me.lstAddedPlayers)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.OptionalGroup)
        Me.Controls.Add(Me.GroupRequired)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "AddCricketers"
        Me.Text = "Add Player"
        Me.GroupRequired.ResumeLayout(False)
        Me.GroupRequired.PerformLayout()
        Me.OptionalGroup.ResumeLayout(False)
        Me.OptionalGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents GroupRequired As System.Windows.Forms.GroupBox
    Friend WithEvents OptionalGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtMatches As System.Windows.Forms.TextBox
    Friend WithEvents txtBatInns As System.Windows.Forms.TextBox
    Friend WithEvents lblMatches As System.Windows.Forms.Label
    Friend WithEvents lblBatInnings As System.Windows.Forms.Label
    Friend WithEvents txtConcededRuns As System.Windows.Forms.TextBox
    Friend WithEvents lblConcededRuns As System.Windows.Forms.Label
    Friend WithEvents txtBallsFaced As System.Windows.Forms.TextBox
    Friend WithEvents lblBallsFaced As System.Windows.Forms.Label
    Friend WithEvents txtRunsScored As System.Windows.Forms.TextBox
    Friend WithEvents lblScoredRuns As System.Windows.Forms.Label
    Friend WithEvents txtNotOut As System.Windows.Forms.TextBox
    Friend WithEvents lblNotOut As System.Windows.Forms.Label
    Friend WithEvents txtWickets As System.Windows.Forms.TextBox
    Friend WithEvents lblWickets As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBowledInns As System.Windows.Forms.TextBox
    Friend WithEvents lblBowlInnings As System.Windows.Forms.Label
    Friend WithEvents txtBallsBowled As System.Windows.Forms.TextBox
    Friend WithEvents lblBallsBowled As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblDefault As System.Windows.Forms.Label
    Friend WithEvents lstAddedPlayers As System.Windows.Forms.ListBox

End Class
