Namespace JetBrains.ReSharper.Koans.Inspections
    ' Context actions
    '
    ' Similar to quick fixes, but tied to a code block, Not a highlight
    '
    ' Alt+Enter whenever hammer gutter icon Is visible
    '
    ' NOTE: ReSharper has HUNDREDS Of context actions. This file provides a very small sample

    Public Class ContextActions
        ' 1. Place caret on public below
        '    Note the hovering "hammer" icon. This indicates a context action Is available
        '    Alt+Enter And select "To Private" to make the method private
        Public Sub MakePublicMethodPrivate()
        End Sub

        ' 2. Apply context action
        '    Place text caret on "arg"
        '    Note the hammer action - a context action Is available (no squiggly!)
        '    Hit Alt+Enter, select "To String.Format invocation"
        Public Function ConcatenatingString(arg As String) As String
            Return "Hello" + arg + "World"
        End Function

        ' 3. Context actions can be configured in the ReSharper → Options Dialog
        '    Configured per language. Select Code Editing → C# → Context Actions,
        '    Or VB.Net, JavaScript, XML, Build Scripts, etc
    End Class
End Namespace