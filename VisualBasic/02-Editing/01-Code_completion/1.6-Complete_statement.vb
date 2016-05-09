Namespace JetBrains.ReSharper.Koans.Editing
    ' Complete Statement (# Not supported for VB.NET?)
    '
    ' Finish the current statement And move the caret to the next position ready for editing
    '
    ' Ctrl+Shift+Enter (VS + IntelliJ)

    Public Class CompleteStatement
        Public Sub CompleteSimpleStatement()
            ' 1. Complete simple statement
            '    Uncomment the uncompleted statement below
            '    Place the caret anywhere in the statement
            '    Invoke Complete Statement

            ' Console.WriteLine("Hello
        End Sub

        Public Sub CompleteIfStatement()
            ' 2. Complete if statement
            '    Uncomment the uncompleted if statement below
            '    Place the caret anywhere in the statement
            '    Invoke Complete Statement

            'If True
        End Sub

        Public Sub CompleteComplexStatment()
            ' 3. Complete if statement
            '    Uncomment the uncompleted if statement below
            '    Place the caret anywhere in the statement
            '    Invoke Complete Statement

            'Console.WriteLine(Blah("Hello"
        End Sub

#Region "Implementation details"

        Private Function Blah(value As String) As String
            Return value.ToUpperInvariant()
        End Function

#End Region
    End Class
End Namespace