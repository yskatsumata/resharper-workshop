Imports System.Runtime.CompilerServices

Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Extension Method to Plain Static
    '
    ' No keyboard shortcut. Invoke via Refactor This
    ' Ctrl+Shift+R

    ' Convert Static Method to Extension Method
    '
    ' No keyboard shortcut. Invoke via Refactor This
    ' Ctrl+Shift+R

    Public Module ConvertStaticAndExtensionMethods
        ' 1. Convert extension method to plain static
        '    Place text caret on method name
        '    Invoke Refactor This → Extension Method to Plain Static
        '    Call site Is updated
        <Extension>
        Public Sub ExtensionMethod(target As Target, value As String)
        End Sub

        ' 1. Convert extension method to plain static
        '    Place text caret on method name
        '    Invoke Refactor This → Convert Static Method to Extension
        '    Call site Is updated
        Public Sub StaticMethod(target As Target, value As String)
        End Sub

        Public Sub Consumer()
            Dim target = New Target()
            target.ExtensionMethod("cheese")
            StaticMethod(target, "sandwich")
        End Sub

        Public Class Target
        End Class
    End Module
End Namespace