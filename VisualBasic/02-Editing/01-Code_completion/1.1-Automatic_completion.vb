Imports System.Runtime.CompilerServices

Namespace JetBrains.ReSharper.Koans.Editing
    ' Automatic Completion
    '
    ' Code completion that appears while typing, to complete method names
    ' Or elements, etc.
    '
    ' Combines Basic, Import And Smart completion
    ' Basic = standard code completion from the current context (methods, properties, etc)
    ' Import = code completion from other namespaces
    ' Smart = filtered code completion for the current context (e.g. only string values for a string parameter)
    '
    ' Ctrl+Space / Automatic

    Public Class AutomaticCompletion
        ' 1. Type: Me.
        '    After the dot, Basic completion shows the code completion options for the current context
        '    Members of the current type are shown in bold (# Not supported for VB.NET?)
        '    Inherited members are in normal text
        ' 2. Type: String value =
        ' After the equals sign, Automatic Completion shows the locally scoped Basic completion options followed
        '      by the wider scope of Basic Completion items, followed by Import Completion items
        '    I.e. Local context (variables, parameters, members)
        '         Locally accessible types (for navigating into)
        '         Importable types (for navigating into, but requires a using statement)
        ' 3. The most frequently used item Is usually pre-selected e.g. Me.Age might be the most used
        ' 4. If there isn't a most frequently used item, the most likely item is highlighted but not selected
        '    e.g. "Dim value As String =" shows a completion list with stringParameter highlighted
        ' 5. Ctrl makes code completion window transparent
        ' 6. Dismiss the window with Esc
        ' 7. ".", space, tab And enter accept the choice (configurable in options)
        Public Sub ShowCurrentContext(stringParameter As String)
            'Me.

            'Dim value As String =
        End Sub

#Region "Implementation details"

        Public Property Name As String
        Public Property Age As Integer

        Public Function SayHello(who As String) As String
            Return "Hello " & who
        End Function

        Public Function SayGoodbye(who As String) As String
            Return "Goodbye " & who
        End Function

#End Region

        ' 8. Enter inserts, Tab replaces (configurable in options)
        '    Place caret after the word Say And hit Ctrl+Space
        '    Choose the option And hit enter - text Is inserted
        '    Choose the option And hit tab - text Is replaced
        ' 9. Configure in ReSharper → Options → Intellisense → Completing Characters
        Public Sub ReplacingExistingCode()
            Me.SayHello("Matt")

            ' Uncomment string literal, try typing Say And completing SayHello
            ' Enter will complete And wrap the string literal as a parameter (# Not supported for VB.NET?)
            ' Tab will complete the method call with the string literal pushed after
            '"Matt"
        End Sub

        ' 10. Use CamelHumps to match
        '     Start typing: Me.SCC to match ShowCurrentContext
        Public Sub UseCamelHumps()
            ' Me.
        End Sub
    End Class

    ' 11. Completion for overriding members
    '     Type "Overrides" to get a list of members to override, select ToString()
    Public Class CompleteOverrideKeyword
        ' Type here:


    End Class

    ' 12. Automatic Completion will import types from namespaces of existing references
    '     Start typing "Inherits INotifyPropertyChanged" after the class declaration
    '     ReSharper will show Automatic Completion "INotifyPropertyChanged (in System.ComponentModel)"
    '     Selecting this will add a Imports System.ComponentModel to the top of the file
    ' See also Import Completion
    Public Class AutomaticImportCompletion
        'Type here:
#Region "Implementation details"
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End Sub

#End Region
    End Class

#Region "Implementation details"

    Public Module ExtensionMethods
        <Extension>
        Public Sub SayCheese(self As AutomaticCompletion)
        End Sub
    End Module

#End Region
End Namespace