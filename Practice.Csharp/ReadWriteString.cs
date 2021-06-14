using System;

namespace Practice.Csharp
{
    public class ReadWriteString
    {
        public static void ReadWriteLine()
        {
            Console.WriteLine("Please enter your first name");

            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("My name is " + firstName + " " + lastName);

            //More often way to write
            Console.WriteLine("My name is {0}, {1}", firstName, lastName);
        }
    }
}
