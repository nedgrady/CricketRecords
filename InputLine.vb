'Class is used as a generic placeholder for multiple user interface objects that always appear together on one line
'Chosen a subclass of panel as it can be moved around and added/removed to and from the user interface easily
Public Class InputLine
    Inherits System.Windows.Forms.Panel

    Public Property ActivePlayer As Player 'Property to store the player that this line is representing
    'Public Property PlayerName As String
    Public Property ReadyToSave As Boolean = True 'Property to store whether or the player is ready to be written to a file

    Public Const DefaultWidth As Integer = 1050 'constant to store the width of the line in pixels
    Public Const DefaultHeight As Integer = 25 'constant to store the height of the line in pixels
    Protected WithEvents _name As New Label() 'label to show the name of the active player
    Protected WithEvents _remove As New Button() 'button to click when user wishes to remove this line

    Public Event RemoveButtonClicked As EventHandler 'event raised when _remove is clicked

    'Constructor
    'Parameters: A player object which becomes the active player
    Sub New(player As Player)

        ActivePlayer = player ''assign the active player
        Initialise()

    End Sub

    'sub procedure called to get the instance of this object ready to be displayed on screen
    'it adds the name of the active player and set the position of the label to store the name
    'also adds text to the remove button
    Private Sub Initialise()

        _name.Text = ActivePlayer.Forename & "  " & ActivePlayer.Surname 'assign the name of the active player
        _remove.Text = "Remove" 'add the text to the button
        _name.SetBounds(0, 0, _name.PreferredWidth, 15) 'set the position and size of the name label
        Controls.Add(_name) 'add the name label to user interface


    End Sub

    'sub procedure called when the remove button is clicked
    'parameters:  
    Private Sub Removed(sender As Object, e As EventArgs) Handles _remove.Click
        RaiseEvent RemoveButtonClicked(Me, e) 'raise the button click event and pass this instance of the input line
    End Sub


End Class
