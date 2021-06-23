using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Csharp
{
    //Dictionary is collection of Key value pair
    public class Dictionary
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
                Name = "Sisodiya"
            };

            Customer C3 = new Customer
            {
                ID = 3,
                Name = "Nikku"
            };

            //To play around with data I create a dictonary
            Dictionary<int, Customer> custDist = new Dictionary<int, Customer>();           

            //To add values in dictionary
            custDist.Add(C1.ID, C1);
            custDist.Add(C2.ID, C2);
            custDist.Add(C3.ID, C3);

            //You can retrie any item through key and that is the fastest way
            Customer cust_id_1 = custDist[1];

            //Can we loop through the dictonary to get value, yes but as this is not list of dictionary, it is dictionary object we need to
            //loop through keyvaluePair

            foreach (KeyValuePair<int,Customer> custkeyvalue in custDist)
            //This can be writtrn as 
            //foreach (var custkeyvalue in custDist) //better use keyvalue that explains the code
            {
                Console.WriteLine("Key : {0}", custkeyvalue.Key); //This is how you read key, in our case it is int
                Customer custvalue = custkeyvalue.Value; //This is how you read value, in our case it is customer class and that you can see as return type when you hover our value
                Console.WriteLine("Id : {0} Name: {1}", custvalue.ID, custvalue.Name); // This is how you are reading
                Console.WriteLine("-------------------------------------");
            }

            /*
             * output
             * Key : 1
            Id : 1 Name: Ashwini
            -------------------------------------
            Key : 2
            Id : 2 Name: Sisodiya
            -------------------------------------
            Key : 3
            Id : 3 Name: Nikku
            -------------------------------------
             */

            //Only value and keys can also be reterived
            foreach (var custkeyvalue in custDist.Values)
            {
                Console.WriteLine("Id : {0} Name: {1}", custkeyvalue.ID, custkeyvalue.Name); // This is how you are reading
                Console.WriteLine("-------------------------------------");
            }

            //Dictionary should also have a unique key so you can check before you add
            if(!custDist.ContainsKey(4)) //not contain then go ahead and add
            {
                custDist.Add(4, C3);
            }

            //Check before using also, that key exists or not because it will not throw any error in complie time but if key is not theere
            //it will throw exception, another value is TryGetValue

            //TryGetValue
            Customer cust;
            if(custDist.TryGetValue(1,out cust))
            {
                Console.WriteLine(cust); // output Practice.Csharp.Customer
            }
            else
            {
                Console.WriteLine("Not present");
            }

            //Count total number of item present in disctionary
            Console.WriteLine(custDist.Count); //4

            //Annother way is Count() method which is present in System.Linq
            Console.WriteLine(custDist.Count()); //4

            Console.WriteLine(custDist.Count(x => x.Key == 1)); //1
            Console.WriteLine(custDist.Count(x => x.Value.ID == 1)); //1
            //you can include any condition you want
            //you can use any linq function

            //If you want to remove all items from the dictionary
            //use clear
            //custDist.Clear();

            //Remove will remove one item
            //custDist.Remove(6); //If key is not present, no exception nothing will happen

            //Convert array in dictionary

            Customer[] custarray = new Customer[3];
            custarray[0] = C1;
            custarray[1] = C2;
            custarray[2] = C3;

            //to convert into dictionary we need to provide key value
            Dictionary<int, Customer> arraytodist = custarray.ToDictionary(cust => cust.ID, cust => cust);
            //cust => cust.ID ---Key
            //cust => cust ====Value
            //you can loop and check
        }
    }
}

/*
 *Id : 3 Name: Nikku
-------------------------------------
Id : 1 Name: Ashwini
-------------------------------------
Id : 2 Name: Sisodiya
-------------------------------------
Id : 3 Name: Nikku
-------------------------------------
Practice.Csharp.Customer
4
4
1
1
 **/
