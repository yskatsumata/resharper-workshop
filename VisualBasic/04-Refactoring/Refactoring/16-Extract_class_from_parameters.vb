Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Extract Class From Parameters
    '
    ' Creates a class based on the parameters to a method, And creates it at call sites
    '
    ' No keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    Public Class ExtractClassFromParameters
        ' 1. Extract class from parameters
        '    Place text caret on method definition
        '    Invoke Refactor This → Extract Class From Parameters
        '    ReSharper prompts for options - name, class/struct, nested/top level
        '      And which parameters should be extracted
        Public Sub New(forename As String, surname As String, age As Integer)
        End Sub

        Public Shared Function Create(forename As String, surname As String, age As Integer) As ExtractClassFromParameters
            ' 2. Confirm call site has been updated to create parameter class
            Return New ExtractClassFromParameters(forename, surname, age)
        End Function
    End Class
End Namespace