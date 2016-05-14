Namespace JetBrains.ReSharper.Koans.Editing
    ' Rearrange Code
    '
    ' Move code elements up/down/left/right/in/out
    '
    ' Ctrl+Shift+Alt+Left/Right/Up/Down (VS + IntelliJ)

    Public Class RearrangingCode
        Public Sub RearrangeLines()
            ' 1. Place caret on one of the line below
            '    Use Ctrl+Shift+Alt+Up/Down to move the line up Or down
            Console.WriteLine("One")
            Console.WriteLine("Two")
            Console.WriteLine("Three")
            Console.WriteLine("Four")
            Console.WriteLine("Five")
        End Sub

        Public Sub RearrangeExpressionOrder()
            Dim value = 42
            Dim newValue = 34
            newValue += 1

            '(# Not supported for VB.NET?)
            ' 2. Place caret on newValue
            '    Use Ctrl+Shift+Alt+Left/Right to rearrange expression order
            value = newValue

            Console.WriteLine(value)
        End Sub

        Public Sub RearrangeParameterOrder()
            Const hello = "hello"
            Const world = "world"
            Const foo = "foo"
            Const bar = "bar"

            ' 3. Place caret on hello
            '    Use Ctrl+Shift+Alt+Left/Right to rearrange parameter order
            MethodWithParameters(hello, world, foo, bar)
        End Sub

        Public Sub RearrangeInAndOut()
            If True Then
                ' 4. Place caret on WriteLine
                '    Use Ctrl+Shift+Alt+Up/Down to rearrange within the if statement
                '    Use Ctrl+Shift+Alt+Left to move out of if statement
                '    Use Ctrl+Shift+Alt+Up/Down to move above And below if statement
                '    Use Ctrl+Shift+Alt+Right to move into the if statementS
                Console.WriteLine("Hello")
                Console.WriteLine("World")
            End If
        End Sub

        ' 5. Use Ctrl+Shift+Alt+Up/Down to rearrange comment
        Public Sub RearrangeComment()
            ' Move me
            Console.WriteLine("Hello")
            Console.WriteLine("World")
        End Sub

        Public Sub ExtendBlockWithGreedyBraces()
            ' 5. Place caret on outside of closing brace
            '    Use Ctrl+Shift+Alt+Down to move block to include next statement
            '    Use Ctrl+Shift+Alt+Up to move block to exclude current last statement
            If True Then
                Console.WriteLine("Hello")
            End If

            Console.WriteLine("World")
        End Sub

        Private Sub MethodWithParameters(p1 As String, p2 As String, p3 As String, p4 As String)
        End Sub
    End Class
End Namespace