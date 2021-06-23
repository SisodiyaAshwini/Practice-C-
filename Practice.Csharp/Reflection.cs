using System;
using System.Reflection;

namespace Practice.Csharp
{
    public class Reflection
    {
        //When we complie the code and assembly gets generated and meta data of the assembly
        //Reflection is a technique to read the meta data of an asssembly
        //at runtime to get information/ or to use assembly 
        //Reflecion is usefull in late binding : you try to access a class by name and that is not present or name provided is wrong
        //you will get to know that at runtime. You comment the customer class but assembly code will not throw error during complie time
        //but it will throw exception in runtime.

        public static void Practice()
        {
            //This Type is class under system and this is use to get Type object of Class you want to use and for that provide fully specified name.
            Type T = Type.GetType("Practice.Csharp.Customer");

            Console.WriteLine("Class name: ", T.Name);

            //import system.reflection
            //GetProperties will return all the properties of the class and you can see in intellicence that what it will return
            PropertyInfo[] propertyInfos = T.GetProperties();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Property");
            Console.WriteLine("--------------------------");

            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property);
                Console.WriteLine(property.Name);
                Console.WriteLine(property.CanRead);
                //There are many more properties you can explore
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Methods");
            Console.WriteLine("--------------------------");

            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method);
                Console.WriteLine(method.Name);
                Console.WriteLine(method.IsPublic);
                //There are many more properties you can explore
            }

            //Another way of getting Type object 
            Customer c1 = new Customer();
            Type t1 = c1.GetType();
            //you can use this function also to get all information
            Console.WriteLine("Full qualified name " + t1.FullName);

            //Comes to practical use of assembly and reflection in project

            //This is to load the assembly in which our class exits, currently our class is in the same assembly where our main method is
            //hence we are loading the executing the assembly.
            //you can also load other assemblies
            //you can watch this https://www.youtube.com/watch?v=s0eIgl5iqqQ&list=PLAC325451207E3105&index=55
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //from this assembly get the customer Type by name
            Type customerType = executingAssembly.GetType("Practice.Csharp.Customer");

            //you need object of customer to access all its method, so this is all going in reverse way, we have instance of customer class
            object customerInstance = Activator.CreateInstance(customerType);

            //get Methodinfo, if you dont know the name, then you can get a list also
            MethodInfo printMethod = customerType.GetMethod("PrintName");

            //Now this method takes two parameters
            object[] parameters = new object[2];
            parameters[0] = 1;
            parameters[1] = "Ashwini";

            string name = (string)printMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Name from reflection method: {0}", name);

        }

    }

    //output
    //if you see the output for method you will see four more method in addition to customer class method
    // every class in c# directly and indirectly extended by system.object class and system .object class has by default four method and 
    // those will also get listed
    //GetType // this on class object will give you Type object in return// check above
    //Equals
    //GetHashCode
    //ToString

    /* set_Name
True
Void Print()
Print
True
System.String PrintName(Int32, System.String)
PrintName
True
System.Type GetType()
GetType
True
System.String ToString()
ToString
True
Boolean Equals(System.Object)
Equals
True
Int32 GetHashCode()
GetHashCode
True
Full qualified name Practice.Csharp.Customer
Name from reflection method: 1 Ashwini    */

    public class Customer
    {
        private int _id;
        private string _name;

        public int ID { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Customer() { }

        public void Print()
        {
            Console.WriteLine("Id of person: " + _id);
            Console.WriteLine("Name of the person: " + _name);
        }

        public string PrintName(int _id, string _name)
        {
            return _id + " " + _name;
        }
    }
}
