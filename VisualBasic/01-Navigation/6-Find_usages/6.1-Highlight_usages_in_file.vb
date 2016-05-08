Namespace JetBrains.ReSharper.Koans.Navigation
    ' Highlight Usages in File
    '
    ' Shift+Alt+F11 (VS)
    ' Ctrl+Alt+F7 (IntelliJ)

    Public Class HighlightUsagesInFile
        Private Const MinValue As Double = -3.5
        Private Const MaxValue As Double = 3.5

        Public Function Adjust(original As Double, delta As Double) As Double
            ' 1. Place the caret on newValue And Highlight Usages in File
            '    Note the different colour highlights for read And write usage
            '    Note the highlights in the stripe on the right of the editor
            '    These highlights are clickable, And have tooltips
            '    Escape clears the highlight
            '    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
            '    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
            Dim newValue = original + delta

            If (newValue < MinValue) Then
                newValue = MinValue
            End If

            If (newValue > MaxValue) Then
                newValue = MaxValue
            End If

            Return newValue
        End Function
    End Class
End Namespace