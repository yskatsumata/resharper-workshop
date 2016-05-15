Imports System.IO

Namespace JetBrains.ReSharper.Koans.Inspections
    Public Class Highlights

        Public Function ErrorHighlight() As String

            ' 1. Highlights code that Is incorrect, And will most likely fail to compile
            '    Replace the "Nothing" with 3000 below
            '    ReSharper shows an error highlight (red squiggly)
            '    Hover mouse over to see tooltip: "Cannot convert expression type 'int' to return type 'string'"
            Return Nothing
        End Function

        Public Sub WarningHighlight()

            Const condition As Integer = 42

            ' 2. Highlights code that Is potentially incorrect And should be changed
            '    Shown as a blue squiggly underline
            '    Hover mouse over to see tooltip: "Expression is always true"
            If condition = 42 Then
                Console.WriteLine("True")
            End If
        End Sub

        Public Sub SuggestionHighlight()

            ' 3. Highlights code And suggests making a change
            '    Shows as a green squiggly underline
            '    Hover mouse over to see tooltip: "Use method Any()"
            Dim files = Directory.GetFiles("C:\\temp", "*.txt")
            If files.Count() > 0 Then
                Console.WriteLine("Got some!")
            End If
        End Sub

        Public Sub HintHighlight()

            PrivateMethodCanBeMadeStatic()
        End Sub

        ' 4. Highlights code with a suggestion for a change, but the suggestion Is optional
        '    Shows as 3 green dots under the start of the highlighted region
        '    Hover mouse over to see tooltip: "Method 'PrivateMethodCanBeMadeStatic' can be made static"
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