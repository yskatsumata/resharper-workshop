Namespace JetBrains.ReSharper.Koans.Inspections
    ' Find code issues
    '
    ' ReSharper → Inspect → Code Issues in Solution/Current Project

    Public Class FindMatchingIssues
        Public Sub MultipleIssues()
            ' 1. Alt+Enter on the first List(Of String) highlight
            '    Expand the "Inspection 'Use implicitly typed variable declaration (evident)'" submenu
            '    Select "Find similar issues in file"
            '    Specify the scope in the dialog - project, solution Or custom
            '    All matching issues are displayed in a New results window
            Dim names As List(Of String) = New List(Of String)()
            Dim address As List(Of String) = New List(Of String)()
            Dim ages As List(Of Integer) = New List(Of Integer)()
        End Sub
    End Class
End Namespace