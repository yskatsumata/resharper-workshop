Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Introduce Parameter
    '
    ' Create a parameter in the current method from selection
    '
    ' Ctrl+R, P (VS)
    ' Ctrl+Alt+P (IntelliJ)

    ' Inline Parameter
    '
    ' Replaces parameter usage with the value from the call site
    '
    ' Ctrl+R, I (VS)
    ' Ctrl+Alt+N (IntelliJ)

    Public Class IntroduceAndInlineParameter
        Public Sub OutputSum(a As Integer, b As Integer)
            ' 1. Introduce parameter
            '    Select "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Introduce Parameter
            '    Specify name "sum"
            '    Parameter Is added, And original value Is calculated at call site
            '    (Parameters a + b can be removed with Safe Delete)
            Console.WriteLine(a + b)
        End Sub

        Public Sub CallOutputSum()
            OutputSum(2, 3)
        End Sub

        Public Sub OutputSum2(a As Integer, b As Integer)
            ' 2. Introduce parameter from multiple usages
            '    Select one of the "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Introduce Parameter
            '    ReSharper highlights all usages, prompts for one usage Or all
            '    Select all, they all get replaced
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
            Console.WriteLine(a + b)
        End Sub

        Public Sub CallOutputSum2()
            OutputSum2(2, 3)
        End Sub

        ' 3. Inline parameter
        '    Select parameter "a" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
        '    Invoke Inline Parameter
        '    Select the value to be substituted for the parameter. Value comes from usage
        '    Parameter Is removed, all usages in the method are replaced with the passed value, call site Is update
        Public Sub OutputSum3(a As Integer, b As Integer)
            Console.WriteLine(a + b)
        End Sub

        Public Sub CallOutputSum3()
            OutputSum3(2, 3)
        End Sub

        ' 4. Inline parameter with multiple usages
        '    Select parameter "a" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
        '    Invoke Inline Parameter
        '    Select the value to be substituted for the parameter. Value comes from usage
        '    Parameter Is removed, all usages in the method are replaced with the chosen value, call site Is update
        Public Sub OutputSum4(a As Integer, b As Integer)
            Console.WriteLine(a + b)
        End Sub

        Public Sub CallOutputSum4()
            OutputSum4(2, 3)
            OutputSum4(12, 13)
            OutputSum4(200, 300)
        End Sub
    End Class
End Namespace