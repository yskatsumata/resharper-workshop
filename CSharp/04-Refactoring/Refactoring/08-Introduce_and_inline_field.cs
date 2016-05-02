﻿using System;
using System.Windows.Forms;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Introduce Field
    //
    // Create a field in the current class from selection
    //
    // Ctrl+R, F (VS)
    // Ctrl+Alt+D (IntelliJ)

    // Inline Field
    //
    // Replaces field usage with the contents of the field
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class IntroduceAndInlineField
    {
        public void InitialiseForm()
        {
            // 1. Introduce Field
            //    Place the caret on button and invoke Introduce Field
            //    Choose name and where to initialise field - current location, field initialiser or constructor
            //    Choose visibility (private, public, etc.) and if to make static/readonly
            var form = new Form();
            var button = new Button();
            form.Controls.Add(button);
        }

        public void InitialiseForm2()
        {
            // 2. Introduce Field for multiple instances
            //    Select "new Button()" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    Invoke Introduce Field
            //    ReSharper highlights all usages across ALL methods, prompts for one usage, all across methods or all in this method
            //    Choose name and where to initialise field - current location, field initialiser or constructor
            //    Choose visibility (private, public, etc.) and if to make static/readonly
            var form = new Form();
            form.Controls.Add(new Button());
            form.Controls.Add(new Button());
            form.Controls.Add(new Button());
        }

        public void IntroduceConstant()
        {
            // 3. Introduce Constant
            //    Select the "Hello world" string literal
            //    Invoke Introduce Field
            //    Select Introduce Constant on dialog (Alt+I)
            Console.WriteLine("Hello world");
        }

        private const int MyField = 23;

        public void InlineField()
        {
            // 4. Inline Field
            //    Place caret on MyField
            //    Invoke Inline Field
            Console.WriteLine(MyField);
        }

        private const int MyOtherField = 23;

        public void InlineFieldOnMultipleInstances()
        {
            // 5. Inline Field
            //    Place caret on MyOtherField
            //    Invoke Inline Field
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
        }
    }
}