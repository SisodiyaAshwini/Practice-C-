using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    public class CommonOperator
    {
        public static void Practice()
        {
            //Assigment operator =
            //Arithmetic operator + - * / %
            //Comparision operator == != > < >= <=
            //Conditional operator && ||


            //Ternary Operator ?:
            int number = 10;

            // These many lines without ternary
            bool IsNumber10;
            if (number == 10)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }

            Console.WriteLine(IsNumber10);

            //With Ternary operator
            bool isnumber10 = number == 10 ? true : false;
            Console.WriteLine(isnumber10);
        }
    }
}
