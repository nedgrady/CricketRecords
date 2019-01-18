'module to store the strucure to store the login details
Module LoginModule
    'structure to store the login details
    Structure details
        <VBFixedString(15)> Public username As String
        <VBFixedString(15)> Public password As String
        Public admin As Boolean
    End Structure

End Module
