using System;

namespace Practice.Csharp
{
    public class NullableType
    {
        //Default value of reference type is null
        public static void PracticeNullType()
        {
            //The concept is : The value type as by default non nullable, check Buildintypes class. 
            //Is is possible to make them nullable in c#
            //The answer is yes.This can be done by adding ?
            //The main use of this is in database mapping

            //int j = null //This will throw error.
            int? i = null;

            //Usage: These is one property IsWorking, possible value for this is true, false or this is optional.
            bool IsWorking = true; //or false
            //whatif i dont want to answer this
            bool? IsWorkingNullable = false; // I want something as null in this

            if (IsWorkingNullable == true)
            {
                Console.WriteLine("User is working");
            }
            else if (!IsWorkingNullable.Value) //Another way of doing the same check, for this it should have value other than null.
                                               //if null this will throw error.
            {
                Console.WriteLine("User is not working");
            }
            else Console.WriteLine("User did not answered");
        }

        public static void PracticeNullCoalescingOperator()
        {
            int? TicketsOnSale = null; //This is nullable
            int AvailableTickets = 0; //This is not nullable

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                // AvailableTickets = TicketsOnSale;// This line will throw error. Cannot implicitly convert nullable(TicketOnSale) to non nullable.
                AvailableTickets = TicketsOnSale.Value; //Value bydefault returns non nullable value. hover and check retuen type.
                AvailableTickets = (int)TicketsOnSale; //Or we can do conversion like this.
            }

            Console.WriteLine("Available ticket {0}", AvailableTickets);

            //With coalescing operator we can reduce this code to single line to check null
            //Ideal scenario to use this operator is you want to replace to some value when variable is null else use the existing value.
            int AvailableTicketsbyCoalescing = TicketsOnSale ?? 0;
            //What this line will do is it will check if TicketOnSale is null return 0 else return value in variable.
            Console.WriteLine("Available ticket {0}", AvailableTicketsbyCoalescing);

        }
    }
}
