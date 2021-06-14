using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    public class Constructor
    {
        //As you know these are default constructore even if you dont create them. But if you create one this will be overwritten by that and if you want both
        //then you can pass something like set default constructor parameters. "this" means current class instance and you passing parameters to current class contructor
        //which is on priority as per class
        //this is called overload a contructor

        string a, b;
        public Constructor()
        : this("No FirstName", "No lastname") { } // this will ultimetly call the below constructor internally

        public Constructor(string _a, string _b)
        {
            this.a = _a;
            this.b = _b;
        }

        public void printName()
        {            
            Console.WriteLine("{0} {1}", this.a, this.b);            
        }

    }

    public class TestConstructor
    {
        public static void provideName()
        {
            //this case name will get printed
            Constructor obj = new Constructor("Ashwini", "Sisodiya");
            obj.printName();
            //This case default value gets printed.
            Constructor obj1 = new Constructor();// output is "No FirstName", "No lastname"
            obj1.printName();

            //So this program has two constructor but you remove the parameterless constructor code there will be only one, that is with paramter one.
        }
    }
}

/*
 Ashwini Sisodiya
No FirstName No lastname
 */
