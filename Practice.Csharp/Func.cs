using System;
using System.Collections.Generic;
using System.Linq; 

namespace Practice.Csharp
{
    //Func is generic delegate
    //Func<T,Tresult> T is input and TResult is outpur
    //Func can take upto 7 input parameters, there are about 17 overload function of Func
    //https://www.youtube.com/watch?v=3Q4LKCIYrzQ&list=PLAC325451207E3105&index=100
    public class Func
    {
        public static void Practice()
        {
            List<CustomerForSort> custlst = new List<CustomerForSort>();
            custlst.Add(new CustomerForSort { ID = 1, Name = "ashwini", Salary = 100000 });
            custlst.Add(new CustomerForSort { ID = 2, Name = "aditi", Salary = 50000 });
            custlst.Add(new CustomerForSort { ID = 3, Name = "anshul", Salary = 200000 });
            custlst.Add(new CustomerForSort { ID = 4, Name = "vijayendra", Salary = 280000 });

            //lambda expression to write what this Func delegate selector will do
            //cust => "Name of Customer is " + cust.Name; this is function definitation which needs to be passed to delegate
            Func<CustomerForSort, string> selector = cust => "Name of Customer is " + cust.Name;

            //select is a method which excepts Func
            IEnumerable<string> names = custlst.Select(selector);

            // Is it really required to create delegtae function and pass that in select, we can directly write lambda expression
            names = custlst.Select(x => "Name of customer from lamda expression is " + x.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //If i want to pass two input parameters
            Func<int,int,string> funcdel = (x,y) => "Sum is " + (x + y);

            Console.WriteLine(funcdel(10, 20));
        }
    }
}
