Namespace JetBrains.ReSharper.Koans.Navigation
    ' Navigate Back
    '
    ' Returns the caret to the last navigation point
    '
    ' Ctrl+- (minus)
    '
    Public Class NavigateBack
        Public Sub StartingPoint()
            Dim navigateTo = New NavigateTo()

            ' 1. Navigate to NavigateTo.Destination by Ctrl+Click or Go To Definition
            navigateTo.Destination()
        End Sub
    End Class

    Public Class NavigateTo
        Public Sub Destination()
            ' Now navigate back, using Visual Studio's Ctrl+- (minus)
        End Sub
    End Class
End Namespace