Namespace JetBrains.ReSharper.Koans.Refactoring
    Namespace ExtractSuperclass
        ' Extract Superclass
        '
        ' Extract members to act as a New base class to the current class
        '
        ' No keyboard shortcut. Invoke via Refactor This menu
        ' Ctrl+Shift+R

        ' 1. Extract superclass
        '    Place text caret on type definition
        '    Invoke Refactor This → Extract Superclass
        '    Confirm name of base class, location And which members
        '      (Select Forename, Surname And Age)
        '    ReSharper creates a New class with the members, inherits from it
        Public Class Person
            Public Sub New(forename As String, surname As String, age As Integer)
                Me.Forename = forename
                Me.Surname = surname
                Me.Age = age
            End Sub

            Public ReadOnly Property Forename As String
            Public ReadOnly Property Surname As String

            Public ReadOnly Property Fullname As String
                Get
                    Return Forename + " " + Surname
                End Get
            End Property

            Public ReadOnly Property Age As Integer
        End Class

        ' 2. Extract interface from hierarchy
        '    Place text caret on type definition
        '    Invoke Refactor This → Extract Superclass
        '    Confirm name of base class, location And which members - list includes inherited members
        '      (Select SayHello)
        Public Class TitledPerson
            Inherits SimplePerson

            Public Sub New(forename As String, surname As String, age As Integer, title As String)
                MyBase.New(forename, surname, age)
                Me.Title = title
            End Sub

            Public ReadOnly Property Title As String

            Public Sub SayHello()
                Console.WriteLine("Hello {0}", Forename)
            End Sub
        End Class

        Public Class SimplePerson
            Public Sub New(forename As String, surname As String, age As Integer)
                Me.Forename = forename
                Me.Surname = surname
                Me.Age = age
            End Sub

            Public ReadOnly Property Forename As String
            Public ReadOnly Property Surname As String
            Public ReadOnly Property Age As Integer
        End Class
    End Namespace
End Namespace