Public Class ViewLine
    Inherits InputLine

    Private labels(14) As Label
    Public Property StrikeRate As Decimal
    Public Property BatAverage As Decimal
    Public Property BowlAverage As Decimal


    Public Enum propertyNums As Integer
        forename
        surname
        matches
        batInnings
        notOut
        runsScored
        ballsFaced
        strikeRate
        batAverage
        bowlInnings
        ballsBowled
        runsConceded
        wickets
        bowlAverage

    End Enum


    Public Sub New(player As Player)
        MyBase.New(player)
        Initialise()

    End Sub

    Private Sub Initialise()
        CalculateProperties()
        InitialiseLabels()
        ShowPlayerDetials()
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub InitialiseLabels()

        For i = 0 To labels.Length - 1

            labels(i) = New Label()

        Next
    End Sub

#Region "Calculations"
    Private Sub CalculateProperties()
        CalculateStrikeRate()
        CalculateBatAverage()
        CalculateBowlAverage()
    End Sub

    Private Sub CalculateStrikeRate()
        If (ActivePlayer.RunsScored > 0 And ActivePlayer.BallsFaced > 0) Then
            StrikeRate = Math.Round((ActivePlayer.RunsScored / ActivePlayer.BallsFaced) * 100, 2)
        End If
    End Sub

    Private Sub CalculateBatAverage()
        BatAverage = PickTeam.BattingAverage(ActivePlayer)
    End Sub

    Private Sub CalculateBowlAverage()
        BowlAverage = PickTeam.BowlingAverage(ActivePlayer)
    End Sub

#End Region

    Private Sub ShowPlayerDetials()

        For i = propertyNums.matches To labels.Length - 1
            labels(i).SetBounds(labels(propertyNums.surname).Right + i * 50, 5, 45, ViewLine.DefaultHeight)
            labels(i).Visible = True
            Controls.Add(labels(i))
        Next

        labels(propertyNums.forename).Text = ActivePlayer.Forename
        labels(propertyNums.surname).Text = ActivePlayer.Surname

        labels(propertyNums.matches).Text = ActivePlayer.Matches

        labels(propertyNums.batInnings).Text = ActivePlayer.BatInnings
        labels(propertyNums.notOut).Text = ActivePlayer.NotOut
        labels(propertyNums.runsScored).Text = ActivePlayer.RunsScored
        labels(propertyNums.ballsFaced).Text = ActivePlayer.BallsFaced
        labels(propertyNums.batAverage).Text = BatAverage
        labels(propertyNums.strikeRate).Text = StrikeRate

        labels(propertyNums.bowlInnings).Text = ActivePlayer.BowlInnings
        labels(propertyNums.ballsBowled).Text = ActivePlayer.BallsBowled
        labels(propertyNums.runsConceded).Text = ActivePlayer.RunsConceded
        labels(propertyNums.wickets).Text = ActivePlayer.Wickets
        labels(propertyNums.bowlAverage).Text = BowlAverage

        _remove.SetBounds(labels(labels.Length - 1).Left + 44, 0, 55, ViewLine.DefaultHeight)
        Controls.Add(_remove)
    End Sub

End Class
