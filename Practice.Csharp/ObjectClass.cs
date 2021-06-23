using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    public class ObjectClass
    {
        //https://www.youtube.com/watch?v=IhXWil0kcTo&list=PLAC325451207E3105&index=58
        //This is the base class of all the classes.
        //This provides four methods
        //equals
        //tostring
        //gettype
        //gethashcode
        
        //These you can override also to give your meaning in your class.

        //This is quite useful

        //Equals() method and why should we override that
        //This has default implementation
        //It is coming from system.object

        public static void Practice()
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Console.WriteLine(Direction.East.Equals(Direction.West));
            Console.WriteLine(Direction.East == Direction.West);

            //These both will work in same manner as both are value type. So you can use anything
            //But what about complex type

            Customer C1 = new Customer();
            C1.ID = 1;
            C1.Name = "Ashwini";

            Customer C2 = C1;

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
            //They will return true, both will work in same way

            //Lets create new object
            Customer C3 = new Customer();
            C3.ID = 1;
            C3.Name = "Ashwini";

            Console.WriteLine(C1 == C3); //This should return true as it check the value type and values are same in both the object,
            //but it is returning false, because of default implementation of Equals, hence we need to override this
            Console.WriteLine(C1.Equals(C3));

            //Difference between Convert.Tostring() and toString is
            //if some value is null Convert class will convert it to empty string
            //whereas ToString() will throw null exception error

            Customer C4 = null;
            Console.WriteLine(Convert.ToString(C4));
            //Console.WriteLine(C4.ToString()); //This will throw exception, does not handle null
        }

        public enum Direction
        {
            East = 1,
            West = 2,
            North = 3,
            South = 4
        }
    }
}
