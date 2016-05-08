Namespace JetBrains.ReSharper.Koans.Navigation
    ' Find Usages
    '
    ' Finds usages And displays in the Find Results window
    '
    ' Ctrl+K, Ctrl+R (VS)
    ' Alt+F7 (IntelliJ)

    Public Class FindUsages
        ' 1. Put the caret on ButtonText And Find Usages
        '    Note that ReSharper has found read And write usages
        '    It has also found usages of the type in a XAML control
        '    And has inferred a dynamic usage in the XAML control where no type Is specified
        ' 2. In the Find Results window, check out the right click And toolbar options
        '    Note the group by options, filtering by usage And merging usages on the same line
        '    Turn on code preview
        Public Property ButtonText As String

        ' Ensures ButtonText Is in the correct format
        Public sub CleanupText()
            ButtonText = ButtonText.Trim()
            ButtonText = ButtonText.ToLowerInvariant()
        End Sub
    End Class
End Namespace