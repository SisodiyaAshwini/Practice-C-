using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Csharp
{
    //Method Override and Method hiding
    public class NewKeyword_MethodHiding_Employee
    {
        public string Fname;
        public string lname;

        public void PrintFullname() => Console.WriteLine(Fname + " " + lname + " base contructor");

        public virtual void PrintLastName() => Console.WriteLine("Lastname " + lname + " from base contructor");
    }

    public class PartTimeEmployee : NewKeyword_MethodHiding_Employee
    {
        // to hide the parent class method we have just used the new word in method declaration
        //if you dont use the new keyword nothing will stop just you will get the warning
        public new void PrintFullname() => Console.WriteLine(Fname + " " + lname + " Contractor");
    }

    public class FullTimeEmployee : NewKeyword_MethodHiding_Employee
    {

    }

    public class ThirdTimeEmployee : NewKeyword_MethodHiding_Employee
    {
        // because of base keyword, parent class PrintFullname will be called
        public new void PrintFullname() => base.PrintFullname();
    }

    public class TemporaryEmployee : NewKeyword_MethodHiding_Employee
    {
        public override void PrintLastName() => Console.WriteLine("Lastname " + lname + "  I have override the base class virtual method");
    }

    public class NewKeyword_MethodHiding
    {
        public static void Practice()
        {
            PartTimeEmployee pe = new PartTimeEmployee();
            pe.Fname = "Ashwni";
            pe.lname = "Sisodiya";
            pe.PrintFullname();

            FullTimeEmployee fe = new FullTimeEmployee();
            fe.Fname = "Vijayendra";
            fe.lname = "Singh";
            fe.PrintFullname();

            // what if i want to call base class contructor, there are multiple ways
            //first
            NewKeyword_MethodHiding_Employee parentclassobj = new FullTimeEmployee();
            parentclassobj.Fname = "Vijayendra";
            parentclassobj.lname = "Singh";
            parentclassobj.PrintFullname();

            //second way is
            //use base keyword
            ThirdTimeEmployee te = new ThirdTimeEmployee();
            te.Fname = "Vijayendra";
            te.lname = "Singh";
            te.PrintFullname();

            //third is typecase
            //part time class is over hiding and you want to call base class contructor
            PartTimeEmployee pe1 = new PartTimeEmployee();
            pe1.Fname = "Ashwni";
            pe1.lname = "Sisodiya";
            ((NewKeyword_MethodHiding_Employee)pe1).PrintFullname();

            //This is the scanerio of overriding, all above are method hiding
            //There is one more scaneri in which even you have created the base class object you can class the derived class method,
            //this is because if keyword virtual, if there is any virtual method that can be override in child class and can be called on base class instance
            // At the runtime it will identify which derived class have created the object and then call dervied class method.
            //And this is the different between method hiding and method overridding. One is compile time and another is runtime.
            NewKeyword_MethodHiding_Employee obj = new TemporaryEmployee();
            obj.PrintLastName();
        }
    }

    /* 
Ashwni Sisodiya Contractor
Vijayendra Singh base contructor
Vijayendra Singh base contructor
Vijayendra Singh base contructor
Ashwni Sisodiya base contructor
Lastname   I have override the base class virtual method
*/
}
