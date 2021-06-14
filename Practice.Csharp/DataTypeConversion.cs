using System;

namespace Practice.Csharp
{
    public class DataTypeConversion
    {
        public static void Practice()
        {
            int i = 100;
            float f = i;
            Console.WriteLine(f);
            //Implicity conversion happen when there is no loss of information and no exception will occur.
            //in above float is bigger data type so information will not be lost. wise versa is not possible.

            float f1 = 123.57F;
            int i1 = (int)f1; // This will not do the implicit conversion because in this case information will be lost.            
            //There are two ways of doing conversion, type cast (int) or use convert class.
            int i2 = Convert.ToInt32(f1); // int holds 32 bit so toint32
            long l = Convert.ToInt64(f1); // int holds 64 bit so toint64, this will not say no for 32 also, because 32 is small.
            Console.WriteLine(i1); //output is 123. decimal part is lost
            Console.WriteLine(i2);
            Console.WriteLine(l);

            //Now what is the difference between type cast and convert
            //difference comes when there is very big number. Type cast will not hrow the error but print the smallest interger value whearas convert class will throw error.
            float f2 = 1273733434333.45F;// this is really big number
            int i4 = (int)f2; // this will not throw any error but it will just display smalleast interger values, which is wrong value.
            Console.WriteLine(i4); // output for this is -2147483648

            //whereas
            int i5 = Convert.ToInt32(f2); // This will throw an exception.
            Console.WriteLine(i5);//Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.

            //Parse 
            //First of all, what is difference between prase and convert?
            //Convert you use when working within same datatype like int, float,decimal,long
            //Prase is like changing string to number
            //if you do int.Parse, you will see this takes an string and returns integer, So
            string str = "100";
            int ip = int.Parse(str);
            Console.WriteLine(ip);

            //tryParse
            //There can be some string which can/cannot be get converted.
            string str1 = "100gh"; // This cannot be valid number. In this case if you use prase it will throw exception
            int result = 0;
            bool IsParsed = int.TryParse(str1, out result); //Basically what Tryprase does i, it tries to convert the string,
                                                            //if it gets successfully converted then stores the value in out variable provided and return true else return false

            if (IsParsed)
            { Console.WriteLine(result); }
            else Console.WriteLine("Enter another valid number");

            
        }
    }
}
