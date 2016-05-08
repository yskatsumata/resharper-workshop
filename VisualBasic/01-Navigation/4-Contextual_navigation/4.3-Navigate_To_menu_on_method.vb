Imports System

namespace JetBrains.ReSharper.Koans.Navigation
    ' Navigate To menu
    '
    ' Displays a contextual menu of options you can use to navigate to from
    ' your current location
    '
    ' Very useful way of navigating without having to learn ALL of the shortcuts!
    '
    ' Alt+` (VS)
    ' Ctrl+Shift+G (IntelliJ)


    ' 5. When the caret is on a method
    public class NavigateToMenuOnMethod
    ' a) Member overloads highlights overloads of the method
        '    Escape clears the highlight
        '    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
        '    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
        Public Overloads function OverloadedMethod() as Boolean
            return true
        End Function

        ' b) Function exit(s) highlights return statements
        '    Escape clears the highlight
        '    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
        '    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
        public Overloads Function OverloadedMethod(arg1 as String) as Boolean
            if string.IsNullOrEmpty(arg1) then return False
            
            Console.WriteLine("do!")

            if arg1 = "throw" then throw new InvalidOperationException()

            return true
        end Function

        public Overloads function OverloadedMethod(arg1 as String, arg2 as String) as Boolean
            return false
        end Function
    end Class
end namespace