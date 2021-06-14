using System;

namespace Practice.Csharp
{
    //when two interface have same method name, then you need to explicity delcare
    interface I1 
    {
        void Print();
    }

    interface I2
    {
        void Print();
    }

    interface I3
    {
        void Print();
    }
    public class Test : I1, I2, I3
    {
        // access modifier is not required, and tell expilicty which interface we calling
        void I2.Print() => Console.WriteLine("This is from interface I2");
        void I1.Print() => Console.WriteLine("This is from interface I1");  
        
        //Calling method of interfae I3 normally, this will be default call.
        public void Print() => Console.WriteLine("This is from interface I3");
    }

    public class ExplictInterface
    {
        public static void Practice()
        {
            Test obj = new Test();

            //In this case we cannot do obj.Print(), you will not get thr Print in intellicence, it will throw the compile error
            //obj.Print();

            //Typecast to interface type, then accordingly the method will be called
            ((I1)obj).Print();
            ((I2)obj).Print();

            //OR we can do this
            I1 interface1 = new Test();
            I2 interface2 = new Test();
            interface1.Print();
            interface2.Print();

            //You can also default the method by not calling it explicity and by calling other explicity
            //Calling on obj of test class without typecasting
            obj.Print();
        }
    }
}

/*
 * This is from interface I1
This is from interface I2
This is from interface I1
This is from interface I2
This is from interface I3
 */
