using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Csharp
{
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
