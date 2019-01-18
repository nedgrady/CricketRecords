Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Drawing.Graphics
'Form where the user can edit cricketers in the system
Public Class EditPlayers

    Private _currentPlayer As Player = New Player
    

    Private Enum Valid As Integer 'enumeration to store the order that details about players are stored
        Forename
        Surname
        Matches
        BatInns
        NotOut
        RunsScored
        BallsFaced
        BowledInns
        BallsBowled
        ConcededRuns
        Wickets
    End Enum

    Private _allValid(10) As Boolean 'Global variable to store whether each field or not was valid

    'sub procedure called on form load
    Private Sub EditPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each player As Player In MainForm.PlayerList 'add the name of each player to the combo box
            cboPlayers.Items.Add(player.Forename & "  " & player.Surname)
        Next
        cboPlayers.Text = "Player List" 'set a temporary title to the combo box
    End Sub

    'sub procedure called when a player to be edited is selected
    Private Sub cboPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlayers.SelectedIndexChanged

        _currentPlayer = MainForm.PlayerList(cboPlayers.SelectedIndex) 'get the selected player
        ShowDetails(_currentPlayer) 'show their details
    End Sub

    'sub procedure called to show a player's details on the UI
    'Parameters: currentPlayer - the player who'se details will be added to the UI
    Private Sub ShowDetails(currentPlayer As Player)

        txtForename.Text = currentPlayer.Forename 'update each label with its respective field
        txtSurname.Text = currentPlayer.Surname
        txtMatches.Text = currentPlayer.Matches
        txtBatInns.Text = currentPlayer.BatInnings
        txtNotOut.Text = currentPlayer.NotOut
        txtRunsScored.Text = currentPlayer.RunsScored
        txtBallsFaced.Text = currentPlayer.BallsFaced
        txtBowledInns.Text = currentPlayer.BowlInnings
        txtBallsBowled.Text = currentPlayer.BallsBowled
        txtConcededRuns.Text = currentPlayer.RunsConceded
        txtWickets.Text = currentPlayer.Wickets

    End Sub

    'sub procedure called when the user wishes to close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    'sub called when the player is requested to be updated
    'gets and validates the new input details and saves the player to the player's file
    Private Sub btnUpdatePlayer_Click(sender As Object, e As EventArgs) Handles btnUpdatePlayer.Click
        GetName()
        GatherDetails() 'get all the details of the player that have been input

        If (CheckAllFields()) Then
            If ((MsgBox("Update player with these details:" & vbCrLf &
                           "Forename: " & _currentPlayer.Forename & vbCrLf &
                           "Surname: " & _currentPlayer.Surname & vbCrLf &
                           "Matches: " & _currentPlayer.Matches & vbCrLf &
                           "Runs Scored: " & _currentPlayer.RunsScored & vbCrLf &
                           "Balls Faced: " & _currentPlayer.BallsFaced & vbCrLf &
                           "Bowled Inns: " & _currentPlayer.BowlInnings & vbCrLf &
                           "Conceded Runs :" & _currentPlayer.RunsConceded & vbCrLf &
                            "Wickets: " & _currentPlayer.Wickets,
                            MsgBoxStyle.YesNo) = MsgBoxResult.Yes)) Then 'ask user to confirm the update of the player
                Try
                    Dim fStream As New FileStream("players.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite) 'New filestream object to write to players file
                    Dim bFormatter As New BinaryFormatter() 'initialise a new BinaryFormatter object to serialize the PlayerList
                    bFormatter.Serialize(fStream, MainForm.PlayerList) 'serialize the player list and write to players file
                    fStream.Flush() 'clear the buffer to the players file
                    fStream.Close() 'close the players file

                    MsgBox("Player Updated")
                    cboPlayers.Items.Clear() 'clear the list of players

                    For Each player As Player In MainForm.PlayerList 'update the list of players
                        cboPlayers.Items.Add(player.Forename & "  " & player.Surname) 'add the current name to the list of players
                    Next
                    cboPlayers.Text = "Player List" 'add the temporary title again
                    ClearBoxes() 'clear all the inputs
                Catch ex As IOException

                    MsgBox("File IO Error")

                End Try
                _currentPlayer = New Player() 're-initialize the player to reset its properties
            Else

                'deleteplayer
                _currentPlayer = New Player() 're-initialize the player to reset its properties
            End If
        End If
    End Sub
    'sub procedure called when the form is closed - resets the necessary UI objects.
    Private Sub EditPlayers_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        cboPlayers.Items.Clear()

    End Sub

    'sub procedure used to get and validate the input forename and surname
    Private Sub GetName()

        If (Validation.CheckName(txtForename.Text) Or Not txtForename.Text.Equals("")) Then 'validate the forname 
            _currentPlayer.Forename = txtForename.Text 'if valid then assign the value in the forname text box as the player forname
            _allValid(Valid.Forename) = True 'flag forename as being valid
        Else
            MsgBox("Enter Forename", MsgBoxStyle.Exclamation) 'if invalid then output that it was invalid 
            _allValid(Valid.Forename) = False 'flag forname as being invalid
        End If

        If (Validation.CheckName(txtSurname.Text) Or Not txtSurname.Text.Equals("")) Then 'validate the surname
            _currentPlayer.Surname = txtSurname.Text 'if valid then assign the value in the surname text box as the player forename
            _allValid(Valid.Surname) = True 'flag surname as valid
        Else
            MsgBox("Enter Surname", MsgBoxStyle.Exclamation) 'if invalid then output that it was invalid 
            _allValid(Valid.Surname) = False 'flag surname as invalid
        End If
    End Sub

    'function called when every field must be validated
    'Returns: True if ALL fields are valid, otherwise returns false
    Private Function CheckAllFields() As Boolean
        For i = 0 To 10 'for each field
            If (_allValid(i) = False) Then 'if the current field is false

                Return False 'break the loop and flag that something was invalid

            End If
        Next
        Return True 'otherwise return true - all fields are valid
    End Function

   'Top level sub procedure to get and validate the inputs
    Private Sub GatherDetails()

        GatherMatches() 'get and validate all the inputs
        GatherBatInnings()
        GatherNotOuts()
        GatherRunsScored()
        GatherBallsFaced()
        GatherConcededRuns()
        GatherWickets()
        GatherBowlInnings()
        GatherBallsBowled()

    End Sub

    'function to get and check an input value
    'Parameters: value As String
    'Returns: an integer representing the validity of the data, or the data itself
    Private Function Gather(value As String) As Integer

        If (value.Equals("")) Then 'if nothing has been entered

            Return 0 'return nothing

        Else

            If (Validation.CheckInt(value) = True) Then 'if the value entered is valid

                Return value 'return the value entered

            Else
                Return -1 'if invalid then return -1 - not valid data
            End If
        End If
    End Function

    'sub procedure to get and validate the input bat innings
    Private Sub GatherBatInnings()
        Dim inns As Integer = Gather(txtBatInns.Text) 'get the bat inns
        If (inns = -1) Then 'if invalid
            MsgBox("Invalid Number of Innings") 'output that the input was invalid
            _allValid(Valid.BatInns) = False 'flag this field as being invalid
        Else
            _allValid(Valid.BatInns) = True 'if the field was valid, flag as valid
            _currentPlayer.BatInnings = Gather(txtBatInns.Text) 'assign the input variable to the player object being input into program
        End If
    End Sub

    'sub procedure to get and validate the input number of matches
    Private Sub GatherMatches()
        Dim mats As Integer = Gather(txtMatches.Text) 'get the number of matches
        If (mats = -1) Then 'if invalid
            MsgBox("Invalid Number of Matches") 'output that the input was invalid
            _allValid(Valid.Matches) = False 'flag this field as being invalid
        Else
            _currentPlayer.Matches = Gather(txtMatches.Text) 'if the field was valid, flag as valid
            _allValid(Valid.Matches) = True 'assign the input variable to the player object being input into program
        End If
    End Sub
    'sub procedure to get and validate the input number of not outs
    Private Sub GatherNotOuts()
        Dim notOut As Integer = Gather(txtNotOut.Text) 'get the number of not outs
        If (notOut = -1) Then 'if invalid
            MsgBox("Invalid Number of Not Outs") 'output that the input was invalid
            _allValid(Valid.NotOut) = False 'flag this field as being invalid
        Else
            _currentPlayer.NotOut = Gather(txtNotOut.Text) 'if the field was valid, flag as valid
            _allValid(Valid.NotOut) = True 'assign the input variable to the player object being input into program
        End If
    End Sub
    'sub procedure to get and validate the input number of runs scored
    Private Sub GatherRunsScored()
        Dim runsScored As Integer = Gather(txtRunsScored.Text) 'get the number of runs scored
        If (runsScored = -1) Then 'if invalid
            MsgBox("Invalid Number of Runs Scored")  'output that the input was invalid
            _allValid(Valid.RunsScored) = False 'flag this field as being invalid
        Else
            _currentPlayer.RunsScored = Gather(txtRunsScored.Text) 'if the field was valid, flag as valid
            _allValid(Valid.RunsScored) = True 'assign the input variable to the player object being input into program

        End If
    End Sub
    'sub procedure to get and validate the input number of balls faced
    Private Sub GatherBallsFaced()
        Dim bf As Integer = Gather(txtBallsFaced.Text) 'get the number of balls faced
        If (bf = -1) Then 'if invalid
            MsgBox("Invalid Number of Balls Faced")  'output that the input was invalid
            _allValid(Valid.BallsFaced) = False 'flag this field as being invalid
        Else
            _currentPlayer.BallsFaced = Gather(txtBallsFaced.Text) 'if the field was valid, flag as valid
            _allValid(Valid.BallsFaced) = True 'assign the input variable to the player object being input into program
        End If

    End Sub
    'sub procedure to get and validate the input number of conceded runs
    Private Sub GatherConcededRuns()
        Dim concRuns As Integer = Gather(txtConcededRuns.Text) 'get the number of runs conceded
        If (concRuns = -1) Then 'if invalid
            MsgBox("Invalid Number of Conceded Runs")  'output that the input was invalid
            _allValid(Valid.ConcededRuns) = False 'flag this field as being invalid
        Else
            _currentPlayer.RunsConceded = Gather(txtConcededRuns.Text) 'if the field was valid, flag as valid
            _allValid(Valid.ConcededRuns) = True 'assign the input variable to the player object being input into program
        End If

    End Sub
    'sub procedure to get and validate the input number of wickets
    Private Sub GatherWickets()
        Dim wickets As Integer = Gather(txtWickets.Text) 'get the number of Wickets
        If (wickets = -1) Then 'if invalid
            MsgBox("Invalid Number of Wickets")  'output that the input was invalid
            _allValid(Valid.Wickets) = False 'flag this field as being invalid
        Else
            _currentPlayer.Wickets = Gather(txtWickets.Text) 'if the field was valid, flag as valid
            _allValid(Valid.Wickets) = True 'assign the input variable to the player object being input into program
        End If

    End Sub
    'sub procedure to get and validate the input number of bowled innings
    Private Sub GatherBowlInnings()
        Dim bowlInns As Integer = Gather(txtBowledInns.Text) 'get the number of innings bowled
        If (bowlInns = -1) Then 'if invalid
            MsgBox("Invalid Number of Innings Bowled")  'output that the input was invalid
            _allValid(Valid.BowledInns) = False 'flag this field as being invalid
        Else
            _currentPlayer.BowlInnings = Gather(txtBowledInns.Text) 'if the field was valid, flag as valid
            _allValid(Valid.BowledInns) = True 'assign the input variable to the player object being input into program
        End If
    End Sub
    'sub procedure to get and validate the input number of balls bowled
    Private Sub GatherBallsBowled()
        Dim ballsBowled As Integer = Gather(txtBallsBowled.Text) 'get the number of innings bowled
        If (ballsBowled = -1) Then 'if invalid
            MsgBox("Invalid Number of Balls Bowled")  'output that the input was invalid
            _allValid(Valid.BallsBowled) = False 'flag this field as being invalid
        Else
            _currentPlayer.BallsBowled = Gather(txtBallsBowled.Text) 'if the field was valid, flag as valid
            _allValid(Valid.BallsBowled) = True 'assign the input variable to the player object being input into program
        End If
    End Sub

    'sub procedure called to clear all the input controls.
    Private Sub ClearBoxes()
        txtForename.Clear() 'clear forname box
        txtSurname.Clear()  'etc..
        txtMatches.Clear()
        txtNotOut.Clear()
        txtRunsScored.Clear()
        txtBallsFaced.Clear()
        txtBatInns.Clear()
        txtConcededRuns.Clear()
        txtBowledInns.Clear()
        txtWickets.Clear()
        txtForename.Focus()
        txtBallsBowled.Clear()
    End Sub

    'sub procedure called when the edit players form is closed
    Private Sub AddCricketers_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed

        ClearBoxes()
        cboPlayers.Items.Clear() 'clear the player's list

    End Sub

    Private Sub _btnPrint_Click(sender As Object, e As EventArgs) Handles _btnPrint.Click
        PrintDoc.Print()
    End Sub

    'sub procedure called when the player selected is requested to be printed
    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim font As New Font("Courier New", 20, FontStyle.Regular) 'declare a font for the ticket details added onto the ticket background to be written in
        Dim selection As Integer = cboPlayers.SelectedIndex
        Dim point1, point2 As System.Drawing.Point 'local variables to store the coordinates of two points temporarily
        'the two points represent the start and end of a line

        If (selection >= 0) Then 'if a selection has been made

            Dim p As Player = MainForm.PlayerList(selection) 'player to be printed
            e.Graphics.DrawString("Saddleworth Cricket Club", font, Brushes.Black, 150, 75)
            e.Graphics.DrawString(Today, font, Brushes.Black, 500, 150)
            e.Graphics.DrawString("Name:", font, Brushes.Gray, 100, 150)
            e.Graphics.DrawString(p.Forename & " " & p.Surname, font, Brushes.Black, 250, 150) 'add player name
            e.Graphics.DrawString("Games Played:", font, Brushes.Gray, 125, 225) 'add the number of games played
            e.Graphics.DrawString(p.Matches, font, Brushes.Black, 400, 225)
            e.Graphics.DrawString("Innings Batted:", font, Brushes.Gray, 125, 300) 'add the number of innings batted
            e.Graphics.DrawString(p.BatInnings, font, Brushes.Black, 400, 300)
            e.Graphics.DrawString("Not Outs:", font, Brushes.Gray, 125, 375) 'etc...
            e.Graphics.DrawString(p.NotOut, font, Brushes.Black, 400, 375)
            e.Graphics.DrawString("Runs Scored:", font, Brushes.Gray, 125, 450)
            e.Graphics.DrawString(p.RunsScored, font, Brushes.Black, 400, 450)
            e.Graphics.DrawString("Balls Faced:", font, Brushes.Gray, 125, 525)
            e.Graphics.DrawString(p.BallsFaced, font, Brushes.Black, 400, 525)
            e.Graphics.DrawString("Batting Average:", font, Brushes.Gray, 125, 600)
            e.Graphics.DrawString(PickTeam.BattingAverage(p), font, Brushes.Black, 400, 600)
            e.Graphics.DrawString("Strike Rate:", font, Brushes.Gray, 125, 675)
            e.Graphics.DrawString(StrikeRate(p), font, Brushes.Black, 400, 675)
            e.Graphics.DrawString("Innings Bowled:", font, Brushes.Gray, 125, 750)
            e.Graphics.DrawString(p.BowlInnings, font, Brushes.Black, 400, 750)
            e.Graphics.DrawString("Runs Conceded:", font, Brushes.Gray, 125, 825)
            e.Graphics.DrawString(p.RunsConceded, font, Brushes.Black, 400, 825)
            e.Graphics.DrawString("Balls Bowled:", font, Brushes.Gray, 125, 900)
            e.Graphics.DrawString(p.BallsBowled, font, Brushes.Black, 400, 900)
            e.Graphics.DrawString("Wickets:", font, Brushes.Gray, 125, 975)
            e.Graphics.DrawString(p.Wickets, font, Brushes.Black, 400, 975)
            e.Graphics.DrawString("Bowling Average:", font, Brushes.Gray, 125, 1050)
            e.Graphics.DrawString(PickTeam.BowlingAverage(p), font, Brushes.Black, 400, 1050)

            For i = 0 To 12 'add horizontal lines between each field
                point1.X = 50
                point1.Y = 150 + (i * 75) + 2 * font.Height
                point2.X = 725
                point2.Y = 150 + (i * 75) + 2 * font.Height
                e.Graphics.DrawLine(Pens.Black, point1, point2)

            Next

            'underline the title
            point1.X = 145
            point1.Y = 75 + font.Height + 5
            point2.X = 575
            point2.Y = 75 + font.Height + 5
            e.Graphics.DrawLine(Pens.Black, point1, point2)
        End If
    End Sub

    'function called to calculate the strike rate of a player
    'Parameters: p - the player to calculate the strike rate of
    'Returns: the strike rate of the passed player
    Private Function StrikeRate(p As Player)
        Return (p.RunsScored / p.BallsFaced) * 100
    End Function
End Class

