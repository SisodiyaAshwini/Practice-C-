using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    public class foreachPractice
    {
        public static void Practice()
        {
            int[] num = { 1, 2, 3 };

            //wherever you want to loop collection.
            //In this you do not have to take care to stop it with condition if collection ends.
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
