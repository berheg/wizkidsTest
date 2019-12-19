using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Christian has the email address christian+123@gmail.com." +
"Christian's friend, John Cave-Brown, has the email address john.cave-brown@gmail.com." +
"John's daughter Kira studies at Oxford University and has the email adress Kira123@oxford.co.uk." +
"Her Twitter handle is @kira.cavebrown.";
            var pharagraph = new InputString(input);
            pharagraph.EmailChecker();
        }
    }
}
