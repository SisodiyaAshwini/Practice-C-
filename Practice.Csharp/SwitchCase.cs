using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    public class SwitchCase
    {
        public static void Practice()
        {
            Start: //This is the label we add for goto, a program can have multiple switch and multiple goto.
            Console.WriteLine("Please enter the number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                case 30:
                    Console.WriteLine("30");
                    break;
                default:
                    Console.WriteLine("Different number");
                    break;
            }

            //Another way of writing same code, you can club the statements
            switch (num)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("{0}", num);
                    break;
                default:
                    Console.WriteLine("Different number");
                    break;
            }

            Console.WriteLine("Do you want to do it again?");
            string option1 = Console.ReadLine();

            switch (option1.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
            
        }
    }
}
