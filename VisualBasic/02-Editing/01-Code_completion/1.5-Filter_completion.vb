Namespace JetBrains.ReSharper.Koans.Editing
    ' Filtered Completion
    '
    ' Filter completion lists, including Or excluding by item kind (class, method, etc.)
    ' And visibility (public, protected, etc.)
    '
    ' Available in automatic, basic, import And smart completion
    '
    ' Ctrl+Space (basic completion)

    Public Class FilterCompletion
        ' 1. Invoke completion here
        '    ReSharper shows keywords And types
        '    Filter by namespace - Alt+N Or Alt+I, N to ignore namespaces
        '    Filter by classes - Alt+C Or Alt+I, C to ignore classes
        '    Filter by interfaces - Alt+F Or Alt+I, F to ignore classes
        '    Filter by structs - Alt+S Or Alt+I, S to ignore classes
        '    Filter by enums - Alt+U Or Alt+I, U to ignore enums
        '    Filter by delegates - Alt+D Or Alt+I, D to ignore delegates
        '    Filter by keywords - Alt+K Or Alt+I, K to ignore keywords





        Public Sub Method()
            ' 2. Uncomment "Me." And invoke completion after the dot
            '    Filter by field - Alt+F Or Alt+I, F to ignore fields
            '    Filter by property - Alt+P Or Alt+I, P to ignore fields
            '    Filter by method - Alt+M Or Alt+I, M to ignore fields
            '    Filter by public symbol - Alt+1 Or Alt+I, 1 to ignore public symbols
            '    Filter by protected symbol - Alt+3 Or Alt+I, 3 to ignore protected symbols
            '    Filter by private symbol - Alt+4 Or Alt+I, 4 to ignore private symbols
            'Me.
        End Sub

#Region "Implementation details"

        Public Property Name As String
        Public ReadOnly Property Age As Integer

#End Region
    End Class
End Namespace