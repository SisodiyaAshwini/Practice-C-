using System;
using System.Collections.Generic;

namespace Practice.Csharp
{
    /*
     A delegate is type safe function pointer. Means it is used to called a function, you call a delegate to call a function. 
    Now the question arises, why you not directly call 
    the function. Why we need delegate. It is because of the flexibility it provides. This is why delegates called type safe.
    Also delegate, the signature if the delegate should match the signature of the function it points to.
    1. You need to delcare a delegate (This syantx is quite simple to method declaration just you need to add word delegate)
    Example 
    public delegate void HellofuncDelegate(string Messgae)
    see by removing word delegate it will look like method declaration
    2. Create the object of delegate like you do for class and use it.
    HellofuncDelegate del = HellofuncDelegate(pass the function name here)
    and to obj pass the parameter values.
     */

    public delegate void HellofuncDelegate(string messgae);
    
    public class Delegates
    {
        public static void Practice()
        {
            HellofuncDelegate del = new HellofuncDelegate(Hello);
            del("Hello from delegate");

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() {Id=101, Name="John", Salary=6000, Experience=6 });
            emplist.Add(new Employee() { Id = 102, Name = "Mary", Salary = 5000, Experience = 4 });
            emplist.Add(new Employee() { Id = 103, Name = "Todd", Salary = 7000, Experience = 7 });

            Employee obj = new Employee();
            //obj.PromoteEmployee(emplist);
            IsPromotable delPromote = new IsPromotable(PromoteCondition);
            obj.PromoteEmployee(emplist, delPromote);
            // There is short cut way of writing this by using lamda ecpression, you can directly typein the logic of method
            obj.PromoteEmployee(emplist, emp => emp.Experience >= 5);
        }

        //Creating the method here in user defined class and passing the method above in delegate
        //So ultimetly when you call the delegate this method will be called.
        //So any one can create the function of there logic with same type cast.
        public static bool PromoteCondition(Employee e)
        {
            if(e.Experience >= 5)
            { return true; }
            else { return false; }
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

    //Practice : Why we use delegate. See below class which has logiv to promote employees, it promote the empoyee based on certain logic and that logic is hardcoded below.
    // This is framework class which the other will use, so basically harcoding should be avoided.
    //what if we have another company which has different logic, he cannot reuse the same class, and here the delegates come into the picture and solve this issue
    //Delegate is extensively used by the developer to plug there logic in exisitng class

    /* Normal class
     public class Employee
     {
         public int Id { get; set; }
         public string Name { get; set; }
         public int Salary { get; set; }
         public int Experience { get; set; }

         public void PromoteEmployee(List<Employee> emplist)
         {
             foreach(Employee e in emplist)
             {
                 if(e.Experience >= 5)
                 {
                     Console.WriteLine(e.Name + " promoted");
                 }
             }
         }
     }*/

    //Above class with the use of delegate    
    public delegate bool IsPromotable(Employee e);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PromoteEmployee(List<Employee> emplist, IsPromotable delObj)// This framework class method takes delegte, which makes this function flexible
            //See the logic is replaced here, no logic in there, we are just passign the delegate here
            //Now this delegate will call the method which will have the logic
        {
            foreach (Employee e in emplist)
            {
                if (delObj(e)) //In delegate object you are passing the parameter
                {
                    Console.WriteLine(e.Name + " promoted");
                }
            }
        }
    }


    /*
     Hello from delegate
    John promoted
    Todd promoted
    John promoted
    Todd promoted
     */

    public delegate void SampleMultiDelegate();
    public class MulticastDelegates
    {
        public static void Practice()
        {
            SampleMultiDelegate del1, del2, del3, del4;
            del1 = new SampleMultiDelegate(Method1);
            del2 = new SampleMultiDelegate(Method2);
            del3 = new SampleMultiDelegate(Method3);

            del4 = del1 + del2 + del3;
            del4();
        }

        public static void Method1() => Console.WriteLine("Method first");
        public static void Method2() => Console.WriteLine("Method second");
        public static void Method3() => Console.WriteLine("Method third");

    }

    /*
     * Method first
Method second
Method third
     */
}

