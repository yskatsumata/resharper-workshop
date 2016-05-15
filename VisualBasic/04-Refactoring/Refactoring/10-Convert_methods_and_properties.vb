Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Method to Property
    '
    ' No shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    ' Convert Property to Method(s)
    '
    ' Converts a property to a getter And/Or setter method(s)
    '
    ' No shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    Public Class ConvertMethodToProperty
        ' 1. Convert method to property
        '    Method must have no parameters
        '    Place text caret on method definition
        '    Invoke Convert Method To Property
        '    ReSharper suggests name
        '    Confirm to convert
        Private Function GetName() As String
            Return "Matt"
        End Function

        Public Sub OutputName()
            Console.WriteLine(GetName())
        End Sub
    End Class

    Public Class ConvertPropertyToMethod
        Private backingField As String

        ' 2. Convert auto property to methods
        '    Place text caret on property definition
        '    Invoke Convert property to methods
        '    Optionally generate getter And/Or setter
        '    Confirm - ReSharper will automatically generate backing field
        Public Property AutoProperty As String

        ' 3. Convert property to methods
        '    Place text caret on property definition
        '    Invoke Convert property to methods
        '    Optionally generate getter And/Or setter
        Public Property PropertyWithBackingField As String
            Get
                Return backingField
            End Get
            Set(value As String)
                backingField = value
            End Set
        End Property

        ' 4. Convert readony property to method
        '    Place text caret on property definition
        '    Invoke Convert property to methods
        '    Will only generate getter
        Public ReadOnly Property GetterOnlyProperty As String
            Get
                Return backingField
            End Get
        End Property

        Public Sub Output()
            ' 5. Confirm usages are still correct
            Console.WriteLine(AutoProperty)
            Console.WriteLine(PropertyWithBackingField)
            Console.WriteLine(GetterOnlyProperty)
        End Sub
    End Class
End Namespace