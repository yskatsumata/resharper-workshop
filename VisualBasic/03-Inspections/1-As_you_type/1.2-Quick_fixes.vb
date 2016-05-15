Imports System.IO

Namespace JetBrains.ReSharper.Koans.Inspections
    ' Quick Fixes
    '
    ' Provides an automated fix for a highlight
    '
    ' Alt+Enter

    Public Class QuickFixes
        Public Function ErrorHighlight() As String
            ' 1. Fix error highlight by changing return type of method, or returning a string
            '    Replace the "Nothing" with 3000 below
            '    ReSharper shows an error highlight
            '    Place caret on highlighted region and press Alt+Enter
            '    Select "Change type of method 'ErrorHighlight' to 'Integer'"
            '    Or "Call ToString()" (# Not supported for VB.NET?)
            Return Nothing    ' Replace with 3000
        End Function

        Public Sub WarningHighlight()
            Const condition As Integer = 42

            ' 2. Fix warning highlight by quick fix
            '    Place caret on highlighted region and press Alt+Enter
            '    Select to replace if statement with the contents of the branch
            '    Or replace with the constant "true"
            If condition = 42 Then
                Console.WriteLine("True")
            End If
        End Sub

        Public Sub SuggestionHighlight()
            ' 3. Make suggested replacement by quick fix
            '    Place caret on highlighted region and press Alt+Enter
            '    Select "Use method Any()" to replace the call to Count()
            Dim files = Directory.GetFiles("C:\\temp", "*.txt")
            If files.Count() > 0 Then
                Console.WriteLine("Got some!")
            End If
        End Sub

        Public Sub HintHighlight()
            PrivateMethodCanBeMadeStatic()
        End Sub

        ' 4. Make hint replacement by quick fix
        '    Place caret on highlighted region and press Alt+Enter
        '    Select Make method 'PrivateMethodCanBeMadeStatic' shared to change the method
        Private Sub PrivateMethodCanBeMadeStatic()
        End Sub

        Public Sub DeadCode()
            Return


            ' 5. Remove unreachable code by quick fix
            '    Place caret on highlighted region and press Alt+Enter
            '    Select Remove unreachable code, or Uncomment unreachable code
            Console.WriteLine("Hello")
        End Sub
    End Class
End Namespace