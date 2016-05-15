Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Introduce Variable
    '
    ' Create a variable from selection
    '
    ' Ctrl+R, V (VS)
    ' Ctrl+Alt+V (IntelliJ)

    ' Inline variable
    '
    ' Replaces variable usage with the contents of the variable
    '
    ' Ctrl+R, I (VS)
    ' Ctrl+Alt+N (IntelliJ)

    Public Class IntroduceAndInlineVariable
        Public Sub Calculate(a As Integer, b As Integer)
            ' 1. Introduce variable
            '    Select "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Introduce Variable
            '    Specify type, Or 'var', and name
            Console.WriteLine(a + b)
        End Sub

        Public Sub Calculate2(a As Integer, b As Integer)
            ' 2. Introduce variable from multiple usages
            '    Select one of the "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Introduce Variable
            '    ReSharper highlights all usages, prompts for one usage Or all
            '    Select all, they all get replaced
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
        End Sub

        Public Sub Calculate3(a As Integer, b As Integer)
            ' 3. Inline variable
            '    Select "value" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Inline Variable
            '    Variable Is removed, And usage Is replaced with "a+b"
            Dim value = a + b
            Console.WriteLine(value)
        End Sub
    End Class
End Namespace