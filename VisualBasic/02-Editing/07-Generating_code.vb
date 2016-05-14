Namespace JetBrains.ReSharper.Koans.Editing
    ' Generate Code menu
    '
    ' Displays a contextual menu of options for generating code available at the current location
    '
    ' Alt+Insert (in text editor)
    '
    ' (Alt+Insert on Solution Explorer invokes Generate menu for File Templates,
    '  see Live Templates section)

    Public Class InsertConstructor
        ' 1. Insert constructor
        '    Place caret inside class
        '    Invoke Generate Code And select constructor
        '    Caret Is placed ready to enter parameters


    End Class

    Public Class InsertConstructorWithParameters
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Age As Integer

        ' 1. Insert constructor
        '    Place caret inside class
        '    Invoke Generate Code And select constructor
        '    Select properties to generate And click OK


    End Class

    Public Class GenerateOverridingMembers
        Inherits BaseClass
        ' 2. Generate overriding members
        '    Place caret inside class
        '    Invoke Generate And select Overriding Members
        '    Select members to implement And click OK


    End Class

    Public Class GeneateEquality
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Age As Integer

        ' 3. Generate equality methods
        '    Place caret inside class
        '    Invoke Generate And select Equality members
        '    Select members to be compared for equality, And optionally override equals operators
        '    Generates Equals + GetHashCode


    End Class


    Public Class GenerateDelegatingMembers
        Private ReadOnly service As IService

        Public Sub New(service As IService)
            Me.service = service
        End Sub

        ' 4. Generate delegating members
        '    Given a field of a given type, create members to delegate to that inner instance
        '    Place caret inside class
        '    Invoke Generate And select Delegating members
        '    Select the members to delegate
        '    If all members are implemented, this class can then implement IService


    End Class

    Public Class GenerateFromUsage
        ' 5. Generate from usage
        '    Alt+Enter on missing symbols to generate them


        ' 5.1 Generate variable
        '     Uncomment the Console.WriteLine statement message will be undefined
        '     Alt+Enter on message to get option to create local variable
        '     Specify type, hit tab And caret Is moved to allow for setting value 
        '     (# Not supported for VB.NET? Can't select variable type)
        Public Sub GenerateVariable()
            'Console.WriteLine(msg)
        End Sub

        ' 5.2 Generate method
        '     Uncomment following statements. The GetMessage method will be undefined
        '     Alt+Enter on GetMessage to get option to create method
        '     ReSharper will infer return type And parameters
        Public Sub GenerateMethod()
'            Dim message as String = GetMessage(42)
'            Console.WriteLine(message)
        End Sub
        
        ' 5.3 Generate class (great for TDD!)
        '     Uncomment the following statements. The class will be undefined
        '     Alt+Enter on Processor to get option to create class
        '     ReSharper will create class + constructor
        '     Tab throw options 
        Public Sub GenerateClass()
'            Dim message = New Message()
'            Dim processor = New Processor(message)
'            Console.WriteLine(processor)
        End Sub
    End Class

    Public Class GenerateSwitchLabels
        Public Sub Method(day As DayOfWeek)
            ' 6. Generate switch labels
            '    Place text caret inside switch statement
            '    Alt+Enter And select Generate switch labels
            '    (# Not supported for VB.NET?)
            Select Case day
            End Select
        End Sub
    End Class

#Region "Implementation details"

    Public Class BaseClass
        Public Overridable Sub VirtualMethod()
        End Sub

        Public Overridable ReadOnly Property VirtualProperty() As String
            Get
                Return "hello"
            End Get
        End Property
    End Class

    Public Interface IService
        Sub SayHello()
        Sub Shout()
        Function Choose(options As String) As Integer
    End Interface

    Public Class Message
        Public Property Id As String
        Public Property Body As String
    End Class

#End Region
End Namespace