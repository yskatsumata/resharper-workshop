namespace JetBrains.ReSharper.Koans.Editing
    ' Show Quick Documentation
    '
    ' Ctrl+Shift+F1 (VS)
    ' Ctrl+Q (IntelliJ)
    ' Escape to close

    public class XmlDocumentation
        public sub Method()
            ' 1. Place the caret on the Documented class name and invoke QuickDoc
            '    Click the "Go to" hyperlink to take the caret to the definition of Documented
            '    Click the "RelatedClass" see-also hyperlink to read the xml documentation for RelatedClass 
            dim documented = new Documented()

            ' 2. Place the caret on the DocumentedMethod method and invoke QuickDoc
            '    Navigate the hyperlinks for parameter and return types
            documented.DocumentedMethod("hello", true)
        end Sub

        ' 3. Document this method
        '    Type 3 "'" before the method "'''" a template xml outline is added for you
        ' 4. Add a new parameter
        '    The parameter will be highlighted as missing in the xml docs. Alt+Enter to fix
        '    (# Not supported for VB.NET?)
        ' 5. Remove a parameter
        '    The extra parameter in the xml docs will be highlighted.
        '    (# Not supported for VB.NET?)
        ' 6. Add another parameter, but add the docs by hand
        '    You should get code completion for the param element, and for the parameter name
        '    (# Not supported for VB.NET?)
        ' 7. Use the rename refactoring to rename a parameter - the docs should be updated
        ' 8. Invoke Find Usages on the "name" parameter
        '    Toggle the Show Usages in Documentation in the Filter Usages dropdown


        Public Function RequiresDocumentation(name As String, value As Integer) As Boolean
            Console.WriteLine(name)
            Return True
        End Function
    End class

    #region "Implementation Details"

    ''' <summary>
    ''' This class has xml documentation
    ''' </summary>
    ''' <remarks>
    ''' <para>You can add documentation in remarks</para>
    ''' <para>And the remarks can contain paragraphs</para>
    ''' </remarks>
    ''' <seealso cref="RelatedClass"/>
    public class Documented
        ''' <summary>
        ''' Does something important
        ''' </summary>
        ''' <param name="data">The data required to complete the operation</param>
        ''' <param name="log">Should perform logging</param>
        ''' <returns>True if the operation completes succesfully</returns>
        public Function DocumentedMethod( data as string,  log as Boolean) as Boolean
            return true
        end Function
    end Class

    ''' <summary>
    ''' This class is related and also has documentation
    ''' </summary>
    public class RelatedClass
    end Class

    #end region
end namespace