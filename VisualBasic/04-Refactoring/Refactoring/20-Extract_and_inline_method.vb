Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Extract Method
    '
    ' Creates a New method based on a selected code fragment
    '
    ' Ctrl+R, M (VS)
    ' Ctrl+Alt+M (IntelliJ)

    ' Inline Method
    '
    ' Replaces the call site of a method call with the contents of the method,
    ' optionally removing the original method definition
    '
    ' Ctrl+R, I (VS)
    ' Ctrl+Alt+N (IntelliJ)

    Public Class ExtractMethod
        Public Function LongMethod(items As IEnumerable(Of String)) As List(Of String)
            Dim results = New List(Of String)()
            For Each item In items
                ' 1. Extract method, with parameters And return value
                '    Select the next two lines of code. Note that it uses "item" And creates the "result" variable
                '    Invoke Extract Method - confirm name, select return value, parameters, make static/virtual, etc.
                Dim result = item.ToUpperInvariant()
                result = New String(result.Reverse().ToArray())

                ' Don't select this line
                results.Add(result)
            Next

            Return results
        End Function
    End Class

    Public Class InlineMethod
        Private Const Name As String = "Fred"

        Public Sub SayHello()
            ' 2. Inline Method
            '    Place the text caret on the method name
            '    Invoke Inline Method
            '    Confirm to inline all instances, And remove original method definition
            Console.WriteLine("Hello " + GetName())
            Console.WriteLine("Hi " + GetName())
        End Sub

        Public Function GetName() As String
            Return Name
        End Function
    End Class
End Namespace