using System;

namespace Practice.Csharp
{
    public class ClassInheritance
    {
        public ClassInheritance()=> Console.WriteLine("I am base constuctor");

        public ClassInheritance(string Message) => Console.WriteLine("Message from paramter constructor ffrom base class {0}", Message);
    }

    public class DerivedClass1: ClassInheritance
    {
        // we can override the prefrence of calling base class contructor as per our need
        public DerivedClass1() => Console.WriteLine("I am derived constuctor first");
        
    }

    public class DerivedClass2 : ClassInheritance
    {
        //This is how we calling base class contructor of choice
        public DerivedClass2(): base("I am set as high priority") => Console.WriteLine("I am derived constuctor second");

    }

    public class TestClassInheritance
    {
        public static void Practice()
        {
            DerivedClass1 d1 = new DerivedClass1();
            DerivedClass2 d2 = new DerivedClass2();
        }
       
    }

    /* output on run 
     * I am base constuctor
       I am derived constuctor first
       Message from paramter constructor ffrom base class I am set as high priority
       I am derived constuctor second
     */

}
