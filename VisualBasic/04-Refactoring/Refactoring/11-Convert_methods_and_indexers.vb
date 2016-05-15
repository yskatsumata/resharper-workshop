Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Method to Indexer
    '
    ' No shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    ' Convert Indexer to Method(s)
    '
    ' Converts an indexer property to a getter And/Or setter method(s)
    '
    ' No shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R

    Public Class ConvertMethodToIndexer
        Private ReadOnly lookup As IDictionary(Of String, String) = New Dictionary(Of String, String)()

        ' 1. Convert method to indexer
        '    Method must have single parameter
        '    Place text caret on method definition
        '    Invoke Convert Method To Indexer
        '    ReSharper suggests name
        '    Confirm to convert
        Private Function GetValueByKey(key As String) As String
            Return CType(IIf(lookup.ContainsKey(key), lookup(key), String.Empty), String)
        End Function

        ' 2. Convert method to multi-dimensional indexer
        '    Method must have multiple parameters
        '    Place text caret on method definition
        '    Invoke Convert Method To Indexer
        '    ReSharper suggests name
        '    Confirm to convert
        Private Function GetValueByKey(key As String, [default] As String) As String
            Return CType(IIf(lookup.ContainsKey(key), lookup(key), [default]), String)
        End Function

        Public Sub OutputName()
            Console.WriteLine(GetValueByKey("foo"))
            Console.WriteLine(GetValueByKey("foo", "default value"))
        End Sub
    End Class

    Public Class ConvertIndexerToMethod
        Private ReadOnly lookup As IDictionary(Of String, String) = New Dictionary(Of String, String)()

        ' 3. Convert readonly indexer to method
        '    Place text caret on "Item"
        '    Invoke Convert Indexer to Method(s)
        '    Create getter method
        Default Public ReadOnly Property Item(index As Integer) As String
            Get
                Return CType(IIf(lookup.ContainsKey(index.ToString()), lookup(index.ToString()), String.Empty), String)
            End Get
        End Property

        ' 3. Convert read/write indexer to method
        '    Place text caret on "Item"
        '    Invoke Convert Indexer to Method(s)
        '    Create getter And setter method
        Default Public Property Item(index As String) As String
            Get
                Return CType(IIf(lookup.ContainsKey(index), lookup(index), String.Empty), String)
            End Get
            Set(value As String)
                lookup(index) = value
            End Set
        End Property
    End Class
End Namespace