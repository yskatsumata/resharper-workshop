Imports System.Windows.Controls

Namespace JetBrains.ReSharper.Koans.Inspections
    ' Inspect This menu - Hierarchies
    '
    ' Inspect class hierarchies
    '
    ' Ctrl+Shift+Alt+A (VS/IntelliJ)


    ' 1. Display hierarchies of IComponent
    '    Place caret on IComponent And Invoke Inspect This
    '    Results are displayed in an Inspection window
    '    Select the type of hierarchy shown in the toolbar
    '    Choose from Class, Subtypes, Supertypes, Implementation And Interface leaves
    Public Interface IComponent
    End Interface


    ' 2. Display hierarchies of BaseClass
    '    Note differences with IComponent - shows class hierarchy including Object,
    '    Implementation hierarchy shows BaseClass in context of related hierarchies
    Public Class BaseClass
        Implements IComponent
    End Class

    Public Class DerivedClass1
        Inherits BaseClass
    End Class

    Public Class DerivedClass2
        Inherits BaseClass
    End Class

    Public Class DeepestDerivedClass
        Inherits DerivedClass2
    End Class

    Public Class UnrelatedClass
        Implements IComponent
    End Class



    ' 3. Display hierarchies of UserControl
    '    Doesn't show much until you uncheck "Show Elements from this Solution"
    Public Class UserControl
        Inherits Button
    End Class
End Namespace