
Public Class LoginForm
    'DATA MEMBERS

    Private detailsFile As String = "details.dat" 'String to store path of details file
    Private oneDetail As details 'one object of type structure details to temporarily store details of users read from details file
    Private numberOfRecords As Integer 'Global variable to store the number of records in details file
    Private arrayOfDetails() As details 'Array to temporarily store the details obejects

    'Sub procedure called when user requests login
    Private Sub loginButton_Click(sender As System.Object, e As System.EventArgs) Handles loginButton.Click

        Dim inputUsername As String = usernametextBox.Text() 'get username and password and store in local variables
        Dim inputPassword As String = passwordTextBox.Text()
        Dim flag As Boolean = False 'local variable to store whether or not input username/password are correct
        Dim Admin As Boolean 'local variable to store whether or not the user is an admin
        FileOpen(1, detailsFile, OpenMode.Random, , , Len(oneDetail)) 'open details file
        numberOfRecords = LOF(1) / Len(oneDetail) 'calculate number of records

        For i = 0 To numberOfRecords - 1 'for each record

            FileGet(1, oneDetail) 'get next record
            If ((RTrim(oneDetail.username) = inputUsername) And (RTrim(oneDetail.password) = inputPassword)) Then 'check username and password

                flag = True 'if both correct flag the details as correct
                Admin = oneDetail.admin 'record whether or not user is an admin
                i = numberOfRecords - 1 'break loop
            Else

                flag = False 'otherwise flag details as being incorrect
            End If
        Next

        FileClose(1)


        flag = True
        If (flag = True) Then 'if username and password are correct
            MainForm.userIsAdmin = True 'Pass whether or not user is an admin to the main form
            MainForm.Show() 'open the main form
        Else
            If (inputUsername = "") Then
                MainForm.userIsAdmin = False
                MainForm.ShowDialog()
            End If
            MsgBox("Invalid Username or Password - Click help for help") 'inform user of incorrect details entered
        End If
    End Sub

    'sub procedure called when the help button is clicked
    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("If you do not know the details for an administrator account, leave the username field blank and click login." & vbCrLf & vbCrLf & "This will allow you to view but not edit details.")
    End Sub
End Class
