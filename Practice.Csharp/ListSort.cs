using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Practice.Csharp
{
    //This can be done by three ways
    //IComparable<CustomerForSort>
    ////By Comparision Delegate ==> this looks good
    ///// IComparer<CustomerForSort>

    public partial class ListSort
    {
        public static void Practice1()
        {
            List<int> lst = new List<int>() { 3, 6, 2, 8, 5, 2, 9, 6 };
            Console.WriteLine("Number before sorting");
            looplst(lst);

            lst.Sort();
            Console.WriteLine("Number after sorting; sorted lst in asending order");
            looplst(lst);

            Console.WriteLine("Reverse the lst; so sorted lst in descending order");
            lst.Reverse();
            looplst(lst);

            //Same can be done with string, char
            //Dotnet knows how to sort int, char string because int, char string  have implemented IComparable interface which tells them this
            //But for complex datatype we need to tell how we want sorting

            Console.WriteLine("Sorting of complex type");

            List<CustomerForSort> custlst = new List<CustomerForSort>();
            custlst.Add(new CustomerForSort { ID = 1, Name = "ashwini", Salary = 100000 });
            custlst.Add(new CustomerForSort { ID = 2, Name = "aditi", Salary = 50000 });
            custlst.Add(new CustomerForSort { ID = 3, Name = "anshul", Salary = 200000 });
            custlst.Add(new CustomerForSort { ID = 4, Name = "vijayendra", Salary = 280000 });

            Console.WriteLine("------------Before sort------------");

            foreach (CustomerForSort cust in custlst)
            {
                Console.WriteLine(cust.Salary);
            }

            //This sort will work now as our class has implemented IComparable and provided logic for sort
            custlst.Sort();
            custlst.Reverse();//reverse will also work
            Console.WriteLine("------------After sort------------");
            foreach (CustomerForSort cust in custlst)
            {
                Console.WriteLine(cust.Salary);
            }

            //Sort by SortBySalary
            SortBySalary sortBySalary = new SortBySalary();
            custlst.Sort(sortBySalary);

            //By Comparision Delegate
            //https://www.youtube.com/watch?v=CMQ-RRh2FR8&list=PLAC325451207E3105&index=79
            //declare the method same as delegate signature, which delegate will call

            //Object of delegate and pass function in constructor
            Comparison<CustomerForSort> Comparedelegate = new Comparison<CustomerForSort>(CompareCustomers);
            custlst.Sort(Comparedelegate);

            //This can be achieve in single line of code also instead of creating seperate private method
            //custlst.Sort(delegate (CustomerForSort C1, CustomerForSort C2) { return C1.Name.CompareTo(C2.Name); });

            //Or use the lamda expression,
            //Shortest way of writing it, takes two argument and do the comparision, awesome
            custlst.Sort((x, y) => x.Name.CompareTo(y.Name));

            Console.WriteLine("----------Through comparision delegate-----------");
            foreach (CustomerForSort cust in custlst)
            { Console.WriteLine(cust.Name); }
        }

        private static int CompareCustomers(CustomerForSort X, CustomerForSort Y)
        {
            return X.Name.CompareTo(Y.Name);
        }

        public static void looplst(List<int> lst)
        {
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class CustomerForSort : IComparable<CustomerForSort>
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
        public int CompareTo(CustomerForSort other)
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //if (this.Salary < other.Salary)
            //    return -1;
            //return 0;

            //Salary is int and int has already implemeted the CompareTo, so we ca just use that instead of doing all obove
            //one line of code
            return this.Salary.CompareTo(other.Salary);


        }
    }
    //Now this is old class and we cannot update this class, we can use ICompare in this case and create our own class

    public class SortBySalary : IComparer<CustomerForSort> //It has one method which needs to be implemented
    {
        public int Compare(CustomerForSort X, CustomerForSort Y)
        {
            return X.Salary.CompareTo(Y.Salary);
        }
    }
}
