using System;

namespace C_Basic
{
    class StringClass
    {
        public void Init() 
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            var numbers = new int[5] {1, 2, 3, 4, 5};
            string list = string.Join(",", numbers);

            // verbatim string
            // add @ to convert
            // using no escaping chars
            var somePath = @"c:\Documents\Kaktus";

            var firstName = "Eelon";

            // alternatively explicit type
            string secondName = "Muskus";

            // alternatively, as string is a class
            String middleName = "Mighty";

            var fullName = firstName + " " + secondName;
            var fullNameAlt = string.Format("The full name is {0} {1}", firstName, secondName);

            var allNames = new string[3] {"Whoop", "Yee", "Goldberg"};
            var formattedNames = string.Join("::", allNames);

            var verbatimText = @"Hello!
Check this out,
will you?";

            Console.WriteLine(verbatimText);
        }
    }
}
