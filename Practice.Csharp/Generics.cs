using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    //decoupled with datatype, so that it can be used with any datatype   
    public class Generics
    {
        public static void Practice()
        {
            //first approach

            //All of below will work because of input type as object in calculator class- areEqual method
            //but problem here is it is doing boxing and unboxing as int is struct type and object is refrence type 
            //This is unnesscary taking consumption time, performance degradation

            //bool equal = Calculator.AreEqual(1, 2);
            bool equal; 
            //equal = Calculator.AreEqual("A", "A");

            //second approach
            //With the use of generics 
            equal = Calculator.Equal<int>(1, 1);

            //With generic class
            equal = Calculator<int>.Equal(1, 1);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual(object first, object second)
        {
            return first == second;
        }

        //Generic method
        public static bool Equal<T>(T first, T second)
        {
            //We need to use equal method to do this. we cannot directly do as we dont know the type as of now
            return first.Equals(second);
        }
    }
    //We can also make class generics
    public class Calculator<T>
    {
        //Then no need to specifiy at method level
        public static bool Equal(T first, T second)
        {
            //We need to use equal method to do this. we cannot directly do as we dont know the type as of now
            return first.Equals(second);
        }
    }

}
