using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    /*
     * The is operator is used to check if the run-time type of an object is compatible with the given type or not whereas as operator is used to perform conversion between compatible reference types or Nullable types.
The is operator is of boolean type whereas as operator is not of boolean type.
The is operator returns true if the given object is of the same type whereas as operator returns the object when they are compatible with the given type.
The is operator returns false if the given object is not of the same type whereas as operator return null if the conversion is not possible.
The is operator is used for only reference, boxing, and unboxing conversions whereas as operator is used only for nullable, reference and boxing conversions
     */

    // taking a class
    public class P { }
    // taking a class
    // derived from P
    public class P1 : P { }

    // taking a class
    public class P2 { }
    public class IsAs
    {
        public static void Practice()
        {
            // creating an instance
            // of class P
            P o1 = new P();

            // creating an instance
            // of class P1
            P1 o2 = new P1();

            // checking whether 'o1'
            // is of type 'P'
            Console.WriteLine(o1 is P);

            // checking whether 'o1' is
            // of type Object class
            // (Base class for all classes)
            Console.WriteLine(o1 is Object);

            // checking whether 'o2'
            // is of type 'P1'
            Console.WriteLine(o2 is P1);

            // checking whether 'o2' is
            // of type Object class
            // (Base class for all classes)
            Console.WriteLine(o2 is Object);

            // checking whether 'o2'
            // is of type 'P'
            // it will return true as P1
            // is derived from P
            Console.WriteLine(o2 is P1);

            // checking whether o1
            // is of type P2
            // it will return false
            Console.WriteLine(o1 is P2);

            // checking whether o2
            // is of type P2
            // it will return false
            Console.WriteLine(o2 is P2);
        }
    }
}