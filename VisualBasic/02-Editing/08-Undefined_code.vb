Namespace JetBrains.ReSharper.Koans.Editing
    Public Class UndefinedSymbols
        Public Sub CreateFromUsage(a As Integer, b As Integer)
            ' 1. Create from usage
            '    Uncomment these lines
            '    Alt+Enter on Calculator And create from usage
            '    Alt+Enter on Add And create from usage - select return type, parameter type usage, implement method

            'Dim calculator = New Calculator()
            'If (calculator.Add(a, b) > 100) Then
            '    Console.WriteLine("Winner!")
            'End If
        End Sub

        Public Sub ChangeAllLocal()
            Const result = 23

            ' 2. Change All Local
            '    Update all usages of an undefined symbol in the current method
            '    Uncomment broken code
            '    Alt+Enter on undefined symbol
            '    Select Chage all local 'value'
            '    ReSharper suggests alternatives that fit - result from local method, And NewValue field
            '    Accepting change only affects this method
            '    (# Not supported for VB.NET?)

'            Console.WriteLine(value)
'            Console.WriteLine(value)
'            Console.WriteLine(value)
        End Sub

        Public Const NewValue As Integer = 42

        Public Sub ChangeAll()
            Const localValue = 100

            ' 2. Change All
            '    Update all usages of an undefined symbol across methods
            '    Uncomment broken code below, And in ChangeAll2
            '    Alt+Enter on undefined symbol
            '    Select Chage all 'value'
            '    ReSharper suggests alternatives that fit - NewValue field, but Not localValue
            '      (it's not accessible from ChangeAll2)
            '    Accepting change only affects this method And ChangeAll2
            '    (# Not supported for VB.NET?)

'            Console.WriteLine(value)
'            Console.WriteLine(value)
'            Console.WriteLine(value)
        End Sub

        Public Sub ChangeAll2()
'            Console.WriteLine(value)
'            Console.WriteLine(value)
'            Console.WriteLine(value)
        End Sub
    End Class
End Namespace