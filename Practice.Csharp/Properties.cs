using System;

namespace Practice.Csharp
{
    //Basically we create properties to make our fields private so no one can voilate business rules and just change them.
    //by setting properties we can control the fields
    public class Properties
    {
        private int _id; // this should be greater than 0
        private string _name; // it should not be null and emty
        private readonly int _passmark = 35; //This i want to make readonly
        private string city;

        //c# provide built in word "value" 
        public int Id { 
            get { return this._id; }
            set { this._id = value <= 0 ? throw new Exception("id cannot be 0 or less than 0") : value; } 
        }
           
        public string name { 
            get { return this._name; } 
            set { this._name = string.IsNullOrEmpty(value) ? "no name" : value; }
        }

        public int Passmark { 
            get 
            {
                return this._passmark; // only get and only set, you need to type the code.
            } 
        } // there is no set, means you can only read

        public string City { get; set; } // this is simple way of writing, C# will take care of simple assigment
    }

    public class testProperties
    {
       public static void Practice()
        {
            Properties p1 = new Properties();
            p1.name = "Ashwini";
            Console.WriteLine(p1.name);

            p1.name = null;
            Console.WriteLine(p1.name);

            //p1.Passmark = 35;// this will give error.
            //you can just read the value
            Console.WriteLine(p1.Passmark);

            p1.City = "Udaipur";
            Console.WriteLine(p1.City);

            p1.Id = 101;
            Console.WriteLine(p1.Id);

            p1.Id = -101;           
        }
    }
}

/*
 * Ashwini
no name
35
Udaipur
101
Unhandled exception. System.Exception: id cannot be 0 or less than 0
   at Practice.Csharp.Properties.set_Id(Int32 value) in C:\Personal\Practice.Csharp\Practice.Csharp\Properties.cs:line 17
   at Practice.Csharp.testProperties.Practice() in C:\Personal\Practice.Csharp\Practice.Csharp\Properties.cs:line 56
 */
