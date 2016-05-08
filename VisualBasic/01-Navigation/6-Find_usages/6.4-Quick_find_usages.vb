Namespace JetBrains.ReSharper.Koans.Navigation
    ' Quick Find Usages
    '
    ' Displays popup menu of usages in current file
    '
    ' Alt+Shift+F12 (VS)
    ' Ctrl+Alt+F7 (IntelliJ)

    Public Class QuickFindUsages
        Private Const MinValue As Double = -3.5
        Private Const MaxValue As Double = 3.5

        Public Function Adjust(original As Double, delta As Double) As Double
            ' 1. Place the caret on newValue And invoke Quick Find Usages
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