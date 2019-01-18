'class used to display a player who appears in a picked/generated team on the pick team form
Public Class PickTeamLine
    Inherits InputLine 'subclass of InputLine which handle's the remove button's events

    Public Property BowlAvg As Decimal 'property to get and set the bowling average
    Public Property BatAvg As Decimal 'property to get and set the batting average

    Protected lblBatAvg, lblBowlAvg As New Label 'two new labels to store the batting and bowling average on screen

    'constructor
    Public Sub New(p As Player)
        MyBase.New(p) 'call this class' superclass' constructor
        Init()

    End Sub

    'sub procedure called to get the instance of this object ready to be displayed on screen
    'adds the batting and bowling average label and populates them with the player's calculated batting/bowling average
    'also adds text to the remove button
    Private Sub Init()

        BowlAvg = PickTeam.BowlingAverage(ActivePlayer) 'calculate bowling average
        BatAvg = PickTeam.BattingAverage(ActivePlayer) 'calculate batting average
        lblBatAvg.Text = Math.Round(BatAvg, 2) 'add round the averages and add them to the labels
        lblBowlAvg.Text = Math.Round(BowlAvg, 2)

        lblBatAvg.SetBounds(125, 5, 25, DefaultHeight) 'position and add each label to the user interface
        lblBowlAvg.SetBounds(lblBatAvg.Right, 5, 25, DefaultHeight)
        _remove.SetBounds(lblBowlAvg.Right + 50, 0, 100, DefaultHeight) 'position and add the remove button
        _name.SetBounds(0, 5, _name.PreferredWidth, DefaultHeight)
        Controls.Add(lblBatAvg)
        Controls.Add(lblBowlAvg)
        Controls.Add(_remove)
    End Sub

End Class
