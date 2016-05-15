Imports System.IO

Namespace JetBrains.ReSharper.Koans.Inspections
    ' 1. Generated code Is Not analysed for warnings Or suggestions
    '    This file Is marked as generated due to the *.generated.cs file name
    '    (As used by e.g. Windows Forms designer)
    '    Custom file names can be configured in ReSharper → Options → Generated Code

    Public Class ErrorStripeGenerated
        Public Function ErrorHighlight() As String

            ' 2. Replace null with 3000 to make an error highlight
            '    Errors are still highlighted
            Return Nothing
        End Function

        Public Sub WarningHighlight()
            ' 3. No warnings
            Const condition As Integer = 42
            If condition = 42 Then
                Console.WriteLine("True")
            End If
        End Sub

        Public Sub SuggestionHighlight()
            ' 4. No suggestions
            Dim files = Directory.GetFiles("C:\\temp", "*.txt")
            If files.Count() > 0 Then
                Console.WriteLine("Got some!")
            End If
        End Sub

        Public Sub HintHighlight()
            PrivateMethodCanBeMadeStatic()
        End Sub

        ' 5. No hints
        Private Sub PrivateMethodCanBeMadeStatic()
        End Sub

        Public Sub DeadCode()
            ' 6. Redundant code Is highlighted in the editor, but Not the error stripe
            ' (# Not supported for VB.NET?)
            ConditionalMethod()

            Return

            ' 7. Unreachable code is still highlighted (# Not supported for VB.NET?)
            Console.WriteLine("Hello")
        End Sub

        <Conditional("UndefinedSymbol")>
        Private Sub ConditionalMethod()
        End Sub
    End Class
End Namespace