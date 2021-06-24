using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Csharp
{
    //dictionary vs list
    //When there are two many data to loop in dictionary is better
    public partial class List
    {
        public static void Practice()
        {
            Customer C1 = new Customer
            {
                ID = 1,
                Name = "Ashwini"
            };

            Customer C2 = new Customer
            {
                ID = 2,
                Name = "Niks"
            };

            Customer C3 = new Customer
            {
                ID = 3,
                Name = "Nikku"
            };

            List<Customer> custlst = new List<Customer>(2);

            custlst.Add(C1);
            custlst.Add(C2);
            custlst.Add(C3); //even though the size is 2 if we pass three elemnts it will not throw any error unlike array and increase the size

            //Add range of records

            Customer C4 = new Customer
            {
                ID = 2,
                Name = "Aditi"
            };

            Customer C5 = new Customer
            {
                ID = 3,
                Name = "Sisodiya"
            };

            // can read through index

            List<Customer> anotherlst = new List<Customer>();

            //Add this to old one
            custlst.AddRange(anotherlst);            

            foreach (Customer cust in custlst)
            {
                Console.WriteLine("Id = {0} Name = {1}", cust.ID, cust.Name);
            }

            //Difference between Insert and Add
            //Insert at particular location and thing will move
            //Add, add at the end
            custlst.Insert(0, C3);

            Console.WriteLine("-------------After inserting-----------------");

            foreach (Customer cust in custlst)
            {
                Console.WriteLine("Id = {0} Name = {1}", cust.ID, cust.Name);
            }

            //Item exists in list
            //Contains()
            //C3 exists in list

            if(custlst.Contains(C3))
            {
                Console.WriteLine("Customer third exists in list");
            }

            Console.WriteLine("-------------Exists and Find-----------------");

            //Exists() exists in lst based on condition
            if (custlst.Exists(x => x.Name.StartsWith("A")))
            {
                //find the first matching item from the list, so even if A starts name are multiple, it will send first record
                Console.WriteLine("The name is {0}", custlst.Find(x => x.Name.StartsWith("A")).Name);
            }

            Console.WriteLine("-------------Exists and Find last-----------------");

            if (custlst.Exists(x => x.Name.StartsWith("N")))
            {
                //find the last one from matching one
                Console.WriteLine("The name is {0}", custlst.FindLast(x => x.Name.StartsWith("N")).Name);
            }
            Console.WriteLine("-------------Exists and Find all-----------------");

            if (custlst.Exists(x => x.Name.StartsWith("N")))
            {
                //find all
                List<Customer> custs = custlst.FindAll(x => x.Name.StartsWith("N"));
                foreach(Customer cust in custs)
                {
                    Console.WriteLine("{0}, {1}",cust.ID.ToString(), cust.Name);
                }
            }

            Console.WriteLine("-------------Find Index-----------------");
            Console.WriteLine("Give the first elemnt which matches the codition");
            Console.WriteLine("-------------Find Last-----------------");
            Console.WriteLine("Give the last index elemnt which matches the codition");

            custlst.Remove(C3); //Remove C3 first occurance, C3 is twice same index will throw error as in dictionary key should be unique 
            //and i am setting id as key 

            //Convert list to an dictionary
            Dictionary<int,Customer> custdist = custlst.ToDictionary(cust => cust.ID, cust => cust);

            Console.WriteLine("-------------Dictionary output-----------------");

            foreach (KeyValuePair<int,Customer> keyValue in custdist)
            {
                Console.WriteLine(keyValue.Value.Name);
            }

            Console.WriteLine("-------------GetRange-----------------");
            Console.WriteLine("Starts with an index, till the count you give GetRange(int Index, int count)");

            Console.WriteLine("-------------InsertRange-----------------");
            Console.WriteLine("Works as Insert, just it is a range");

            Console.WriteLine("-------------RemoveRange-----------------");
            Console.WriteLine("Works as Remove, just it is a range");

            Console.WriteLine("-------------RemoveAt-----------------");
            Console.WriteLine("Takes index and remove that one");

            Console.WriteLine("-------------RemoveAll-----------------");
            Console.WriteLine("Remove all based upon condition, it takes predicate");

            Console.WriteLine("-------------TrueForAll-----------------");
            Console.WriteLine("if all matches pass the condition");

            Console.WriteLine("-------------AsReadOnly-----------------");
            Console.WriteLine("You can make collection readonly, no add remove");
        }
    }
}

/*
Id = 1 Name = Ashwini
Id = 2 Name = Niks
Id = 3 Name = Nikku
-------------After inserting-----------------
Id = 3 Name = Nikku
Id = 1 Name = Ashwini
Id = 2 Name = Niks
Id = 3 Name = Nikku
Customer third exists in list
-------------Exists and Find-----------------
The name is Ashwini
-------------Exists and Find last-----------------
The name is Nikku
-------------Exists and Find all-----------------
3, Nikku
2, Niks
3, Nikku
-------------Find Index-----------------
Give the first elemnt which matches the codition
-------------Find Last-----------------
Give the last index elemnt which matches the codition
-------------Dictionary output-----------------
Ashwini
Niks
Nikku
-------------GetRange-----------------
Starts with an index, till the count you give GetRange(int Index, int count)
-------------InsertRange-----------------
Works as Insert, just it is a range
-------------RemoveRange-----------------
Works as Remove, just it is a range
-------------RemoveAt-----------------
Takes index and remove that one
-------------RemoveAll-----------------
Remove all based upon condition, it takes predicate
 */
