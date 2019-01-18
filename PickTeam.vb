
'form used to pick a team and print it
Public Class PickTeam
    Private _sortList As New List(Of Player)    'list used to store temporarily the players, to be sorted
    Private _team(10) As PickTeamLine    'Static array to store the final 11 picked 
    Private Const INDENT = 75  'Global variable to store the indentation of the team list on the screen
    Private Const GAP = ViewLine.DefaultHeight + 5 'constant to store the gap between lines

    'sub procedure called when the pick team form is loaded
    Private Sub PickTeam_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For i = 0 To MainForm.PlayerList.ToArray.Length - 1 'for each player in the system
            _sortList.Add(MainForm.PlayerList(i)) 'add them to the list to be sorted
        Next
        PickTeam() 'automatically output a suggested team
        AddPlayers()
    End Sub

    'sub procedure called to add player names to the list box of players
    Private Sub AddPlayers()
        For i = 0 To MainForm.PlayerList.ToArray.Length - 1 'for each player
            _lstPlayers.Items.Add(MainForm.PlayerList(i).Forename & "  " & MainForm.PlayerList(i).Surname) 'add the current player's name to the list box
        Next
    End Sub

    'sub procedure called when the user wishes the system to suggest a team
    '
    'How does the system pick the team?
    '- The 7 players with the highest average are placed in batting average order (descending) in the first 7 slots
    '- The 4 players with the lowest bowling average are placed in the final 4 slots in the batting order

    Private Sub btnPickTeam_Click(sender As System.Object, e As System.EventArgs) Handles btnPickTeam.Click
        For i = 0 To _team.Length - 1 'remove the current team on the UI
            Controls.Remove(_team(i))
        Next
        PickTeam()
    End Sub

    'sub procedure called to generate a suggested team
    Private Sub PickTeam()
        Dim bolwersAdded As Integer = 0 'local variable to store the number of bowlers who are currently in the team
        'sort the list and select the best team then output the team
        BatSort()
        AddBatsmen()
        BowlSort()
        AddBowlers()
    End Sub


    'Funtion to calculate a player's batting average
    'Parameters: A player object to calculate the batting average of
    'Returns: The batting average of the player 
    Public Function BattingAverage(p As Player) As Decimal
        ' if the player has played no games or has never been dismissed
        If (p.BatInnings = 0 Or p.NotOut = p.BatInnings) Then
            Return 0.0
        Else
            'batting average = runs scored / number of dismissals
            Return (p.RunsScored / (p.BatInnings - p.NotOut)) 'return the player's batting average
        End If
    End Function

    'sub procedure to add the batsmen to the user interface
    Private Sub AddBatsmen()
        For i = 0 To 6 'for the 7 batsmen
            _team(i) = New PickTeamLine(_sortList(i)) 'initialise a new line, passing it the current batsmen in the team list
            AddHandler _team(i).RemoveButtonClicked, AddressOf RemovePlayer 'add the remove button's event handler
            _team(i).SetBounds(3 * INDENT, INDENT + GAP * i, ViewLine.DefaultWidth, ViewLine.DefaultHeight) 'set the position/size of the current line
            Controls.Add(_team(i)) 'add the current line to the UI's list of controls
            _team(i).Tag = i 'assign a value in the line to store the line number it is on

        Next

    End Sub

    Private Sub AddBowlers()
        For i = 7 To 10 'for the 4 bowlers
            _team(i) = New PickTeamLine(_sortList(i)) 'initialise a new line, passing it the current bowler in the team list
            AddHandler _team(i).RemoveButtonClicked, AddressOf RemovePlayer 'add the remove button's event handler
            _team(i).SetBounds(3 * INDENT, INDENT + GAP * i, ViewLine.DefaultWidth, ViewLine.DefaultHeight) 'set the position/size of the current line
            Controls.Add(_team(i)) 'add the current line to the UI's list of controls
            _team(i).Tag = i 'assign a value in the line to store the line number it is on
        Next
    End Sub

    'sub procedure called to add a new player to the UI
    'Parameters: The index of the player in the player list to be added
    Private Sub UpdateUI(Index As Integer)

        AddHandler _team(Index).RemoveButtonClicked, AddressOf RemovePlayer 'add the remove button's event handler
        _team(Index).SetBounds(3 * INDENT, INDENT + GAP * Index, ViewLine.DefaultWidth, ViewLine.DefaultHeight) 'set the position/size of the current line
        Controls.Add(_team(Index)) 'add the current line to the UI's list of controls
        _team(Index).Tag = Index 'assign a value in the line to store the line number it is on

    End Sub

    'procedure to sort list of players in order of bowling average
    'implemented using a bubble sort
    Private Sub BowlSort()
        Dim p1, p2, temp As Player 'local variable to store the two current players being compared against each other
        Dim avg1, avg2 As Decimal 'local variable to store p1's and p2's bowling average
        Dim swapped As Boolean 'local variable to store whether or not a swap has taken place

        Do
            swapped = False
            For i = 1 To _sortList.ToArray.Length - 1 'for each pair of players in the player list
                p2 = _sortList(i) 'assign the next 2 players
                p1 = _sortList(i - 1)
                avg1 = BowlingAverage(p1) 'calculate their bowling averages
                avg2 = BowlingAverage(p2)

                If (avg1 > avg2) Then 'if the pair are out of place then swap the two players
                    temp = p2
                    _sortList(i) = p1
                    _sortList(i - 1) = temp
                    swapped = True 'record something has been swapped
                End If
            Next
        Loop Until swapped = False

    End Sub

    'procedure to sort list of players in order of batting average
    'implemented using a bubble sort
    Private Sub BatSort()

        Dim p1, p2, temp As Player 'local variable to store the two current players being compared against each other
        Dim avg1, avg2 As Decimal 'local variable to store p1's and p2's batting average
        Dim swapped As Boolean 'local variable to store whether or not a swap has taken place

        Do
            swapped = False
            For i = 1 To _sortList.ToArray.Length - 1 'for each pair of players in the player list
                p2 = _sortList(i) 'assign the next 2 players
                p1 = _sortList(i - 1)
                avg1 = BattingAverage(p1) 'calculate their batting averages
                avg2 = BattingAverage(p2)

                If (avg1 < avg2) Then 'if the pair are out of place then swap the two players
                    temp = p2
                    _sortList(i) = p1
                    _sortList(i - 1) = temp
                    swapped = True 'record something has been swapped
                End If
            Next
        Loop Until swapped = False

    End Sub

    'function to calculate a player's bowling average
    'Parameters: the player object who'se average is to be calculated
    Public Function BowlingAverage(p As Player) As Decimal
        If (p.BowlInnings = 0 Or p.Wickets = 0) Then
            'if no games have been played, or the player has made no dismissals
            Return 0.0
        Else
            'bowling average = total number of runs conceded / total wickets taken
            Return p.RunsConceded / p.Wickets 'return the bowling average
        End If
    End Function


    'sub procedure called to handle the remove button click event of a player 
    'removes the player from the user interface
    'Parameters: sender - the line that the event was generated from (the line who's "remove" button was clicked)
    '            e - as no extra information is needed to handle this event, other than the object that generated the event, this is always passed as EventArgs.Empty
    '                when the event is generated from the BowlInputLine class. 
    Private Sub RemovePlayer(Sender As Object, e As EventArgs)
        Controls.Remove(Sender) 'remove the player from the user interface
        _team(Sender.Tag) = New PickTeamLine(New Player) 'reset the removed line
        _team(Sender.Tag).ActivePlayer.PlayerID = -1 'record that this line does not exist on the UI
        _team(Sender.Tag).Tag = -1
    End Sub

    'sub procedure called when a player is selected to be included in the team
    'adds the player to the team, at a specified position (specified by the user), if it has not already been taken
    Private Sub _lstPlayers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles _lstPlayers.SelectedIndexChanged

        Dim selection As Player = MainForm.PlayerList(_lstPlayers.SelectedIndex) 'local variable to store the selected player

        Dim InputNum = GetInputPosition() 'get the number that the user wishes the selected player to bat at
        If (InputNum < 0 Or InputNum > 10) Then
            MsgBox("Input a number between 1 and 11")
        Else
            If (CheckSelectedPlayer(selection.PlayerID)) Then 'if the selection is acceptable

                _team(InputNum - 1) = New PickTeamLine(MainForm.PlayerList(_lstPlayers.SelectedIndex)) 'update the team list
                UpdateUI(InputNum - 1) 'update the user interface
            Else
                MsgBox("Players can only appear once in the team") 'if the player already is on the form - output that the player can't be selected again.
            End If
        End If
    End Sub

    'function to check whether or not a selected player is already in the team 
    'Parameters: ID - the player's ID who has been selected
    Private Function CheckSelectedPlayer(ID As Integer) As Boolean
        For i = 0 To _team.Length - 1 'for each player in the team
            If (ID = _team(i).ActivePlayer.PlayerID) Then 'If the player already features in the team
                Return False 'break the loop and return that the player already features in the team
            End If
        Next
        Return True
    End Function

    'function called to get the position that the user wishes a selected player will bat at
    '
    Private Function GetInputPosition() As Integer

        Dim num As Integer 'local variable to store the input position
        Try
            num = InputBox("Input the number this player will bat at", "Pick Team") 'attempt to cast the input value as an integer
        Catch ex As InvalidCastException 'if the casting fails
            Return -1 'return that an invalid item was input
        End Try
        Return num
    End Function

    'procedure called when the print button is clicked
    Private Sub _btnPrintTeam_Click(sender As System.Object, e As System.EventArgs) Handles _btnPrintTeam.Click
        PrintDocument.Print()
    End Sub

    'Procedure called when the print document is sent to print


    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Courier New", 20, FontStyle.Regular) 'font used to print the batting order
        Dim forename, surname As String 'local variables to store the names of the current player being added to the print document
        Dim batAvg, bowlAvg As Double 'local varaibles to store the averages of the current player being added to the print document
        e.Graphics.DrawString("Saddleworth Cricket Club", font, Brushes.Black, 150, 75) 'add title
        e.Graphics.DrawString(Today, font, Brushes.Black, 500, 150) 'add date
        For i = 0 To _team.Length - 1 'for each player
            forename = _team(i).ActivePlayer.Forename 'get the player's details
            surname = _team(i).ActivePlayer.Surname
            batAvg = BattingAverage(_team(i).ActivePlayer)
            bowlAvg = BowlingAverage(_team(i).ActivePlayer)

            e.Graphics.DrawString(i + 1, font, Brushes.Black, 75, 250 + (i * font.Height)) 'add each details to the print document
            e.Graphics.DrawString(forename, font, Brushes.Black, 150, 250 + (i * font.Height))
            e.Graphics.DrawString(surname, font, Brushes.Black, 350, 250 + (i * font.Height))
            e.Graphics.DrawString(Math.Round(bowlAvg, 2), font, Brushes.Black, 550, 250 + (i * font.Height))
            e.Graphics.DrawString(Math.Round(batAvg, 2), font, Brushes.Black, 600, 250 + (i * font.Height))

        Next
    End Sub

    'sub procedure called when the pick team form is closed 
    'resets the necessary UI objects
    Private Sub PickTeam_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        _lstPlayers.Items.Clear() 'clear the list box of players
        _sortList.Clear() 'clear the list of players to be sorted
        For i = 0 To _team.Length - 1
            Controls.Remove(_team(i)) 'remove each member in the current team
        Next
    End Sub
End Class
