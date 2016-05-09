Imports Editing.JetBrains.ReSharper.Koans.Editing.Services

Namespace JetBrains.ReSharper.Koans.Editing
    ' Import Completion
    '
    ' Completes symbols Not visible in current scope, by adding using statements
    '
    ' Automatic Completion also does Import Completion. Using Import Completion alone
    ' reduces the candidates in the list
    '
    ' Shift+Alt+Space (VS)
    ' Ctrl+Alt+Space (IntelliJ)

    Namespace Services
        Public Class Provider
        End Class
    End Namespace

    Public Class ImportCompletion
        Public Sub UsesTypeFromNamespaceNotImported()
            ' 1. Start typing: Dim provider = New Provider
            '    Automatic Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            '    Selecting it will add a Imports statement automatically
            ' 2. Remove using statement
            '    Ensure the text says: "Dim provider = New Provider" And Provider Is undefined
            '    Invoke Basic Completion (Ctrl+Space)
            '    Basic Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            '    Selecting it will add a using statement automatically
            ' 3. Remove using statement
            '    Ensure the text says: "Dim provider = New Provider" And Provider Is undefined
            '    Invoke Import Completion
            '    Import Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            '    Import Completion ALSO has fewer candidates in the list
            'Dim provider = New Provid
        End Sub
    End Class
End Namespace