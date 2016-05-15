Namespace JetBrains.ReSharper.Koans.Refactoring
    Namespace ExtractClass
        ' Extract Class
        '
        ' Creates a New class based on members in the existing class.
        ' Updates references to the extracted members to refer to
        ' an instance of the New class
        '
        ' No keyboard shortcut. Invoke via Refactor This menu
        ' Ctrl+Shift+R

        Public Class Person
            Public Property Forename As String
            Public Property Surname As String
            Public Property Age As Integer

            ' 1. Extract address to New class
            '    Select the members of the class to extract (the 5 properties below)
            '    Invoke Refactor This → Extract Class
            '    ReSharper shows dialog with properties already selected to move to extracted class
            '    Give name to extracted class ("Address" - ReSharper then populates reference to be extracted "address")
            '    By default, the original properties are removed
            '      Select from the drop down for "Source class member":
            '      None - original property Is removed
            '      Create copy - a copy of the original property Is left
            '      Create delegating wrapper - the original property calls into the New instance of the extracted class
            '    Any usages are updated to use the New Address property
            Public Property HouseNumber As String
            Public Property Street As String
            Public Property County As String
            Public Property PostCode As String
            Public Property Country As String
        End Class

        Public Class PersonConsumer
                Public Sub Method()
                Dim Person = New Person()

                ' 2. Ensure all properties still work
                Console.WriteLine(Person.HouseNumber)
                Console.WriteLine(Person.Street)
                Console.WriteLine(Person.County)
                Console.WriteLine(Person.PostCode)
                Console.WriteLine(Person.Country)
            End Sub
            End Class
    End Namespace
End Namespace