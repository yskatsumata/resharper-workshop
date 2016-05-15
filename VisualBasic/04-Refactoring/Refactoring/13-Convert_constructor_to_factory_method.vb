Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Constructor To Factory Method
    '
    ' Creates a static factory method, to call constructor. Makes constructor private.
    '
    ' Has no keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    Public Class ConvertConstructorToFactoryMethod
        ' 1. Convert constructor to factory method
        '    Place text caret on constructor definition
        '    Invoke Refactor This → Replace Constructor With Factory Method
        '    Choose name for factory method, And fully qualified type to create method in
        '      (Type must already exist)
        Public Sub New(forename As String, surname As String, age As Integer)
        End Sub
    End Class

    Public Class ConstructorConsumer
        Public Sub Method()
            ' 2. Confirm constructor has been replaced with factory method call
            Dim [class] = New ConvertConstructorToFactoryMethod("Debbie", "Harry", 23)
        End Sub
    End Class
End Namespace