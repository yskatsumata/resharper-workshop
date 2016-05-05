Namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
    Public Interface ICustomer
        ReadOnly Property Id As String
        ReadOnly Property Name As String
        ReadOnly Property PercentageDiscount As Integer
    End Interface

    Public Class Customer
        Implements ICustomer

        Public Sub New(id As String, name As String)
            Me.Id = id
            Me.Name = name
            Me.PercentageDiscount = 0
        End Sub

        Public ReadOnly Property Id As String Implements ICustomer.Id
        Public ReadOnly Property Name As String Implements ICustomer.Name
        Public Overridable ReadOnly Property PercentageDiscount As Integer Implements ICustomer.PercentageDiscount
    End Class

    Public Class SilverCustomer
        Inherits Customer

        Public Sub New(id As String, name As String)
            MyBase.New(id, name)
        End Sub

        Public Overrides ReadOnly Property PercentageDiscount As Integer
            Get
                Return 10
            End Get
        End Property
    End Class

    Public Class GoldCustomer
        Inherits Customer

        Public Sub New(id As String, name As String)
            MyBase.New(id, name)
        End Sub

        Public Overrides ReadOnly Property PercentageDiscount As Integer
            Get
                Return 25
            End Get
        End Property
    End Class
End Namespace