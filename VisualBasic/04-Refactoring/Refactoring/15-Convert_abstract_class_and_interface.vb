Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Abstract Class to Interface
    '
    ' No keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    ' Convert Interface to Abstract Class
    '
    ' No keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R


    ' 1. Convert abstract class to interface
    '    Place text caret on class definition
    '    Invoke Refactor This → Convert Abstract Class to Interface
    Public MustInherit Class AbstractClass
        Public MustOverride ReadOnly Property Name() As String
    End Class

    Public Class DerivedClass
        Inherits AbstractClass
        Protected _name As String

        Public Sub New()
            _name = "Phil"
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return _name
            End Get
        End Property
    End Class

    ' 2. Convert abstract class to interface, when abstract class has implementations
    '    Place text caret on class definition
    '    Invoke Refactor This → Convert Abstract Class to Interface
    '    ReSharper warns abstract class has implementation methods
    '    Cancel, Or continue to convert to interface And remove the body of the implementation
    '      (Derived class will Not compile)
    Public MustInherit Class AbstractClassWithImplementation
        Public MustOverride ReadOnly Property Name As String

        Public Sub SayHello()
            Console.WriteLine("Hello " + Name)
        End Sub
    End Class

    Public Class DerivedClass2
        Inherits AbstractClassWithImplementation

        Private _name As String

        Public Sub New()
            _name = "Phil"
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return _name
            End Get
        End Property
    End Class

    ' 3. Convert interface to abstract class
    '    Place text caret on class definition
    '    Invoke Refactor This → Convert Abstract Class to Interface
    '    ReSharper creates abstract class with no implementations
    '      And makes implementing methods "override" in derived class
    Public Interface IPerson
        ReadOnly Property Name As String
        Sub SayHello()
    End Interface

    Public Class Person
        Implements IPerson
        Private ReadOnly _name As String

        Public Sub New(name As String)
            _name = name
        End Sub

        Public ReadOnly Property Name As String Implements IPerson.Name
            Get
                Return _name
            End Get
        End Property

        Public Sub SayHello() Implements IPerson.SayHello
            Console.WriteLine("Hello " + Name)
        End Sub
    End Class
End Namespace