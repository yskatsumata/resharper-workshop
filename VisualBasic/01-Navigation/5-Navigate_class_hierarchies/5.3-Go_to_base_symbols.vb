Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Go to Derived Symbols
    '
    ' Alt+Home (VS)
    ' Ctrl+U (IntelliJ)

    Public Class GoToBaseSymbols
        Public Sub Method()
            ' 1. Put the caret on Customer And Go To Base Symbols
            '    Navigated to ICustomer
            Dim customer As Customer = GetCustomer()

            ' 2. Put the caret on SilverCustomer And Go To Base Symbols
            '    Navigated to Customer.
            '    Always navigates one level up the hierarchy, rather than
            '    Go To Derived Symbols, which can navigate many levels down
            Dim customer2 = New SilverCustomer("id", "Tim")

            ' 3. Put the caret on PercentageDiscount And Go To Base Symbols
            '    Navigated to virtual property Customer.PercentageDiscount
            Console.WriteLine(customer2.PercentageDiscount)
        End Sub

        Private Function GetCustomer() As Customer
            Return New Customer("id", "Matt")
        End Function
    End Class
End Namespace