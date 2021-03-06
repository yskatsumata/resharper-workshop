﻿Namespace JetBrains.ReSharper.Koans.Navigation
    ' Go to File Member
    '
    ' Navigate to any members defined in the current file
    '
    ' Alt+\ (VS)
    ' Ctrl+F12 (IntelliJ)
    '
    ' 1. Navigate to type by name, CamelHumps, middle matching or wildcard
    '    Type "GoToFileMemberExample"
    '    Type "GTFME"
    '    Type "FileMember"
    '    Type "GoTo*Example"
    '
    ' 2. Navigate to class member by name
    '    Type "foo" to navigate to GoToFileMemberExample.Foo
    '
    ' 3. Navigate to constructor
    '    Type "new" or "ctor"
    '
    ' 4. Navigate to members by visibility
    '    Type "public" or "private"

    ' ----------

    Public Class GoToFileMemberExample
        Private ReadOnly bar As Integer

        Public Sub New(foo As String, bar As Integer)
            Me.bar = bar
            Me.Foo = foo
        End Sub

        Private Property Foo As String
    End Class
End Namespace
