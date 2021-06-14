using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    //Static property, consructor or method are created once and used by all the objects of the class
    public class StaticAndInstanceMember
    {
        public static float pie; // This is a value that will not chnage for all the object you will create, so better idea is to create this once.
        float radius;
        
        //Static contrstur can only have static members and will be private
        //This should be called before all other contrctor
        static StaticAndInstanceMember()
        {
            Console.WriteLine("Static Constructor");
            StaticAndInstanceMember.pie = 3.14F; // this will be done once
        }

        public StaticAndInstanceMember(float r) // normal contructor
        {
            Console.WriteLine("instance Constructor");
            this.radius = r;
        }

        public float CalculateArea(float r)
        {
            return pie*r*r;
        }
    }

    public class test
    {
        public static void Print()
        {
            //for any instance you create it will use the same static object that will save the memory.
            StaticAndInstanceMember obj = new StaticAndInstanceMember(6);
            Console.WriteLine(obj.CalculateArea(6));

            StaticAndInstanceMember obj1 = new StaticAndInstanceMember(6);
            Console.WriteLine(obj1.CalculateArea(7));

            //Print pie
            Console.WriteLine(StaticAndInstanceMember.pie);
        }
    }

    /*
     Static Constructor
instance Constructor
113.04
instance Constructor
153.86002
3.14
     */
}
