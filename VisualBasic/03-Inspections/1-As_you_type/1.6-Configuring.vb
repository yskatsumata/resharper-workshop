Namespace JetBrains.ReSharper.Koans.Inspections._1_As_you_type
    Public Class ConfiguringHighlights
        Public Sub WhyIsReSharperSuggestingThis(values As IEnumerable(Of String))
            ' 1. Get advice on why ReSharper Is providing a highlight
            '    Alt+Enter on one of the highlights on 'values'
            '    Expand the "Inspection 'Possible multiple enumeration of IEnumerable'" submenu
            '    Select "Why is ReSharper suggesting this?"
            '    A web browser Is opened And you are navigated to a page on
            '    JetBrains site with an explanation for this setting

            Dim count = values.Count()
            For Each value In values
                Console.WriteLine(value)
            Next
        End Sub

        Public Sub IgnoreHighlightsWithComments()
            ' 2. Disable highlights with comments
            '    Alt+Enter on the List<string> highlight below
            '    Expand the "Inspection 'Use implicitly typed variable declaration (evident)'" submenu
            '    Select Disable once with comment, Or expand menu for more options
            '    ReSharper adds comments And the warning Is suppressed

            Dim names As List(Of String) = New List(Of String)()

            ' 2a. Disable highlights with #pragma
            '     Alt+Enter on the Foo highlight below
            '     Expand the "Compiler warning 'BC40000: Use obsolete member'" option
            '     Select Disable once with comment, Or expand menu for more options
            '     ReSharper adds comment line And the warning Is suppressed
            Console.WriteLine(Foo)
        End Sub

        Public Sub ConfigureHighlights()

            ' 3. Alt+Enter on the List(Of String) highlight
            '    Expand the "Inspection 'Use implicitly typed variable declaration (evident)'" submenu
            '    Select Configure inspection severity
            '    In the dialog, change the severity to error, warning, suggestion Or hint
            '    Note also "Do not show" to disable the highlight completely
            Dim names As List(Of String) = New List(Of String)()

            ' 4. Restore the highlight from the options dialog
            '    Go to ReSharper → Options
            '    Search for 'Use implicitly typed variable declaration (evident)' in the options search box
            '    Reset the severity to the default using the default button


            ' 5. Browse the available inspections in the options dialog
            '    Go to ReSharper → Options → Inspection Severity
            '    Browse by language Or category
        End Sub

        Public Sub FixMultipleHighlights()

            ' 6. Alt+Enter on the List(Of String) highlight
            '    Enter on the "To implicitly typed" item will fix the first highlight
            '    Expand the sub menu And select "To implicitly typed variables in file"
            Dim names As List(Of String) = New List(Of String)()
            Dim addresses As List(Of String) = New List(Of String)()
            Dim friends As List(Of String) = New List(Of String)()
        End Sub

#Region "implementation details"

        <Obsolete("Do not use")>
        Public Property Foo As String

#End Region
    End Class
End Namespace
