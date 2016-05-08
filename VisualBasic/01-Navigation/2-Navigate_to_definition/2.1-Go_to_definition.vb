Imports ExampleCode
Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Go To Definition
    '
    ' Navigates to the definition of a symbol
    '
    ' Ctrl+Click
    ' Ctrl+B (VS)
    ' Ctrl+B (IntelliJ)

    Public Class GoToDefinition

        Public Sub Method(name As String, age As Integer)

            ' 1. Ctrl+Click on "Person"
            ' 2. Use the keyboard shortcut
            Dim person = New Person("Hadi", 53)

            ' 3. Go To Definition for "name" Or "age" parameters
            Dim otherPerson = New Person(name, age)

            ' 4. Go To Definition on the word "var" to navigate to inferred type
            Dim thirdPerson = otherPerson

            ' 5. Navigate to definition of a type from a library
            '    Go To Definition on "Console"
            Console.WriteLine(thirdPerson.Name)

            ' 6. View a namespace in the Assembly Explorer
            '    Go To Definition on "System"
            System.Console.WriteLine()

            ' 7. Go to Definition of a namespace
            '    Ctrl+Click Or use the keyboard shortcut on "Navigation"
            Dim type = GetType(JetBrains.ReSharper.Koans.Navigation.GoToDefinition)
        End Sub
    End Class
End Namespace