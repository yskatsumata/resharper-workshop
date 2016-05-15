Imports JetBrains.ReSharper.Koans.Refactoring.ExampleCode

Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Rename
    '
    ' Renames an element And all usages of it
    '
    ' Ctrl+R, R (VS)
    ' F2 (IntelliJ)

    Public Class RenameType
        Public Shared Function Create() As RenameType
            ' 1. Rename a type
            '    Place text caret on any usage of type
            '    Invoke rename refactoring And rename
            Return New RenameType()
        End Function
    End Class

    ' 2. Rename method, property, variable, field, parameter
    '    Place text caret on method, property, variable, field Or parameter name
    '    Invoke rename refactoring And rename
    Public Class RenameMember
        Private Const Value As Integer = 42

        Public Property Name As String

        Public Sub Output(args As String())
            Console.WriteLine(Name)
            Console.WriteLine(Value)
            Console.WriteLine(args)
        End Sub
    End Class

    Public Class RenameAcrossFiles
        Public Sub Method()
            ' 2. Rename across files
            '    Place text caret on type name Or method name
            '    Invoke rename refactoring
            '    Symbols in other file are updated (navigate to check)
            RenameInAnotherFile.StaticMethod()
        End Sub

        Public Sub Method2()
            RenameInAnotherFile.StaticMethod()
        End Sub
    End Class

    ' 3. Undo local rename
    '    If rename Is in single file, normal undo (Ctrl+Z) will rename back
    Public Class UndoLocalRename
        Const Message As String = "hello world"

        Public Shared Sub Method()
            Console.WriteLine(Message)
        End Sub
    End Class

    ' 4. Undo rename across files
    '    By default, ReSharper does Not open modified files, so Ctrl+Z does Not work
    '    Either make ReSharper open the files, Or simply rename back
    Public Class UndoRenameAcrossFiles
        Public Sub Method()
            ' 4a. Place text caret on type name Or method name
            '     Invoke rename refactoring
            '     On first page, check "To enable undo, open all files with changes after editing"
            '     Rename symbol
            '     The other file Is opened, And marked modified
            '     Ctrl+Z will undo the change across all files
            RenameInYetAnotherFile.StaticMethod()
        End Sub

        Public Sub Method2()
            ' 4b. Place text caret on type name Or method name
            '     Make sure RenameInAnotherFile.vb Is closed
            '     Invoke rename refactoring
            '     On first page, UNCHECK "To enable undo, open all files with changes after editing"
            '     Rename symbol
            '     The other file Is Not opened, but modified
            '     Ctrl+Z will undo the local change, but produce uncompilable code
            '     Redo the local change (Ctrl+Y)
            '     Perform rename refactoring back to original name
            RenameInAnotherAnotherFile.StaticMethod()
        End Sub
    End Class

    ' 5. Renaming in string literals And comments
    '    Place text caret on type definition (Not in comment Or string literal)
    '    Invoke rename refactoring And rename
    '    Note second page asking confirmation to rename in string literals And comments
    Public Class RenameInStringLiteral
        ' Type name in comment: RenameInStringLiteral
        Public Const Message As String = "Type name in string literal: RenameInStringLiteral"
    End Class

    Public Class InlineRename
        Public Sub Method()
            ' 6. Inline renaming
            '    If the scope of the change Is local, the rename can be performed inline
            '    Place text caret on message
            '    Invoke rename refactoring
            '    Refactoring Is applied inline, with suggestions
            Const message As String = "Hello world"
            Console.WriteLine(message)
        End Sub
    End Class

    Public Class RenameRelatedSymbols
        Private ReadOnly _renameParameter As RenameParameter

        ' 7. Rename related symbols
        '    When renaming a type that Is assigned to a variable, field Or parameter, ReSharper prompts to rename the assigned to symbol
        '    Place text caret on RenameParameter
        '    Invoke rename refactoring
        '    Type Is renamed, ReSharper prompts to rename the parameter And the field
        Public Sub New(renameParameter As RenameParameter)
            _renameParameter = renameParameter
        End Sub

        Public Class RenameParameter
        End Class
    End Class

    ' 7a. Rename related symbols in derived classes
    '     Place text caret on arg
    '     Invoke rename refactoring And rename parameter
    '     ReSharper prompts to rename the same parameter in the derived class
    Public Interface IThing
        Sub Method(arg As String)
    End Interface

    Public Class Thing
        Implements IThing
        Public Sub Method(arg As String) Implements IThing.Method
        End Sub
    End Class


    ' 8. Apply rename refactoring, after change
    '    After changing the name of a symbol manually, ReSharper can apply the rename refactoring
    '    Place text caret on ApplyRenameRefactoring
    '    MANUALLY change the type name (do Not invoke refactoring)
    '    Note the dotted line around the type name
    '    Alt+Enter And select "Apply rename refactoring"
    Public Class ApplyRenameRefactoring
        Public Shared Function Create() As ApplyRenameRefactoring
            Return New ApplyRenameRefactoring()
        End Function

        ' 8a. Cancel apply rename refactor prompt with Escape
        '     Place text caret on AutoProperty
        '     MANUALLY change the property name (do Not invoke refactoring)
        '     Note the dotted line around the propert name
        '     Hit Escape to cancel the dotted line
        Public Property Name As String
    End Class
End Namespace