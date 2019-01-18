'class is used as a more specific placeholder for the user interface objects associated with updating a batsman's figures (runs scored,balls faced, whether they were out or not)
'when the user is adding a game.

Public Class BatInputLine
    Inherits InputLine

    Public Const MaxRuns = 55 'constant store the maximum number of runs
    Public Const MaxBalls = 75 'constant to store the maximum number of balls faced

    Public Property Runs As Integer 'public property used to get and set the runs value
    Public Property BallsFaced As Integer 'public property used to get and set the Balls Faced value
    Public Property NotOut As Boolean 'public property used to get and set the Not Out value

    Private WithEvents _txtRuns As New TextBox() 'text box to input the number of runs scored
    Private WithEvents _txtBallsFaced As New TextBox() 'text box to input the number of balls faced
    Private WithEvents _chkNotOut As New CheckBox() 'check box to input if the batsman was dissmissed

    'Constructor
    'Parameters: The player that this line will act as an input for
    Public Sub New(player As Player)

        MyBase.New(player) 'call this class' superclass' constructor
        Initialise()

    End Sub


    'sub procedure called to get the instance of this object ready to be displayed on screen
    'adds all of the required controls to the UI and sets their positions
    Private Sub Initialise()

        _name.SetBounds(0, 0, 150, 15) 'set the position of the player's name
        _txtRuns.SetBounds(_name.Right + 10, 0, 40, 25) 'sets the position of the runs text box
        _txtBallsFaced.SetBounds(_txtRuns.Right + 10, 0, 40, 25) 'set position of the balls faced text box
        _chkNotOut.SetBounds(_txtBallsFaced.Right + 10, 3, 16, 16) 'set the position of the check box reperesenting out or not
        _remove.SetBounds(_chkNotOut.Right + 10, 0, 55, 25) 'set the position of the remove button
        Controls.Add(_txtBallsFaced) 'add all of the objects to the UI
        Controls.Add(_txtRuns)
        Controls.Add(_chkNotOut)
        Controls.Add(_remove)

    End Sub

    'sub procedure called to get and validate the value input by the user for this object
    Public Sub GatherProperties()

        GatherRunsScored() 'get and validate runs
        GatherBallsFaced() 'get and validate balls faced
        GatherNotOut()  'get and validate whether or not batsmen was out

    End Sub

    'sub procedure called to get and validate the number of runs scored input
    Private Sub GatherRunsScored()

        Dim runsScored As String = _txtRuns.Text 'local variable to store the input number of runs scored

        If (Validation.CheckInt(runsScored)) Then 'check that the input num of runs is an integer

            If (Validation.RangeCheck(runsScored, 0, MaxRuns) = False) Then 'range check the input runs


                If (MsgBox("The input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s runs scored is greater than 55" & vbCrLf &
                       "This will not cause an error but may have been input wrongly", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then 'if the range check fails, inform the user and ask them to confirm that the input number is correct
                    'if the range check fails, the user can still choose to continue because sometimes games can have more than 55 runs in them, however this is not USUALLY the case
                    ReadyToSave = False 'flag object as being not ready to save
                End If
            End If

            Runs = runsScored 'if a runs wickets value has been entered, set it to the property for later use

        Else
            ReadyToSave = False 'if the input is not an integer flag the object as not being ready to save
            MsgBox("Invalid Input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s runs scored") 'inform user 
        End If
    End Sub

    'sub procedure called to get and validate the number of balls faced input
    Private Sub GatherBallsFaced()

        Dim facedBalls As String = __txtBallsFaced.Text  'local variable to store the input number of balls faced

        If (Validation.CheckInt(facedBalls)) Then 'range check the input wickets

            If (Validation.RangeCheck(facedBalls, 0, MaxBalls) = False) Then

                If (MsgBox("The input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s balls faced is greater than 75" & vbCrLf &
                       "This will not cause an error but may have been input wrongly", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then 'if the range check fails, inform the user and ask them to confirm that the input number is correct
                    'if the range check fails, the user can still choose to continue because sometimes games can have more than 75 balls faced in them, however this is not USUALLY the case
                    ReadyToSave = False 'flag object as being not ready to save
                End If
            End If

            BallsFaced = facedBalls 'if a valid balls faced value has been entered, set it to the property for later use
        Else
            ReadyToSave = False 'if the input is not an integer flag the object as not being ready to save
            MsgBox("Invalid Input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s balls faced") 'inform user 

        End If
    End Sub

    'sub procedure called to get whether or not the batsman was dismissed
    Private Sub GatherNotOut()

        NotOut = _chkNotOut.CheckState 'if the check box is checked - this means the player was out

    End Sub


End Class
