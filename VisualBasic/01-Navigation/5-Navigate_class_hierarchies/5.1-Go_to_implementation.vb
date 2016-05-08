Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Go to Implementation
    '
    ' Navigates to the implementation of the type. For most types, navigates to definition.
    ' For interfaces, navigates to implementations of the interface, for base classes,
    ' navigates to derived instances
    '
    ' Alt+` (VS)
    ' No keyboard shortcut for IntelliJ - ReSharper → Navigate → Go to Implementation

    Public Class GoToImplementation
        Public Sub Method()
            ' 1. Put the caret on ICustomer And Go To Implementation
            '    Get the choice of Customer, SilverCustomer And GoldCustomer
            '    Customer Is bold because it's a direct implementation of ICustomer
            '    SilverCustomer And GoldCustomer are indirect implementations
            '    (because they derive from Customer)
            ' 2. Put the caret on ICustomer And Go To Implementation
            '    Filter by typing, middle matching, wildcards And CamelHumps
            Dim customer As ICustomer = GetCustomer()

            ' 3. Put the caret on the Customer And Go To Implementation
            '    Takes you straight to the implementation of the constructor
            Dim customer2 = New Customer("id", "Daisy")
        End Sub

        Private Function GetCustomer() As ICustomer
            Return New Customer("id", "Matt")
        End Function
    End Class
End Namespace