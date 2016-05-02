Imports System.ComponentModel
Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Navigate To menu
    '
    ' Displays a contextual menu of options you can use to navigate to from
    ' your current location
    '
    ' Very useful way of navigating without having to learn ALL of the shortcuts!
    '
    ' Alt+` (VS)
    ' Ctrl+Shift+G (IntelliJ)

    ' 1. When the caret Is on a type definition (DerivedClass)
    '    (Find Usages, related files covered later)
    '    a) Go to Base Symbols + Derived Symbols
    '    b) Extension methods
    '    c) Object Browser, Windows Explorer, Command Prompt
    '    d) Locate in Solution Explorer
    '    d) Referenced Code finds all code referenced by the type, e.g. BaseClass
    Public Class DerivedClass   ' <- Text caret On DerivedClass
        Inherits BaseClass
    End Class

    ' 2. When the caret Is on a base class (BaseClass)
    '    a) As above (find usages, base symbols, etc.)
    '    b) Declaration navigates to the declaration of BaseClass
    '    c) Implementation navigates to the implementations of BaseClass - deriving symbols
    '    d) Overriding members highlights all members that override from BaseClass
    '       Escape clears the highlight
    '       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
    '       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    Public Class DerivedClass2
        Inherits BaseClass ' <- Text caret on BaseClass
        Public Overrides Sub VirtualMethod()
        End Sub

        Public Overrides ReadOnly Property VirtualProperty As String
            Get
                Return "cheese"
            End Get
        End Property
    End Class

    ' 3. When the caret Is on an implemented interface (ISimpleInterface)
    '    a) as above (find usages, base symbols, declarations, implementations, etc.)
    '    b) Implementing Members highlights all members of the interface
    '       Escape clears the highlight
    '       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
    '       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    Public Class SimpleClass
        Implements ISimpleInterface  ' <- Text caret on ISimpleInterface
        Public Sub SayHello() Implements ISimpleInterface.SayHello
            Console.WriteLine("hello")
        End Sub

        Public Sub SayGoodbye() Implements ISimpleInterface.SayGoodbye
            Console.WriteLine("goodbye")
        End Sub
    End Class

    ' # Not supported on VB.NET?
    ' 4. When the caret Is on an implementing interface defined in another assembly
    '    a) Doing Go To Derived Symbols on IComponent will only show SimpleComponent
    '    b) Navigate to Declaration of IComponent And then doing Go To Derived Symbols
    '       widens the scope, And includes all referenced assemblies, showing many more
    '       derived types
    Public Class SimpleComponent
        Implements IComponent  ' <- Text caret on IComponent

#Region "Implementation details"

        Public Sub Dispose() Implements IDisposable.Dispose
            Throw New NotImplementedException()
        End Sub

        Public Property Site As ISite Implements IComponent.Site
        Public Event Disposed As EventHandler Implements IComponent.Disposed

#End Region
    End Class
End Namespace