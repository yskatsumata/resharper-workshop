namespace JetBrains.ReSharper.Koans.Refactoring
    Namespace ExtractInterface
        ' Extract Interface
        '
        ' Extracts an interface based on the current class
        '
        ' No keyboard shortcut. Invoke via Refactor This menu
        ' Ctrl+Shift+R

        ' 1. Extract interface
        '    Place text caret on type definition
        '    Invoke Refactor This → Extract Interface
        '    Confirm name of interface, location and which members
        '    If selecting private or protected members, ReSharper warns that they will be made public
        Public Class Person
            Public Sub New(forename As String, surname As String, age As Integer)
                Me.Forename = forename
                Me.Surname = surname
                Me.Age = age

                Dump()
            End Sub

            Public ReadOnly Property Forename As String
            Public ReadOnly Property Surname As String

            Public ReadOnly Property Fullname As String
                Get
                    Return Forename + " " + Surname
                End Get
            End Property

            Public ReadOnly Property Age As Integer

            Private Sub Dump()
                Console.WriteLine("{0} is {1} years old", Fullname, Age)
            End Sub
        End Class

        ' 2. Extract interface from hierarchy
        '    Place text caret on type definition
        '    Invoke Refactor This → Extract Interface
        '    Confirm name of interface, location and which members - list includes inherited members
        '    If selecting private or protected members, ReSharper warns that they will be made public
        Public Class DerivedPerson
                Inherits BasePerson

                Public Sub New(forename As String, surname As String, age As Integer, title As String)
                    MyBase.New(forename, surname, age) 'base(forename, surname, age)

                    Me.Title = title
                End Sub

                Public ReadOnly Property Title As String
            End Class

            Public Class BasePerson
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
End namespace