Imports System
Imports System.Collections.Generic

Namespace JetBrains.ReSharper.Koans.Navigation
    ' # Not supported for VB.NET?
    '
    ' Navigate To menu
    '
    ' Displays a contextual menu of options you can use to navigate to from
    ' your current location
    '
    ' Very useful way of navigating without having to learn ALL of the shortcuts!
    '
    ' Alt+` (VS)
    ' Ctrl+Shift+G (IntelliJ)


    ' 1. When caret is on a control flow keyword
    Public Class NavigateToControlFlowKeyword
        Public Sub ControlFlowWithForStatement()
            For i As Integer = 0 To Children.Count
                Dim child = Children(i)

                ' a) Place the caret on "continue". Navigate To → Control Flow Target
                '    takes the caret to the i++ in the for declaration
                If ShouldSkipChild(child) Then Continue For

                ' b) Place the caret on "Exit For". Navigate To → Control Flow Target
                '    takes the caret to the next statement after the loop
                If ShouldStop(child) Then Exit For

                ' c) Place the caret on "return". Navigate To → Control Flow Target
                '    takes the caret to the closing brace of the function
                If ShouldQuit(child) Then Return
            Next

            Console.WriteLine("Finished loop")
        End Sub

        Public Sub ControlFlowWithSwitchStatement(size As Size)

            Select Case size
                Case Size.Large
                ' d) Place the caret on "break". Navigate To → Control Flow Target
                '    takes the caret to the first statement after the switch

                Case Size.Medium
                    ' e) Place the caret on "return". Navigate To → Control Flow Target
                    '    takes the caret to the closing brace of the function
                    Return

                Case Size.Small
                    ' e) Place the caret on "throw". Navigate To → Control Flow Target
                    '    takes the caret to the closing brace of the function
                    Throw New ArgumentOutOfRangeException("size")
            End Select

            Console.WriteLine("Finished switch")
        End Sub

#Region "Implementation details"

        Private ReadOnly Property Children As IList(Of String)
            Get
                Return New List(Of String)
            End Get
        End Property

        Private Function ShouldSkipChild(child As String) As Boolean
            Return child = "Barry"
        End Function

        Private Function ShouldStop(child As String) As Boolean
            Return child = "Rocky"
        End Function

        Private Function ShouldQuit(child As String) As Boolean
            Return child = "Damien"
        End Function

        Public Enum Size
            Large
            Medium
            Small
        End Enum

#End Region
    End Class
End Namespace