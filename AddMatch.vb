Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
'form to input details of any matches that have been carried out.
Public Class AddMatch

    Private _numberOfBatsmen As Integer 'global variable to store the number of batsmen
    Private Const LeftIndent = 50 'constant to store x coordinate of where the batsmen appear on the UI
    Private Const LargeLeftIndent = 675 'constant to store x coordinate where the bowlers appear on the UI
    Private Const VertIndent = 75 'constant to store the first y-coordinate where the first player will appear 
    Private Const GapBetweenLines = 10 'constant to store the gap between each player on the UI 

    Private _batInputs As New List(Of BatInputLine) 'global list of BatInputLine User Interface objects, to store all of the batsmen who appeared in the game
    Private _bowlInputs As New List(Of BowlInputLine) 'global list of BowlInputLine User Interface objects, to store all of the bowlers who appeared in the game

    'sub procedure called when the add match form loads
    Private Sub AddMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _btnUpdateBatsmen.Visible = False 'hide the update buttons
        _btnUpdateBowlers.Visible = False
        AddNames() 'add the names of all the batsmen/bowlers to each list box.
    End Sub

    'sub procedure called when a batsman is selected
    'adds an empty input line to the next line on the user interface so the user can input the batsman's statistics for the game 
    Private Sub _lstBatsmen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _lstBatsmen.SelectedIndexChanged
        Dim lst As ListBox = sender
        If (CheckExisitngBatLines(lst.SelectedIndex)) Then 'if this player has not already been selected

            Dim thisLine As New BatInputLine(MainForm.PlayerList(lst.SelectedIndex)) 'initialse a new bat input line user interface object
            Dim uiNum As Integer = _batInputs.ToArray.Length 'calculate the next availiable space on the user interface
            thisLine.Tag = uiNum 'save the line number that the new line will take in the user interface
            thisLine.SetBounds(LeftIndent, VertIndent + uiNum * BatInputLine.DefaultHeight + GapBetweenLines * uiNum, BatInputLine.DefaultWidth, BatInputLine.DefaultHeight) 'add the line to the next availabe line on the UI
            _btnUpdateBatsmen.SetBounds(LeftIndent, VertIndent + uiNum * BatInputLine.DefaultHeight + GapBetweenLines * uiNum + 25, 100, 25) 'move the update button one row down
            _btnUpdateBatsmen.Visible = True 'show the new line
            AddHandler thisLine.RemoveButtonClicked, AddressOf HandleRemoveBatClicked 'assign the event of the line's remove button to the remove procedure

            Controls.Add(thisLine) 'add the line to the list of user interface controls
            _batInputs.Add(thisLine) 'add the line to the list of batsmen
        End If
    End Sub

    'sub procedure called when a bowler is selected
    'adds an empty input line to the next available line on the user interface so the user can input the bowler's statistics for the game
    Private Sub _lstBowlers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles _lstBowlers.SelectedIndexChanged
        Dim lst As ListBox = sender
        If (CheckExisitngBowlLines(lst.SelectedIndex)) Then 'if the player has not already been selected
            Dim thisLine As New BowlInputLine(MainForm.PlayerList(lst.SelectedIndex)) 'initialse a new BowlInputLine user interface object
            Dim uiNum As Integer = _bowlInputs.ToArray.Length 'calculate the next availiable space on the user interface
            thisLine.Tag = uiNum 'save the line number that the new line will take in the user interface
            thisLine.SetBounds(LargeLeftIndent, VertIndent + uiNum * BowlInputLine.DefaultHeight + GapBetweenLines * uiNum, BatInputLine.DefaultWidth, BatInputLine.DefaultHeight) 'add the line to the next availabe line on the UI
            _btnUpdateBowlers.SetBounds(LargeLeftIndent, VertIndent + uiNum * BowlInputLine.DefaultHeight + GapBetweenLines * uiNum + 25, 100, 25) 'move the update button one row down
            _btnUpdateBowlers.Visible = True 'show the new line
            AddHandler thisLine.RemoveButtonClicked, AddressOf HandleRemoveBowlClicked 'assign the event of the line's remove button to the remove procedure

            Controls.Add(thisLine) 'add the line to the list of user interface controls
            _bowlInputs.Add(thisLine) 'add the line to the list of bowlers

        End If

    End Sub

    'sub procedure called when a bowler's remove button is clicked
    'removes the line that was clicked, and updates all other lines accordingly
    'Parameters: sender - the line that the event was generated from (the line who's "remove" button was clicked)
    '            e - as no extra information is needed to handle this event, other than the object that generated the event, this is always passed as EventArgs.Empty
    '                when the event is generated from the BowlInputLine class.
    Private Sub HandleRemoveBowlClicked(sender As Object, e As EventArgs)
        Dim line As InputLine = sender 'local variable to store the line that generated the remove event
        Dim removedIdx = line.Tag 'local variable to store the line number the remove event was generated from
        _bowlInputs.RemoveAt(removedIdx) 'remove the line from the list of the current active lines on the user interface
        Controls.Remove(line) 'remove the line from the list of UI controls

        For i = removedIdx To _bowlInputs.ToArray.Length - 1 'for each line after the line that was removed
            _bowlInputs(i).Tag -= 1 'decrement its current line reference
            _bowlInputs(i).SetBounds(LargeLeftIndent, VertIndent + i * GapBetweenLines + i * InputLine.DefaultHeight, InputLine.DefaultWidth, InputLine.DefaultHeight) 'move the line one line up
            Controls.Add(_bowlInputs(i)) 'add the current line to the UI
        Next

        _btnUpdateBowlers.SetBounds(LargeLeftIndent, _bowlInputs.ToArray.Length * GapBetweenLines + _bowlInputs.ToArray.Length * InputLine.DefaultHeight + VertIndent, 100, 25) 'move the remove button up
        Controls.Add(_btnUpdateBowlers) 'add the update button to the UI

        If (_bowlInputs.ToArray.Length = 0) Then 'if there are no more bowlers
            _btnUpdateBowlers.Visible = False 'remove the update button
        End If
    End Sub

    'sub procedure called when a batsman's remove button is clicked
    'removes the line that was clicked, and updates all other lines accordingly
    'Parameters: sender - the line that the event was generated from (the line who's "remove" button was clicked)
    '            e - as no extra information is needed to handle this event, other than the object that generated the event, this is always passed as EventArgs.Empty
    '                when the event is generated from the BatInputLine class.
    Private Sub HandleRemoveBatClicked(sender As Object, e As EventArgs)
        Dim line As InputLine = sender 'local variable to store the line that generated the remove event
        Dim removedIdx = line.Tag 'local variable to store the line number the remove event was generated from
        _batInputs.RemoveAt(line.Tag) 'remove the line from the list of the current active lines on the user interface
        Controls.Remove(line) 'remove the line from the list of UI controls

        For i = removedIdx To _batInputs.ToArray.Length - 1 'for each line after the line that was removed
            _batInputs(i).Tag -= 1 'decrement its current line reference
            _batInputs(i).SetBounds(LeftIndent, VertIndent + i * GapBetweenLines + i * BatInputLine.DefaultHeight, BatInputLine.DefaultWidth, BatInputLine.DefaultHeight) 'move the line one line up
            Controls.Add(_batInputs(i)) 'add the current line to the UI
        Next

        _btnUpdateBatsmen.SetBounds(LeftIndent, _batInputs.ToArray.Length * GapBetweenLines + _batInputs.ToArray.Length * BatInputLine.DefaultHeight + VertIndent, 100, 25) 'move the remove button up
        Controls.Add(_btnUpdateBatsmen) 'add the update button to the UI

        If (_batInputs.ToArray.Length = 0) Then 'if there are no more batsmen
            _btnUpdateBatsmen.Visible = False 'hide the update button
        End If
    End Sub

    'sub procedure called to add the names of all of the bowlers and batsmen to their respective list box
    'this sub procedure should always be called when the form loads otherwise the user will not be able to select any players
    Private Sub AddNames()
        For Each player As Player In MainForm.PlayerList 'for each player
            _lstBatsmen.Items.Add(player.Forename & "  " & player.Surname) 'add their name to the batsman list
            _lstBowlers.Items.Add(player.Forename & "   " & player.Surname) 'add their name to the bowlers list
        Next
    End Sub

    'funtion used to check if a selected player already appears in the list of batsmen
    'Parameters: index - intended to be the Selected Index in the batsman's list box. This will be the same as the player's PlayerID, as they are added in PlayerID order.
    Private Function CheckExisitngBatLines(index As Integer) As Boolean

        For i = 0 To _batInputs.ToArray.Length - 1 'for each added player
            If (_batInputs(i).ActivePlayer.PlayerID = index) Then 'if this player is the same as the selected player
                Return False 'break the loop and return false - the selection is invalid
            End If
        Next
        Return True 'if the player wasn't found return true
    End Function

    'funtion used to check if a selected player already appears in the list of bowlers
    'Parameters: index - intended to be the Selected Index in the bowler's list box. This will be the same as the player's PlayerID, as they are added in PlayerID order.
    Private Function CheckExisitngBowlLines(index As Integer) As Boolean

        For i = 0 To _bowlInputs.ToArray.Length - 1 'for each added player
            If (_bowlInputs(i).ActivePlayer.PlayerID = index) Then 'if this player is the same as the selected player
                Return False 'break the loop and return false - the selection is invalid
            End If
        Next
        Return True 'if the player wasn't found return true
    End Function

    'sub procedure called when the update batsmen button is clicked
    'get all the values input for each batsman, validates them then saves to the players file
    Private Sub btnUpdateBatsmen_Click(sender As Object, e As EventArgs) Handles _btnUpdateBatsmen.Click

        Dim save As Boolean = True 'local variable to store whether or not the inputs are ok for saving

        For i = 0 To _batInputs.ToArray.Length - 1 'for each batsman

            _batInputs(i).GatherProperties() 'get and validate the input figures (Runs scored, Balls Faced, Whether or not they were out)
            If (_batInputs(i).ReadyToSave = False) Then 'if the batsman isn't ready to be saved
                save = False 'flag it as not ready to save
            End If
        Next

        If (save) Then 'if ALL batsmen are ready to be saved
            For i = 0 To _batInputs.ToArray.Length - 1 'for each batsman

                MainForm.PlayerList(_batInputs(i).ActivePlayer.PlayerID).RunsScored += _batInputs(i).Runs 'get the input runs scored, balls faced and update these fields
                MainForm.PlayerList(_batInputs(i).ActivePlayer.PlayerID).BallsFaced += _batInputs(i).BallsFaced
                MainForm.PlayerList(_batInputs(i).ActivePlayer.PlayerID).Matches += 1 'increment the player's matches count
                MainForm.PlayerList(_batInputs(i).ActivePlayer.PlayerID).BatInnings += 1 'increment the player's innings batted count

                If (_batInputs(i).NotOut) Then 'if the current batsman was not dismissed
                    MainForm.PlayerList(_batInputs(i).ActivePlayer.PlayerID).NotOut += 1 'add one to the not out count
                End If
            Next
            SavePlayers() 'SavePlayers called only if all batsman can be saved
        End If

    End Sub

    'sub procedure called when the update bowlers button is clicked
    'get all the values input for each bowler, validates them then saves to the players file
    Private Sub _btnUpdateBowlers_Click(sender As System.Object, e As System.EventArgs) Handles _btnUpdateBowlers.Click
        Dim save As Boolean = True 'local variable to store whether or not the inputs are ok for saving
        For i = 0 To _bowlInputs.ToArray.Length - 1 'for each bowler
            _bowlInputs(i).GatherProperties() 'get and validate the input figures (overs bowled, runs conceded, wickets taken)
            If (_bowlInputs(i).ReadyToSave = False) Then 'if the bowler isn't ready to be saved
                save = False 'flag it as not ready to save
            End If
        Next

        If (save) Then 'if ALL bowlers are ready to be saved
            For i = 0 To _bowlInputs.ToArray.Length - 1 'for each bowler
                MainForm.PlayerList(_bowlInputs(i).ActivePlayer.PlayerID).BallsBowled += _bowlInputs(i).Overs * 6 'calculate the number of balls bowled (overs * 6) and update this field
                MainForm.PlayerList(_bowlInputs(i).ActivePlayer.PlayerID).Matches += 1 'increment the player's matches count
                MainForm.PlayerList(_bowlInputs(i).ActivePlayer.PlayerID).BowlInnings += 1 'increment the player's innings bowled count
                MainForm.PlayerList(_bowlInputs(i).ActivePlayer.PlayerID).Wickets += _bowlInputs(i).Wickets 'update wickets count
                MainForm.PlayerList(_bowlInputs(i).ActivePlayer.PlayerID).RunsConceded += _bowlInputs(i).ConcededRuns 'update conceded runs count
            Next
            SavePlayers() 'SavePlayers called only if all bowlers can be saved
        End If
    End Sub

    'sub procedure called any time the list of players needs to be re-written to the player's file
    'sub procedure serializes the list of players and writes to players.txt
    Private Sub SavePlayers()
        Dim fStream As New FileStream("players.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite) 'initialise a new file stream object to write to players file
        Dim bFormatter As New BinaryFormatter() 'initialise a new BinaryFormatter object to carry out the serialization on the PlayerList
        bFormatter.Serialize(fStream, MainForm.PlayerList) 'serialize the player list
        fStream.Flush() 'close and flush the file stream
        fStream.Close()
    End Sub

    'sub procedure called when the add match form is closed
    'clears the list of added players and any players who have been added to the user interface
    Private Sub form_closed() Handles Me.FormClosed
        _lstBatsmen.Items.Clear() 'clear the player's list boxes
        _lstBowlers.Items.Clear()
        For i = 0 To _bowlInputs.ToArray.Length 'for each added bowler
            Controls.Remove(_bowlInputs(i)) 'remove the bowler from the UI
        Next
        For i = 0 To _batInputs.ToArray.Length 'for each added batsman
            Controls.Remove(_batInputs(i)) 'remove the batsman from the UI
        Next
        _bowlInputs.Clear() 'clear the lists of players
        _batInputs.Clear()
    End Sub
End Class