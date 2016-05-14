Namespace JetBrains.ReSharper.Koans.Editing
    ' Toggle line comment
    '
    ' Ctrl+Alt+/ (VS)
    ' Ctrl+/ (IntelliJ)

    ' Toggle block comment
    '
    ' Ctrl+Shift+/ (VS + IntelliJ)

    ' 1. Toggle comment on single line
    '    Place caret on line below, press Ctrl+Alt+/
    Public Class SimpleClass1
    End Class

    ' 2. Toggle comment on multiple lines
    '    Select both lines, invoke Toggle line comment
    '    Toggle line comment to uncomment again
    Public Class SimpleClass2
    End Class

    ' 3. Toggle block comment
    '    Inserts block comment at text caret location
    '    Toggle removes it again
    Public Class SimpleClass3
    End Class

    ' 4. Comment selection with block comment
    '    Select some text, invoke block comment
    '    Only creates block comment, doesn't remove
    Public Class SimpleClass4
    End Class
End Namespace
