Imports JetBrains.ReSharper.Koans.Navigation.ExampleCode

Namespace JetBrains.ReSharper.Koans.Navigation
    ' Navigate To menu
    '
    ' Displays a contextual menu of options you can use to navigate to from
    ' your current location
    '
    ' Very useful way of navigating without having to learn ALL of the shortcuts!
    '
    ' Alt+` (VS)
    ' Ctrl+Shift+G (IntelliJ)


    Public Class WhenCaretIsOnSymbol
        Public Sub NavigateToSymbolType()
            ' 1. When caret Is on a symbol
            '    Place caret on "stuff". Navigate To → Type of Symbol
            '    takes caret to declaration of BaseClass
            Dim stuff = New BaseClass()
        End Sub
    End Class
End Namespace