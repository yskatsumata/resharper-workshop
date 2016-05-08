Imports System.ComponentModel

Namespace JetBrains.ReSharper.Koans.Navigation
    ' File Structure Window
    '
    ' Displays outline of file
    '
    ' Ctrl+Alt+F (VS)
    ' Ctrl+F11 (IntelliJ)
    '
    ' 1. Double click to navigate
    ' 2. Select "Track caret in editor" And move around the editor
    ' 3. Use the Next And Previous buttons to navigate around
    ' 4. Explore the right click options
    ' 5. Type in the window to filter

    Public Class FileStructureWindow
        Implements IComponent

        Public Sub New()
            Name = "Hello"
        End Sub

        Public ReadOnly Property Name As String

        ' 6. In the file window, click the "x" in the box representing the region
        '    this removes the region

#Region "Implementation Of IComponent"

        Public Sub Dispose() Implements IComponent.Dispose
            Throw New NotImplementedException()
        End Sub

        Public Property Site As ISite Implements IComponent.Site
        Public Event Disposed As EventHandler Implements IComponent.Disposed

#End Region
    End Class
End Namespace