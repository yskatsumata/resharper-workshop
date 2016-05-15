Imports System.Windows.Forms

Namespace JetBrains.ReSharper.Koans.Refactoring
    ' Introduce Field
    '
    ' Create a field in the current class from selection
    '
    ' Ctrl+R, F (VS)
    ' Ctrl+Alt+D (IntelliJ)

    ' Inline Field
    '
    ' Replaces field usage with the contents of the field
    '
    ' Ctrl+R, I (VS)
    ' Ctrl+Alt+N (IntelliJ)

    Public Class IntroduceAndInlineField
        Public Sub InitialiseForm()
            ' 1. Introduce Field
            '    Place the caret on button And invoke Introduce Field
            '    Choose name And where to initialise field - current location, field initialiser Or constructor
            '    Choose visibility (private, public, etc.) And if to make static/readonly
            Dim form = New Form()
            Dim button = New Button()
            form.Controls.Add(button)
        End Sub

        Public Sub InitialiseForm2()
            ' 2. Introduce Field for multiple instances
            '    Select "new Button()" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            '    Invoke Introduce Field
            '    ReSharper highlights all usages across ALL methods, prompts for one usage, all across methods Or all in this method
            '    Choose name And where to initialise field - current location, field initialiser Or constructor
            '    Choose visibility (private, public, etc.) And if to make static/readonly
            Dim form = New Form()
            form.Controls.Add(New Button())
            form.Controls.Add(New Button())
            form.Controls.Add(New Button())
        End Sub

        Public Sub IntroduceConstant()
            ' 3. Introduce Constant
            '    Select the "Hello world" string literal
            '    Invoke Introduce Field
            '    Select Introduce Constant on dialog (Alt+I)
            Console.WriteLine("Hello world")
        End Sub

        Private Const MyField As Integer = 23

        Public Sub InlineField()
            ' 4. Inline Field
            '    Place caret on MyField
            '    Invoke Inline Field
            Console.WriteLine(MyField)
        End Sub

        Private Const MyOtherField As Integer = 23

        Public Sub InlineFieldOnMultipleInstances()
            ' 5. Inline Field
            '    Place caret on MyOtherField
            '    Invoke Inline Field
            Console.WriteLine(MyOtherField)
            Console.WriteLine(MyOtherField)
            Console.WriteLine(MyOtherField)
        End Sub
    End Class
End Namespace