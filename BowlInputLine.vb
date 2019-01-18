'class is used as a more specific placeholder for the user interface objects associated with updating a bowler's figures (runs conceded, overs bowled, wickets taken)
'when the user is adding a game.
Public Class BowlInputLine
    Inherits InputLine 'subclass of InputLine that deals with adding the name of the player
    Public Const MaxWickets As Integer = 10 'constant to store the maximum possible number of wickets
    Public Const MaxOvers = 4 'constant to store the maxiumum number of overs that can be bowled
    Public Const MaxConcededRuns = MaxOvers * 6 * 4 'constant to store the maximum number of conceded runs

    Public Property Overs As Integer 'public property used to get and set the overs value
    Public Property ConcededRuns As Integer 'public property used to get and set the condeded runs value
    Public Property Wickets As Integer 'public property used to get and set the wickets value

    Public WithEvents _txtOvers As New TextBox 'text box to input the overs bowled
    Public WithEvents _txtConcededRuns As New TextBox 'text box to input the runs conceded
    Public WithEvents _txtWickets As New TextBox 'text bow to input the number of wickets

    'Constructor
    'Parameters: The player that this line will act as an input for
    Public Sub New(player As Player)

        MyBase.New(player) 'call this class' superclass' constructor
        Initialise()

    End Sub

    'sub procedure called to get the instance of this object ready to be displayed on screen
    'adds all of the required controls to the UI and sets their positions
    Private Sub Initialise()

        _txtOvers.SetBounds(150, 0, 40, 25) 'set the position of the overs text box
        _txtConcededRuns.SetBounds(_txtOvers.Right + 10, 0, 40, 25) 'set position of conceded runs text box
        _txtWickets.SetBounds(_txtConcededRuns.Right + 10, 0, 40, 25) 'set position of wickets text box
        _remove.SetBounds(_txtWickets.Right + 10, 0, 55, 25) 'set the bounds of the remove button
        Controls.Add(_name) 'add all of the objects to the UI
        Controls.Add(_txtOvers)
        Controls.Add(_txtWickets)
        Controls.Add(_txtConcededRuns)
        Controls.Add(_remove)

    End Sub

    'sub procedure called to get and validate the value input by the user for this object
    Public Sub GatherProperties()

        GatherOvers() 'get and validate overs
        GatherConcededRuns() 'get and validate conceded runs
        GatherWickets() 'get and validate wickets

    End Sub

    'sub procedure called to get and validate the number of conceded runs input
    Private Sub GatherConcededRuns()

        Dim runs As String = _txtConcededRuns.Text() 'local variable to store the number of conceded runs

        If (Validation.CheckInt(runs)) Then 'check that the input num of conceded runs is an integer

            If (Validation.RangeCheck(runs, 0, MaxConcededRuns) = False) Then 'range check the input conceded runs

                If (MsgBox("The input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s runs conceded is greater than" & MaxConcededRuns & vbCrLf &
                       "This will not cause an error but may have been input wrongly", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then 'if the range check fails, inform the user and ask them to confirm that the input number is correct
                    'if the range check fails, the user can still choose to continue because sometimes games can have more than 144 conceded runs in them, however this is not USUALLY the case
                    ReadyToSave = False 'flag object as being not ready to save

                End If
            End If
            ConcededRuns = runs 'if a valid conceded runs value has been entered, set it to the property for later use
        Else
            ReadyToSave = False 'if the input is not an integer flag the object as not being ready to save
            MsgBox("Invalid Input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s Conceded Runs") 'inform user 
        End If
    End Sub

    'sub procedure called to get and validate the number of wickets input
    Private Sub GatherWickets()

        Dim wicketsTaken As String = _txtWickets.Text() 'local variable to store the input number of wickets

        If (Validation.CheckInt(wicketsTaken)) Then 'check that the input num of wickets is an integer

            If (Validation.RangeCheck(wicketsTaken, 0, MaxWickets) = False) Then 'range check the input wickets

                If (MsgBox("The input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s wickets scored is greater than" & MaxWickets & vbCrLf &
                       "This will not cause an error but may have been input wrongly", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then 'if the range check fails, inform the user and ask them to confirm that the input number is correct
                    'if the range check fails, the user can still choose to continue because sometimes games can have more than 10 wickets in them, however this is not USUALLY the case
                    ReadyToSave = False 'flag object as being not ready to save
                End If
            End If

            Wickets = wicketsTaken 'if a valid wickets value has been entered, set it to the property for later use

        Else
            ReadyToSave = False 'if the input is not an integer flag the object as not being ready to save
            MsgBox("Invalid Input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s wickets") 'inform user 

        End If
    End Sub


    'sub procedure called to get and validate the number of overs input
    Private Sub GatherOvers()
        Dim oversBowled As String = _txtOvers.Text() 'local variable to store the input number of overs

        If (Validation.CheckInt(oversBowled)) Then 'range check the input overs

            If (Validation.RangeCheck(oversBowled, 0, MaxOvers) = False) Then 'check that the input num of overs is an integer

                If (MsgBox("The input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s overs is greater than" & MaxOvers & vbCrLf &
                       "This will not cause an error but may have been input wrongly", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then 'if the range check fails, inform the user and ask them to confirm that the input number is correct
                    'if the range check fails, the user can still choose to continue because sometimes games can have more than 4 overs in them, however this is not USUALLY the case
                    ReadyToSave = False 'flag object as being not ready to save

                End If
            End If

            Overs = oversBowled 'if a valid overs value has been entered, set it to the property for later use

        Else
            ReadyToSave = False 'if the input is not an integer flag the object as not being ready to save
            MsgBox("Invalid Input for " & ActivePlayer.Forename & " " & ActivePlayer.Surname & "'s overs") 'inform user 

        End If
    End Sub




End Class
