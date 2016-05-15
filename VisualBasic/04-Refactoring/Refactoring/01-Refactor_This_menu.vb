Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Refactor This menu
    '
    ' Display a contextual menu of refactorings available at the current location
    '
    ' Ctrl+Shift+R

    ' 1. Refactor This on type definition, method, property, field, parameter, variable, etc.
    '    Note different options on each code element
    '    Various refactorings shown in more detail in rest of section
    Public Class Class1 ' <- Refactor This On Class name
        ' Refactor This on field
        Public ReadOnly Property field as Integer

        ' Refactor This on property
        Public Property SampleProperty As String

        ' Refactor This on method, parameters
        Public Sub Method(parameter1 As String, parameter2 As Integer)
            ' Refactor This on variable
            Dim variable = parameter1
            Console.WriteLine(variable)
        End Sub
    End Class
End Namespace