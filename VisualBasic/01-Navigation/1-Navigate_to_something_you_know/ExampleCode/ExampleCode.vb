Namespace ExampleCode
    Public Class Person
        Public ReadOnly Property Name As String
        Public ReadOnly Property Age As Integer

        Public Sub New(name As String, age As Integer)
            Me.Name = name
            Me.Age = age
        End Sub
    End Class

    Public Class DocumentViewModel
        ' ...
    End Class

    Public Class SettingsViewModel
        ' ...
    End Class

    Public Class SettingsViewManager
        ' ...
    End Class
End Namespace