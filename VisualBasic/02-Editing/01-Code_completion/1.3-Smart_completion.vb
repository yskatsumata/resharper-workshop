Namespace JetBrains.ReSharper.Koans.Editing
    ' Smart Completion
    '
    ' Narrows candidates to those that best suit the current context
    '
    ' Ctrl+Alt+Space (VS)
    ' Ctrl+Shift+Space (IntelliJ)

    Public Class SmartCompletion
        ' 1. Start typing: Dim s As String = 
        ' Automatic Completion offers Smart Completion items first (string items)
        '      (followed by local Basic items, wider Basic And then Import items)
        ' 2. Uncomment: Dim s2 As String = 
        ' Invoke Smart Completion at the end of the line
        '    Smart Completion only shows string based candidates
        '    (Including methods that return string, such as String.Concat)
        ' 3. Uncomment: Dim s3 As String = Me.
        ' Invoke Smart Completion at the end of the line
        '    Smart Completion only shows string based candidates for the this parameter
        ' Note that the Age property isn't used
        Public Sub SmartUseString(stringParameter As String)
            'Dim s2 As String = 
            'Dim s3 As String = Me.
        End Sub

        Public Property Age As Integer

#Region "Implementation details"

        Public Property Name As String
        Public Function GetGreeting() As String
            Return "hello"
        End Function

#End Region
    End Class
End Namespace