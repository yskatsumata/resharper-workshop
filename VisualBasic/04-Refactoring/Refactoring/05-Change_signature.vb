Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Change Signature
    '
    ' Update a method signature, adding, removing Or reordering parameters
    '
    ' Ctrl+R, S (VS)
    ' Ctrl+F6 (IntelliJ)

    Public Class ChangeSignature
        ' 1. Change method signature
        '    Place text caret on Method And invoke Change Signature
        '    In dialog, change name, return type And parameters
        '    Can add, remove, reorder parameters, change type And modifier (ref, out)
        '    Add an int parameter called "iq". Click next
        '    ReSharper prompts how to handle the New parameter in calling code
        '    Can leave code non-compilable, use a default value (0), use a specific value
        '      Or resolve with call tree
        ' 1a. Select resolve with call tree
        '     Refactoring tool window opens showing CallMethod usage And three options
        '       user edit, create field "iq", create parameter "iq" in CallMethod
        '     Selecting any of these options updates the calling code
        '     Can uncheck And select other option
        '     Close tool window when done
        Public Sub Method(name As String, age As Integer)
        End Sub

        Public Sub CallMethod()
            Method("Deborah", 32)
        End Sub
    End Class

    Public Class ApplyChangeSignatureRefactoring
        ' 2. Apply Change Signature refactoring, after change
        '    MANUALLY add a parameter, ReSharper highlights signature with dotted line
        '    Alt+Enter And select Apply Change Signature Refactoring
        '    ReSharper displays dialog with visualisation of the change
        Public Sub AddParameterMethod(name As String, age As Integer)
        End Sub

        ' 3. Apply Change Signature refactoring, after change
        '    MANUALLY reorder the parameters (Ctrl+Shift+Alt+Left/Right)
        '    ReSharper highlights signature with dotted line
        '    Alt+Enter And select Apply Change Signature Refactoring
        '    ReSharper displays dialog with visualisation of the change
        Public Sub ReorderMethod(name As String, age As Integer)
        End Sub

        Public Sub CallMethods()
            AddParameterMethod("Deborah", 32)
            ReorderMethod("Deborah", 32)
        End Sub
    End Class
End Namespace