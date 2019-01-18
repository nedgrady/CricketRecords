Public Class AddLogInForm

    Public specialChars() As Char = {"_", "#"} 'array containing any characters that must be included in the password
    Private Const maxPasswordLength As Integer = 15 'constant to store the maximum password length
    Private Const minPasswordLength As Integer = 5 'constnat to store the minumum password length
    Private Const minUsernameLength As Integer = 1 'constant to store the minum username length
    Private Const maxUsernameLength As Integer = 15 'constant to store the maximum username length
    Private detailsFile As String = "details.dat" 'String to store path of details file
    Private oneDetail As details 'global variable to act as a temporary storage area for one set of details
    Private numberOfRecords As Integer 'global variable to store the number of records in the players file

    'sub procedure called when the submit button is clicked to add a new set of login details
    Private Sub _btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles _btnSubmit.Click
        Dim username, password As String 'local variables to store the username and password input
        username = _txtUsername.Text() 'input the username
        password = _txtPassword.Text() 'input the password

        'validate the password and username entered with a length check and allowed character's check.
        If ((Validation.lengthCheck(password, minPasswordLength, maxPasswordLength) = True) And
            (Validation.charsCheck(password, specialChars, True) = True) And
            (Validation.lengthCheck(username, minUsernameLength, maxUsernameLength) = True)) And
            (password = _txtConfirmPassword.Text) Then

            'if the input details are valid
            oneDetail.username = _txtUsername.Text 'assign the details to the object ready to be written to the file
            oneDetail.password = _txtPassword.Text
            oneDetail.admin = True

            FileOpen(1, detailsFile, OpenMode.Random, OpenAccess.Write, , Len(oneDetail)) 'open the details file
            numberOfRecords = (LOF(1) / Len(oneDetail)) + 1 'calculate the next free records
            FilePut(1, oneDetail, numberOfRecords) 'write the details to the details file

            FileClose(1) 'close details file
        Else
            'if any details are invalid
            Dim chars As String = "" 'string to store the list of characters needed in passwords
            For i = 0 To specialChars.Length - 1
                chars += "  " & specialChars(i)
            Next
            'output that the details are invalid, and the criteria for valid details
            MsgBox("Invalid username/password." & vbCrLf & "Ensure username is between 1 and 15 characters, and" & vbCrLf & "password is between 5 and 15 characters and contains:  " & chars)


        End If
    End Sub

End Class