Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Pull Members Up
    '
    ' Pulls members up the inheritance chain from the current type to the base type.
    ' Moves members from a derived type to a base type
    '
    ' No keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    ' Push Members Down
    '
    ' Pushes members down the inheritance chain from the current type to inheriting types.
    ' Moves members from a base type to a derived type
    '
    ' No keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    Namespace PullUp
        Public Class Base
        End Class

        Public Class Derived
            Inherits Base
        End Class

        ' 1. Pull members up to base type
        '    Invoke Refactor This → Pull Members Up on Derived
        '    Choose the base type to move to (Derived Or Base)
        '    Choose the members to move
        Public Class MostDerived
            Inherits Derived
            Public Property PropertyOnDerived As String
        End Class
    End Namespace

    Namespace PushDown
        ' 2. Push members down from Base to inheriting types
        '    Invoke Refactor This → Push Members Down on Base
        '    Choose which inheriting types to push to
        '    Choose which members to push down
        Public Class Base
            Public Property PropertyOnBase As String

            ' 3. Push members down on property that Is in use
            '    Invoke Refactor This → Push Members Down on Base
            '    Choose which inheriting types to push to
            '    Choose UsedPropertyOnBase
            '    ReSharper warns that UsedPropertyOnBase cannot be moved
            Public Property UsedPropertyOnBase As String
        End Class

        Public Class Derived
            Inherits Base
        End Class

        Public Class Derived2
            Inherits Base
        End Class

        Public Class Consumer
            Public Sub Method()
                Dim [base] = New Base()
                Console.WriteLine([base].UsedPropertyOnBase)
            End Sub
        End Class
    End Namespace
End Namespace