Imports System.IO

Namespace JetBrains.ReSharper.Koans.Inspections
    ' Highlights are reflected in the Error Stripe on the right of the editor
    '
    ' 1. Mouse over each mark in the Error Stripe
    '    See tooltip
    '    Click the mark to navigate
    ' 2. Note the icon at the top right. Shows if there are any warnings, suggestions Or errors outstanding
    '    "Code to green" - aim for a green tick

    Public Class ErrorStripe
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
            If files.Count() > 0 Then
                Console.WriteLine("Got some!")
            End If
        End Sub

        Public Sub HintHighlight()
            PrivateMethodCanBeMadeStatic()
        End Sub

        ' 2. Hints are Not shown in the Error Stripe
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