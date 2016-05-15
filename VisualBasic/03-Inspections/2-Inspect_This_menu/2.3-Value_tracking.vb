Imports System.Windows.Input

Namespace JetBrains.ReSharper.Koans.Inspections
    ' Inspect This - Value Tracking
    ' (# Not supported for VB.NET?)
    '
    ' Follow a value between calls
    '
    ' Ctrl+Shift+Alt+A (VS/IntelliJ)
    Public Class ValueTracking

        ' 1. Find where the "value" parameter Is eventually used
        '    Place the caret on the value parameter
        '    Invoke Inspect This. Select Value Destination
        '    The results are shown in a New window
        '    The initial results show the usages in MethodOne
        '    Expanding the tree shows the usages in called methods
        '    Drill down the call stack, through lambda calls And properties
        '    Find where the value Is eventually used
        Public Sub MethodOne(value As Integer)
            If value Mod 2 = 0 Then
                'MethodTwo(()=> value)
                MethodTwo(Function() value)
            Else
                MethodThree(New HelpfulClass(value))
            End If
        End Sub

        Public Class HelpfulClass
            Public ReadOnly Property Value As Integer

            Public Sub New(value As Integer)
                Me.Value = value
            End Sub
        End Class

        Public Sub MethodTwo(newValue As Func(Of Integer))
            MethodThree(New HelpfulClass(newValue()))
        End Sub

        Private Sub MethodThree(changedValue As HelpfulClass)
            MethodFour(changedValue.Value)
        End Sub

        Private Sub MethodFour(anotherValue As Integer)
            MethodFive(anotherValue)
        End Sub

        Private Sub MethodFive(finalValue As Integer)
            ' 2. Find where finalValue came from
            '    Place the caret on finalValue below
            '    Invoke Inspect This And select Value Origin
            '    The results are shown in a New window
            '    Expanding the tree will walk up the call stack to find the origin of the value
            '
            ' 3. Display the preview pane in the results window
            Console.WriteLine(finalValue)
        End Sub
    End Class
End Namespace