using System;

namespace Practice.Csharp
{
    public class BuildinTypes
    {
        //Default value of any value type is some form of 0

        //boolean
        readonly bool b = true; // true or false
        //readonly int i = null; //This will throw an error for null
        readonly string s = null; //this is allowed as string is reference type
        public static void Practice()
        {
            //int
            //you will see that int has some properties
            Console.WriteLine("Integer max value is: {0}", int.MaxValue);
            Console.WriteLine("Integer min value is: {0}", int.MinValue);

            //float and double
            //They hold relatatively big number 
            float f = 32.4638F; //32 bit, add F
            double d = 34.64928364; //64 bit            
            decimal dd = 32.56537M; // 124 bit, add M


            //String type
            //String is reference type. hence default value is null
            //Print the double quote as well. This can be done be escape sequence.

            //Good article on string manipulation https://docs.microsoft.com/en-us/dotnet/csharp/how-to/modify-string-contents#code-try-2

            string name = "\"Ashwini\"";
            Console.WriteLine("My name is {0}", name);

            //New line character
            string multiline = "One\nTwo\nThree";
            Console.WriteLine(multiline);

            //If you want to print blackalash
            string queryStringWithSingleQuotes = "C:\\Program\\DotNet\\Training";
            Console.WriteLine(queryStringWithSingleQuotes);

            string queryStringWithDoubleQuotes = "C:\\\\Program\\\\DotNet\\\\Training";
            Console.WriteLine(queryStringWithDoubleQuotes);

            //Verbatim Literal
            //All ascape sequence character are treated as simple charater by adding @, This is more readable.
            string queryString1 = @"C:\Program\DotNet\Training"; // get printed as it is.
            Console.WriteLine(queryString1);

            string queryString = @"C:\\Program\\DotNet\\Training"; // get printed as it is.
            Console.WriteLine(queryString);

        }

    }
}
