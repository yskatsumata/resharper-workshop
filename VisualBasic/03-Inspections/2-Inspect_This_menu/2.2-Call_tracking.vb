Namespace JetBrains.ReSharper.Koans.Inspections
    ' Inspect This menu - Call tracking
    '
    ' View incoming And outgoing calls for methods
    '
    ' Ctrl+Shift+Alt+A (VS/IntelliJ)

    Public Class CallTracking
        ' 1. Show all calls made by MethodOne
        '    Place caret on MethodOne And Invoke Inspect This
        '    Select Outgoing Calls
        '    Results are displayed in a New Inspection Window
        '    Expanding the tree dives deeper into the call stack
        '    Expand the tree down to MethodFive to see the methods called there
        Public Sub MethodOne()
            MethodTwo()
        End Sub

        Public Sub MethodTwo()
            MethodThree()
            MethodThree()
        End Sub

        Public Sub MethodThree()
            MethodFive()
            MethodSix()
        End Sub

        Public Sub MethodFour()
            MethodFive()
            MethodSix()
        End Sub

        ' 2. Show all calls made to MethodFive
        '    Place the caret on MethodFive
        '    Invoke Incoming Calls
        '    Results are displayed in a New Inspection Window
        '    Expanding the tree walks further up the call stack
        '    Expand the tree down to MethodFive to see the methods called there
        '
        ' 3. Enable the preview pane in the results window
        Public Sub MethodFive()
            Console.WriteLine()
            Console.Out.WriteLine()
        End Sub

        Public Sub MethodSix()
            Console.WriteLine()
            Console.Out.WriteLine()
        End Sub
    End Class
End Namespace