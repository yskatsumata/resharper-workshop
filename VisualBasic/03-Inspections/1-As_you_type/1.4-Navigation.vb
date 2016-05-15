Imports System.IO

Namespace JetBrains.ReSharper.Koans.Inspections
    ' Navigate between highlights
    '
    ' Alt+PageUp And Alt+PageDn (VS)
    ' F12 And Shift+F12 (IntelliJ)
    '
    ' Navigate between errors
    '
    ' Shift+Alt+PageUp And ShiftAlt+PageDown (VS)
    ' Alt+F12 And Shift+Alt+F12 (IntelliJ)

    Public Class Navigation
        Public Function ErrorHighlight() As String

            ' 1. Replace Nothing with 3000 to make an error highlight
            Return Nothing
        End Function

        Public Sub WarningHighlight()
            Const condition As Integer = 42
            If condition = 42 Then
                Console.WriteLine("True")
            End If
        End Sub

        Public Sub SuggestionHighlight()
            Dim files = Directory.GetFiles("C:\\temp", "*.txt")
            If (files.Count() > 0) Then
                Console.WriteLine("Got some!")
            End If
        End Sub

        Public Sub HintHighlight()
            PrivateMethodCanBeMadeStatic()
        End Sub

        ' 2. Hints are Not navigable
        Private Sub PrivateMethodCanBeMadeStatic()
        End Sub

        Public Sub DeadCode()
            ' 5. Highlights code that Is redundant Or unreachable
            '    Shows as greyed out
            '    Hover mouse over to see tooltip: "Method invocation is skipped..."
            ConditionalMethod()

            Return

            ' "Code is unreachable"
            Console.WriteLine("Hello")
        End Sub

        <Conditional("UndefinedSymbol")>
        Private Sub ConditionalMethod()
        End Sub
    End Class
End Namespace