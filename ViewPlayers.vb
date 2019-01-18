Public Class ViewPlayers


    Private _viewedPlayers As New List(Of ViewLine)
    Private _UINum As Integer = 0
    Private _gapBetweenLines As Integer = 25

    'enumeration to store 
    Private Enum SortValues As Integer
        Forename
        Surname
        Matches
        BatInns
        NotOut
        RunsScored
        BallsFaced
        BattingAverage
        StrikeRate
        BowledInns
        BallsBowled
        ConcededRuns
        Wickets
        BowlingAverage
    End Enum


    Private Sub ViewPlayers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddPlayerNames()
        addSearchCriteria()
        
    End Sub

    Private Sub AddPlayerNames()
        For i = 0 To MainForm.PlayerList.ToArray.Length - 1
            _lstPlayerRoster.Items.Add(MainForm.PlayerList(i).Forename & " " & MainForm.PlayerList(i).Surname)
        Next
    End Sub

    Private Sub _cboSortIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _cboSortIndex.SelectedIndexChanged

        Dim SortSelection As Integer = _cboSortIndex.SelectedIndex
        RemoveAllPlayers()
        Select Case (SortSelection)

            Case SortValues.BallsBowled : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.BallsBowled.CompareTo(x.ActivePlayer.BallsBowled))
            Case SortValues.BallsFaced : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.BallsFaced.CompareTo(x.ActivePlayer.BallsFaced))
            Case SortValues.BatInns : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.BatInnings.CompareTo(x.ActivePlayer.BatInnings))
                'Case SortValues.BattingAverage : _viewedPlayers.Sort(Function(x, y) x.ActivePlayer.BattingAverage.CompareTo(y.ActivePlayer.BatInnings))
            Case SortValues.BowledInns : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.BowlInnings.CompareTo(x.ActivePlayer.BowlInnings))
                'Case SortValues.BowlingAverage : BowlingAverageSort()
            Case SortValues.ConcededRuns : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.RunsConceded.CompareTo(x.ActivePlayer.RunsConceded))
            Case SortValues.Forename : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.Forename.CompareTo(x.ActivePlayer.Forename))
            Case SortValues.Matches : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.Matches.CompareTo(x.ActivePlayer.Matches))
            Case SortValues.NotOut : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.NotOut.CompareTo(x.ActivePlayer.NotOut))
            Case SortValues.RunsScored : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.RunsScored.CompareTo(x.ActivePlayer.RunsScored))
                ' Case SortValues.StrikeRate : StrikeRateSort()
            Case SortValues.Surname : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.Surname.CompareTo(x.ActivePlayer.Surname))
            Case SortValues.Wickets : _viewedPlayers.Sort(Function(x, y) y.ActivePlayer.Wickets.CompareTo(x.ActivePlayer.Wickets))

        End Select

        ReDisplayPlayers()

    End Sub



    Private Sub addSearchCriteria()
        _cboSortIndex.Items.AddRange({"Forename", "Surname", "Matches", "Inns Batted", "Runs Scored", "Balls Faced", "Not Outs", "Strike Rate", "Bat Average", "Inns bowled", "Balls Bowled", "Runs Conceded", "Wickets", "Bowl Average"})
    End Sub

    Private Sub _lstPlayerRoster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _lstPlayerRoster.SelectedIndexChanged

        Dim lst As ListBox = sender
        Dim selectedPlayer As New ViewLine(MainForm.PlayerList(_lstPlayerRoster.SelectedIndex))

        If (AlreadySelected(lst.SelectedIndex)) Then

            _viewedPlayers.Add(selectedPlayer)
            _viewedPlayers(_UINum).Tag = _UINum
            _viewedPlayers(_UINum).SetBounds(235, 85 + _UINum * ViewLine.DefaultHeight, ViewLine.DefaultWidth, ViewLine.DefaultHeight)
            _viewedPlayers(_UINum).Visible = True
            Controls.Add(_viewedPlayers(_UINum))
            _UINum += 1

            AddHandler selectedPlayer.RemoveButtonClicked, AddressOf PlayerRemoved
        End If

    End Sub


    Private Sub form_closed() Handles Me.FormClosed

        RemoveAllPlayers()
        _viewedPlayers.Clear()
        _lstPlayerRoster.Items.Clear()


    End Sub

    Private Function AlreadySelected(index As Integer) As Boolean

        For i = 0 To _viewedPlayers.ToArray.Length - 1

            If (_viewedPlayers(i).ActivePlayer.PlayerID = index) Then
                Return False
            End If
        Next

        Return True

    End Function

    Private Sub PlayerRemoved(sender As Object, e As EventArgs)

        Dim removedPlayer As ViewLine = sender
        Dim removedIdx As Integer = removedPlayer.Tag
        _viewedPlayers.RemoveAt(removedIdx)
        Controls.Remove(removedPlayer)
        _UINum -= 1
        For i = removedIdx To _viewedPlayers.ToArray.Length - 1
            _viewedPlayers(i).Tag -= 1
            _viewedPlayers(i).SetBounds(_viewedPlayers(i).Left, _viewedPlayers(i).Top - _gapBetweenLines, ViewLine.DefaultWidth, ViewLine.DefaultHeight)
            Controls.Add(_viewedPlayers(i))
        Next

    End Sub

    Private Sub RemoveAllPlayers()
        For i = 0 To _viewedPlayers.ToArray.Length - 1
            Controls.Remove(_viewedPlayers(i))
        Next
        _UINum = 0

    End Sub


    Private Sub ReDisplayPlayers()
        For i = 0 To _viewedPlayers.ToArray.Length - 1
            Controls.Add(_viewedPlayers(i))
            _viewedPlayers(i).SetBounds(235, 85 + _UINum * ViewLine.DefaultHeight, ViewLine.DefaultWidth, ViewLine.DefaultHeight)
            _viewedPlayers(i).Visible = True
            _viewedPlayers(i).Tag = _UINum
            AddHandler _viewedPlayers(i).RemoveButtonClicked, AddressOf PlayerRemoved
            _UINum += 1
        Next
    End Sub

    Private Sub ViewPlayers_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        RemoveAllPlayers()
        _viewedPlayers.Clear()
        _lstPlayerRoster.Items.Clear()
    End Sub
End Class