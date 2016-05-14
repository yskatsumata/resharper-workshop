Namespace JetBrains.ReSharper.Koans.Editing
    Public Class SelectingCode
        ' Extend/Shrink selection
        '
        ' Ctrl+Alt+Right And Ctrl+Alt+Left (VS)
        ' Ctrl+W And Shift+Ctrl+W
        '
        ' Select block
        '
        ' Ctrl+Shift+[

        Public Sub ExtendAndShrinkSelection()
            ' 1. Place the caret inside "importanValue" And expand selection
            '    Expand selection again to select the whole line
            '    Expand selection again to select the body of the method
            '    Expand selection again to select the whole method
            '    Expand selection again to select the whole class
            '    Expand selection again to select the whole namespace
            '    Expand selection again to select the whole file
            ' 2. Place the caret inside "importantValue" And expand selection a couple of times
            '    Shrink selection to reduce the selection back to what it was
            Dim importantValue = 32
            If importantValue > 42 Then
                Try
                    ' 3. Place the caret on WriteLine And repeatedly Extend And Shrink selection
                    Console.WriteLine("Hello")
                Catch e As Exception
                    Console.WriteLine(e)
                End Try
            End If
        End Sub

        ' 4. Go to ReSharper → Options → Environment → Editor → Editor Behaviour
        '    Tick CamelHumps on
        '    Place the caret inside the method name And Extend And Shrink selection
        '    (Also, with CamelHumps on, try Ctrl+Left And Ctrl+Right navigation inside the method name)
        Public Sub ExtendAndShrinkSelectionWithCamelHumps()
            Dim importantValue = 32
            If importantValue > 42 Then
                Try
                    Console.WriteLine("Hello")
                Catch e As Exception
                    Console.WriteLine(e)
                End Try
            End If
        End Sub

        ' 5. Place caret anywhere within method And invoke Select Block repeatedly
        Public Sub SelectBlock()
            Dim importantValue = 32
            If (importantValue > 42) Then
                Try
                    Console.WriteLine("Hello")
                Catch e As Exception
                    Console.WriteLine(e)
                End Try
            End If
        End Sub
    End Class
End Namespace