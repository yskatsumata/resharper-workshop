Imports System.Runtime.CompilerServices

Namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
#Region "Implementation details"

    Public Interface ISimpleInterface
        Sub SayHello()
        Sub SayGoodbye()
    End Interface

    ' Navigate back (Ctrl+-)
    Public Class BaseClass
        Public Overridable Sub VirtualMethod()
        End Sub

        Public Overridable ReadOnly Property VirtualProperty As String
            Get
                Return "hello"
            End Get
        End Property
    End Class

    Public Module BaseClassExtensions
        ' Navigate back (Ctrl+-)
        ' Note also works as extension method for DerivedClass
        <Extension>
        Public Sub ExtensionMethodForBaseClass(self As BaseClass)
            ' ...
        End Sub

        ' Navigate back (Ctrl+-)
        ' Note also works when navigating from BaseClass
        Public Function MethodExposingDerivedClassAsReturnValue() As DerivedClass
            ' ...
            Return Nothing
        End Function
    End Module

    ' Navigate back (Ctrl+-)
    Public Class ReallyDerivedClass
        Inherits DerivedClass
    End Class

#End Region
End Namespace