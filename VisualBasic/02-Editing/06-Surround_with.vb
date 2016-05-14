Namespace JetBrains.ReSharper.Koans.Editing
    ' Surround With
    '
    ' Replace selection with text that includes current selection
    '
    ' Ctrl+E, U (VS)
    ' Ctrl+Alt+J (IntelliJ)
    ' Alt+Enter
    '
    ' See also Live Templates

    Public Class SurroundWith
        Public Sub SurroundSingleLineWithTryCatch()
            ' 1. Place the caret on the following line
            '    Invoke Surround With
            '    Select If..Else
            '    Edit the hotspot And hit tab to complete
            Console.WriteLine("This might throw")
        End Sub

        Public Sub SurroundMultipleLinesWithTryCatch()
            ' 2. Select the following lines
            '    Invoke Surround with
            '    Select If..Else
            '    Edit the hotspot And hit tab to complete
            Console.WriteLine("Hello")
            Console.WriteLine("World")
        End Sub

        Public Sub SurroundWithContextAction()
            ' 3. Select the Console.WriteLine statement
            '    Invoke Surrond With by using Alt+Enter
            '    Select { }
            '    (# Not supported for VB.NET?)
            If True Then
                Console.WriteLine("Hello world")
            End If
        End Sub
    End Class
End Namespace