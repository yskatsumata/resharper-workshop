Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Go to Derived Symbols
    '
    ' Alt+End (VS)
    ' Ctrl+Alt+B (IntelliJ)

    Public Class GoToDerivedSymbols
        Public Sub Method()
            ' 1. Put the caret on ICustomer And Go To Derived Symbols
            '    Get the choice of Customer, SilverCustomer And GoldCustomer
            '    Customer Is bold because it's a direct implementation of ICustomer
            '    SilverCustomer And GoldCustomer are indirect implementations
            '    (because they derive from Customer)
            ' 2. Put the caret on ICustomer And Go To Derived Symbols
            '    Filter by typing, middle matching, wildcards And CamelHumps
            Dim customer As ICustomer = GetCustomer()

            ' 3. Put the caret on the Customer And Go To Derived Symbols
            '    Shows GoldCustomer And SilverCustomer (note difference with
            '    Go To Implementation)
            Dim customer2 = New Customer("id", "Daisy")

            ' 4. Put the caret on PercentageDiscount And Go To Derived Symbols
            '    Shown overrides of virtual property in SilverCustomer And GoldCustomer
            Console.WriteLine(customer2.PercentageDiscount)
        End Sub

        Private Function GetCustomer() As ICustomer
            Return New Customer("id", "Matt")
        End Function
    End Class
End Namespace