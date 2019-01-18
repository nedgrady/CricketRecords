Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

'Form where the user can add cricketers into the system
Public Class AddCricketers

    Private _currentPlayer As New Player() 'Global variable to teporarily store the new player
    

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

    'sub called when the new player is requested to be added
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        GetName()
        GatherDetails() 'get all the details of the player that have been input

        If (CheckAllFields()) Then 'if all fields are valid
            If ((MsgBox("Submit A new player with these details:" & vbCrLf &
                           "Forename: " & _currentPlayer.Forename & vbCrLf &
                           "Surname: " & _currentPlayer.Surname & vbCrLf &
                           "Matches: " & _currentPlayer.Matches & vbCrLf &
                           "Runs Scored: " & _currentPlayer.RunsScored & vbCrLf &
                           "Balls Faced: " & _currentPlayer.BallsFaced & vbCrLf &
                           "Bowled Inns: " & _currentPlayer.BowlInnings & vbCrLf &
                           "Conceded Runs :" & _currentPlayer.RunsConceded & vbCrLf &
                            "Wickets: " & _currentPlayer.Wickets,
                            MsgBoxStyle.YesNo) = MsgBoxResult.Yes)) Then 'ask user to confirm the addition of the player
                Try
                    Dim fStream As New FileStream("players.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite) 'New filestream object to write to players file
                    Dim bFormatter As New BinaryFormatter() 'initialise a new BinaryFormatter object to serialize the PlayerList
                    _currentPlayer.PlayerID = MainForm.PlayerList.ToArray.Length 'add a player ID to the ID field
                    MainForm.PlayerList.Add(_currentPlayer) 'add the player to the player list
                    bFormatter.Serialize(fStream, MainForm.PlayerList) 'serialize the player list and write to players file
                    fStream.Flush() 'clear the buffer to the players file
                    fStream.Close() 'close the players file

                    ClearBoxes()                    'clear all the inputs
                    lstAddedPlayers.Items.Clear()
                    MsgBox("Player Saved") 'output player was save successfully
                    For Each player As Player In MainForm.PlayerList 'for each player
                        lstAddedPlayers.Items.Add(player.Forename & "  " & player.Surname) 'add each name to list box
                    Next

                Catch ex As System.IO.IOException 'if an error occured

                    MsgBox("File IO Error") 'output error occured

                End Try
                _currentPlayer = New Player() 'clear the current player
                Close() 'close form
            Else

                'deleteplayer
                _currentPlayer = New Player()
            End If
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

    'sub procedure called when the form is closed - resets the necessary UI objects.
    Private Sub AddCricketers_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed

        lstAddedPlayers.Items.Clear() 'clear the list of added players

    End Sub

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

    'sub procedure called when cancel button is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    'sub procedure calle when the button to clear the controls is clicked
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearBoxes()
    End Sub
    'Sub procedure called when the form is loaded
    Private Sub AddCricketers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each player As Player In MainForm.PlayerList 'for every player
            lstAddedPlayers.Items.Add(player.Forename & "  " & player.Surname) 'add the player name to the list box of players who are in the system
        Next
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


    
End Class

