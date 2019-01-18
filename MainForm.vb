Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Reflection

Public Class MainForm

    Public Shared userIsAdmin As Boolean = False 'Global variable to store whether or not current user is an admin
    'Private _currentPlayer As New Player() 
    Public Shared PlayerList As New List(Of Player) 'Main list to store all of the players

    'sub called when form loads
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fStream As New FileStream("players.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite) 'initialise a new file stream object to write to players file
        Dim bFormatter As New BinaryFormatter() 'initialise a new BinaryFormatter object to carry out the serialization on the PlayerList
        Try
            PlayerList = bFormatter.Deserialize(fStream) 'Read in and de-serialize everything in players file

        Catch ex As Exception 'if nothing was in file
            MsgBox("This is your first time, welcome") 'welcome the user
        Finally
            fStream.Flush() 'always flush the buffer to players file
            fStream.Close() 'and close the file
        End Try

        If (Not userIsAdmin) Then 'if user isn't admin

            HideButtons() 'disable any buttons that require admin rights

        End If

    End Sub

    'sub called when edit player form is opened
    Private Sub btnEditPlayers_Click(sender As Object, e As EventArgs) Handles _btnEditPlayers.Click, _btnEditPlayers.Click
        EditPlayers.ShowDialog() 'open edit player form
    End Sub

    'sub called when user wishes to add a match
    Private Sub btnAddMatch_Click(sender As Object, e As EventArgs) Handles _btnAddMatch.Click, _btnAddMatch.Click
        AddMatch.ShowDialog() 'open add match form
    End Sub
    'sub called when user wishes to compare players
    Private Sub _btnCompare_Click(sender As Object, e As EventArgs) Handles _btnCompare.Click
        ViewPlayers.ShowDialog() 'open compare players form
    End Sub

    'sub called when new player form button is clicked
    Private Sub btnNewPlayer_Click(sender As Object, e As EventArgs) Handles _btnNewPlayer.Click, _btnNewPlayer.Click
        AddCricketers.ShowDialog() 'open the new player form
    End Sub

    'sub called to hide any buttons requiring admin rights
    Private Sub HideButtons()

        _btnAddLogin.Enabled = False  'hide all the buttons
        _btnEditPlayers.Enabled = False
        _btnAddMatch.Enabled = False
        _btnNewPlayer.Enabled = False

    End Sub
    'sun called when user wishes to pick team
    Private Sub _btnPickTeam_Click(sender As System.Object, e As System.EventArgs) Handles _btnPickTeam.Click
        PickTeam.ShowDialog() 'open pick team form
    End Sub

    Private Sub _btnAddLogin_Click(sender As System.Object, e As System.EventArgs) Handles _btnAddLogin.Click
        AddLogInForm.ShowDialog()
    End Sub
End Class