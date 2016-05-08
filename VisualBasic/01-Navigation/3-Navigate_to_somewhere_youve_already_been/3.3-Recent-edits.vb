Imports System

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Show Recent Edits
    '
    ' Shows a popup menu of recent edits. Shows code blocks, Not files
    '
    ' Ctrl+Shift+, (VS)
    ' Ctrl+Shift+Alt+Backspace (IntelliJ)

    Public Class RecentEdits
        Private firstName As String
        Private lastName As String

        Public Sub New(firstName As String, lastName As String)
            Me.firstName = firstName
            Me.lastName = lastName
        End Sub

        Private Function GetName() As String
            ' 1. Implement GetName by returning firstName
            Throw New NotImplementedException()
        End Function

        Public Sub Dump()
            ' 2. Implement by uncommenting
            ' Console.WriteLine("Name: {0}", GetName())

            ' 3. Return to GetName using Recent Edits And change to be firstName + lastName
            ' 4. Return back here And uncomment the following
            ' Console.WriteLine("Done")
        End Sub
    End Class
End Namespace