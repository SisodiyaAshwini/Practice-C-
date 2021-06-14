using System;

namespace Practice.Csharp
{
    public class Parameters
    {
        public static void Practice()
        {
            Console.WriteLine(Sum(10, 20));
            int sum = 0, product = 0;
            Calculation(10, 20, out sum, out product);
            Console.WriteLine("{0}, {1}", sum, product);
        }

        /// <summary>
        /// This is a simple return method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        //What if i want to return multiple values, don go to list n all, simple here in this scanerio
        //we can you out
        //no need to return as we doing out
        public static void Calculation(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

    }
}
