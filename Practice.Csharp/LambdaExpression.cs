using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Csharp
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
    //(input-parameters) => expression
    //(input-parameters) => { <sequence-of-statements> }

    /*
     * Any lambda expression can be converted to a delegate type. The delegate type to which a lambda expression can be converted is defined by the types of its parameters and return value. 
     * If a lambda expression doesn't return a value, it can be converted to one of the Action delegate types; otherwise, it can be converted to one of the Func delegate types. For example, 
     * a lambda expression that has two parameters and returns no value can be converted to an Action<T1,T2> delegate. 
     * A lambda expression that has one parameter and returns a value can be converted to a Func<T,TResult> delegate
     */

    //Lambda is read as goes to 
    //Find(Emp => Emp.ID == 102)
    //emp is input parameter
    //type is automatically infered
    public class LambdaExpression
    {
        public static void Practice()
        {
            List<CustomerForSort> custlst = new List<CustomerForSort>();
            custlst.Add(new CustomerForSort { ID = 1, Name = "ashwini", Salary = 100000 });
            custlst.Add(new CustomerForSort { ID = 2, Name = "aditi", Salary = 50000 });
            custlst.Add(new CustomerForSort { ID = 3, Name = "anshul", Salary = 200000 });
            custlst.Add(new CustomerForSort { ID = 4, Name = "vijayendra", Salary = 280000 });

            //emp is input parameter
            CustomerForSort C1 = custlst.Find(cust => cust.ID == 4);
            Console.WriteLine(C1.Name);

            //You can explicity provide input parameter type also,in some case if you want, otherwise it get that automatically
            CustomerForSort C2 = custlst.Find((CustomerForSort x) => x.ID == 4);
            Console.WriteLine(C2.Name);

            //replace it to x for simplicity
            CustomerForSort C3 = custlst.Find(x => x.ID == 4);
            Console.WriteLine(C3.Name);

            //This is mostly used in linq expression
            int count = custlst.Count(x => x.Name.StartsWith("a"));
            Console.WriteLine(count);
        }
    }
}
