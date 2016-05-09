Namespace JetBrains.ReSharper.Koans.Editing
    ' Double Completion
    '
    ' Invoking Basic, Import Or Smart Completion multiple times
    ' Provides more candidates by looking at members of the previous list of candidates

    Public Class DoubleCompletion
        Public Sub DoubleSmartCompletion()
            ' 1. Uncomment the following line
            '    Invoke Smart Completion at the end of the line
            '    Invoke Smart Completion again (it should say 2xSmart at the bottom of the window)
            '    Note that ReSharper Is now offering candidates from the return values of the first
            '      Smart Completion invocation (i.e. instance methods on string)
            'Dim s3 As String = Me.
        End Sub

        Public Sub DoubleImportCompletion()
            ' 2. Start typing Button
            '    Automatic Completion doesn't find anything
            '    Invoke Import Completion twice (it should say 2xImport at the bottom of the window)
            '    Import Completion should find Button in an assembly referenced by a project in the solution
            '    It can now add a reference to System.Windows.Forms.dll And import System.Windows.Forms.Button

            ' Button
        End Sub

        Public Sub DoubleAutomaticCompletion()
            ' 3. Since Automatic Completion combines Smart And Import (And Basic) completion,
            '    double Automatic Completion will also work the same
            '    Start typing GridView
            '    Invoke Automatic Completion twice (it should say 2xBasic at the bottom of the window)
            '    Automatic Completion will find GridView in PresentationFramework
            '    It can now add a reference to PresentationFramework.dll And import System.Windows.Controls.GridView

            'GridView
        End Sub

        Public Sub ChainedDoubleCompletion()
            ' 4. Chain Automatic Completion with Smart Completion to get at the relevant members Or the original list
            '    Uncomment the following line
            '    Invoke Basic Completion at the end of the line
            '    All members are listed, including the Age property, which Is an int, Not a string
            '    Invoke Smart Completion (it should say Basic, Smart at the bottom of the window)
            '    Smart Completion has now found relevant members of the candidates of the first list
            '    e.g. Age.ToString - Basic Completion found Age, Smart Completion got all the members returning string on Age

            'Dim s3 as String = Me.
        End Sub

#Region "Implementation details"

        Public Property Age As Integer
        Public Property Name As String
        Public Function GetGreeting() As String
            Return "hello"
        End Function

#End Region

    End Class
End Namespace