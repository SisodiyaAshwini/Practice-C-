using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    //Methods with no name are Anonymous Methods which we pass as lamda expression in method 
    //And those are basically delegates. So Predicate is a generic delegate. You need to pass your function definitation to delegate method 
    public class AnonymousMethods
    {
        public static void Practice()
        {
            List<CustomerForSort> custlst = new List<CustomerForSort>();
            custlst.Add(new CustomerForSort { ID = 1, Name = "ashwini", Salary = 100000 });
            custlst.Add(new CustomerForSort { ID = 2, Name = "aditi", Salary = 50000 });
            custlst.Add(new CustomerForSort { ID = 3, Name = "anshul", Salary = 200000 });
            custlst.Add(new CustomerForSort { ID = 4, Name = "vijayendra", Salary = 280000 });

            //We need to find one with id 4
            //So for that we will use method find
            //it taken the Predicate which is delegate of type CustomerForSort
            //public delegate bool Predicate<in T>(T obj);

            //Lets as create a seperate method to do find job ---- FindById
            //Let create delegate object
            //Pass the parameter in the delegate, which you will have to pass to function

            Predicate<CustomerForSort> PredicateDelegate = new Predicate<CustomerForSort>(FindById);

            CustomerForSort cust = custlst.Find(emp => PredicateDelegate(emp));

            //Calling method here will also return 
            //CustomerForSort cust = custlst.Find(emp => FindById(emp));

            //Now instead of creating a function FindById, we can pass this as an Anonymous function            
            CustomerForSort custAno = custlst.Find(
                delegate (CustomerForSort x) //If you clearly see this is function with no name
                { 
                    return x.ID == 4; 
                });

            Console.WriteLine("{0} {1} {2}", cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("-------------from Anonymonus Implementation---------------");
            Console.WriteLine("{0} {1} {2}", custAno.ID, custAno.Name, custAno.Salary);
        }

        public static bool FindById(CustomerForSort obj)
        {
            return obj.ID == 4;
        }
    }
}
