Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Convert Property to Auto Property
    '
    ' Refactoring has no keyboard shortcut. Invoke via Refactor This menu
    ' Ctrl+Shift+R
    '
    ' Also available as Quick Fix via Alt+Enter

    Public Class ConvertPropertyToAutoProperty
        Private backingStore As String
        Private backingStore2 As String
        Private backingStore3 As String

        ' 1. Convert to Auto Property with refactoring
        '    Place text caret on property definition
        '    Invoke Refactor This menu → Convert Property to Auto-Property
        Public Property PropertyWithBackingStore As String
            Get
                Return backingStore
            End Get
            Set(value As String)
                backingStore = value
            End Set
        End Property

        ' 2. Convert to Auto Property with Alt+Enter
        '    Note shown as suggestion
        '    Place text caret on property definition
        '    Alt+Enter And select Convert to auto-property
        Public Property PropertyWithBackingStore2 As String
            Get
                Return backingStore2
            End Get
            Set(value As String)
                backingStore2 = value
            End Set
        End Property

        ' 2. Convert to read-only Auto Property with Alt+Enter
        '    Note shown as hint
        '    Place text caret on property definition
        '    Alt+Enter And select Convert to auto-property
        Public ReadOnly Property PropertyWithBackingStore3 As String
            Get
                Return backingStore3
            End Get
        End Property
    End Class
End Namespace