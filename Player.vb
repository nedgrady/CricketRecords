

<Serializable>
Public Class Player

    Public Property PlayerID As Integer
    Public Property Forename As String
    Public Property Surname As String
    Public Property Matches As Integer
    Public Property BatInnings As Integer
    Public Property NotOut As Integer
    Public Property RunsScored As Integer
    Public Property BallsFaced As Integer
    Public Property BowlInnings As Integer
    Public Property BallsBowled As Integer
    Public Property RunsConceded As Integer
    Public Property Wickets As Integer

    Public Sub New(forename As String, surname As String)

        Me.Forename = forename
        Me.Surname = surname

    End Sub

    Public Sub New()

        Me.New("", "")

    End Sub

    Public Sub Reset()

        PlayerID = 0
        Forename = ""
        Surname = ""
        Matches = 0
        BatInnings = 0


        NotOut = 0
        RunsScored = 0
        BallsFaced = 0
        BowlInnings = 0
        BallsBowled = 0
        RunsConceded = 0
        Wickets = 0

    End Sub

End Class
