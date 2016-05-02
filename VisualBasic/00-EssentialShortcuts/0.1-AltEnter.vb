Namespace EssentialShortcuts
    ' Alt+Enter
    ' 
    ' Used to apply quick fixes to inspections ("squigglies"), Or apply
    ' context specific actions, depending on location of text caret
    ' 
    ' Also allows searching And applying all ReSharper commands direct
    ' from the menu.
    ' 
    ' Icon Is displayed in gutter margin on left of editor, e.g. yellow
    ' lightbulb to fix warning, red light bulb to fix error, hammer to
    ' apply a context action, etc.

    ' 1. Apply QuickFix for an inspection
    '    The class doesn't match ReSharper's naming style
    '    Place text caret on "squiggly". Note the lightbulb in the margin on the left
    '    Click the light bulb, Or hit "Alt+Enter"
    '    Select "Rename to 'BadlyNamedClass'" to fix
    ' 
    ' (More on inspections in section 3)
    Public Class badlyNamedClass
    End Class

    Public Class ContextAction
        Public Shared Function FormatString(arg As String) As String

            ' 2. Apply context action
            '    Place text caret on "arg"
            '    Note the hammer action - a context action is available (no squiggly!)
            '    Hit Alt+Enter, select "To String.Format invocation"
            Return "Hello" + arg + "World"
        End Function
    End Class

    ' 3. Go to action
    '    Place text caret on class name below
    '    Alt+Enter, note magnifying glass
    '    Click magnifying glass, start typing "rename"
    '    Or, just start typing "rename" from menu
    '    Filters ReSharper commands and applies
    Public Class GoToAction
    End Class
End Namespace