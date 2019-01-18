Public Class Validation

    Public Shared Function CheckInt(matches As String) As Boolean

        Dim test As Integer

        Try
            test = matches
        Catch ex As InvalidCastException
            Return False
        End Try

        If (matches >= 0) Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Shared Function CheckName(name As String) As Boolean

        Dim validName As Boolean = False 'local variable used to store whether the passed name is valid

        'ALLOWED CHARACTER CHECK:
        For i = 0 To name.Length - 1 'for each letter in the passed name

            If (Char.IsLetter(name(i)) Or name(i) = "-" Or name(i) = "'") Then 'if the current character in the passed name is a letter, hypen or apostrophe 

                validName = True 'the name is valid

            Else
                MsgBox("Note: Non alphabetic name character has been entered" & vbCrLf &
                       "This will not cause any errors, but may mean a mistake has" & vbCrLf & "been made entering a name. ", MsgBoxStyle.Information) 'error message
                Return True 'otherwise return false as soon as the non-alphabetic character is found.
                'this will break from the sub-procedure, so the length check will not take place. 
            End If
        Next

        Return validName
    End Function

    Public Shared Function RangeCheck(num As Integer, floor As Integer, ceiling As Integer) As Boolean

        If (num > ceiling Or num < floor) Then

            Return False
        Else
            Return True

        End If


    End Function

    Public Shared Function lengthCheck(str As String, minLen As Integer, maxLen As Integer) As Boolean

        If (Len(str) >= minLen) And (Len(str) <= maxLen) Then 'if the string passed is between the upper/lower bound

            Return True

        Else

            Return False

        End If

    End Function

    Private Shared Function charsCheck(str As String, requiredChars() As Char) As Boolean


        Dim flag As Boolean = False 'loacl variable to store whether or not a required character has been used

        For i = 1 To Len(str)  'for each character in the passed string

            For j = 0 To requiredChars.Length - 1 'for each index in the array of required characters

                If (Asc(Mid(str, i, 1)) = Asc(requiredChars(j))) Then 'check if the current character in the string matches the current character in the required chars array


                    flag = True 'string is vaild
                    i = Len(str)
                    j = requiredChars.Length 'break the loop

                End If

            Next

        Next

        Return flag

    End Function

    Public Shared Function charsCheck(str As String, requiredChars() As Char, numbers As Boolean) As Boolean

        Dim flag As Boolean = False 'local variable to store whether or not a required character has been used


        If (numbers = False) Then 'if numbers are not required in the string

            Return charsCheck(str, requiredChars) 'then check only for the passed characters

        Else

            If (((charsCheck(str, requiredChars)) = True) And (numCheck(str) = True)) Then 'if numbers are required in the string then check for both the required characters and numbers


                Return True

            Else

                Return False

            End If

        End If

    End Function

    Public Shared Function numCheck(str As String) As Boolean
        Dim currentChar As Integer
        Dim flag As Boolean
        For i = 1 To Len(str) 'for each character in the passed string

            currentChar = Asc(Mid(str, i, 1))

            If (currentChar >= 48 And currentChar <= 57) Then

                i = Len(str)
                flag = True


            End If
        Next

        Return flag
    End Function
End Class
