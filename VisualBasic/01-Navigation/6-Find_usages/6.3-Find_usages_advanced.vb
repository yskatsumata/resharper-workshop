Namespace JetBrains.ReSharper.Koans.Navigation
    ' Find Usages advanced
    '
    ' Displays a dialog with search options
    '
    ' Ctrl+Shift+Alt+F12 (VS)
    ' Shift+Alt+F7 (IntelliJ)

    Public Class FindUsagesAdvanced
        ' 1. Look for textual occurrences of Singularity
        '    Should find these two comments - "Singularity" And the code below
        Public Property Singularity As String

        Public Sub PrintSingularity()
            Console.WriteLine(Singularity)
            Console.WriteLine("Singularity")
        End Sub

        ' 2. Look for textual occurrences of Navigation
        '    Should find lots of namespace usages
        '    b) Reduce scope to current file And try again
        Public Property Navigation As String

        ' 3. Look for all usages, including dynamic, of DynamicUsage
        '    Should find two usages in code + one textual
        Public Sub DynamicUsage(argument As String)
            If (argument = Nothing) Then Return

            Dim something = GetDynamicObject()
            something.DynamicUsage("sausages")

            ' Non-dynamic usage
            Me.DynamicUsage("hello")
        End Sub

        Private Function GetDynamicObject() As Object
            Return Me
        End Function
    End Class
End Namespace