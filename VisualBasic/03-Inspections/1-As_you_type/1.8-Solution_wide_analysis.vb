Namespace JetBrains.ReSharper.Koans.Inspections
    ' Solution Wide Analysis
    '
    ' Analyses whole solution. Can find multiple code issues, And highlights code that isn't used.
    ' Takes up additional resources, so disabled by default
    '
    ' Enable by right clicking circular indicator in the status bar
    '
    ' Navigate between highlights in files:
    '
    ' Shift+Alt+PageUp And Shift+Alt+PageDown (VS)
    ' Alt+F12 And Shift+Alt+F12 (IntelliJ)

    Public Class SolutionWideAnalysis
        ' 1. Enable solution wide analysis


        ' 2. Once complete, notice that this class And method are marked unused
        Public Sub UnusedMethod()
        End Sub

        ' 3. Navigate between warnings

        ' 4. Uncomment the failing code below
        '    Open the Solution Errors Window (ReSharper → Inspect → Solution Errors Window)
        '    Double click the error in the window to navigate back
        '    Hide errors with right click Or toolbar
        '    Show hidden errors with toolbar
        '    Comment code to fix errors again
        'Public Sub FailingCode()
        '    Dim i As Integer = "hello"

        '    UnusedMethod(undefinedVariable)

        '    Return New Exception()
        'End Sub
    End Class
End Namespace