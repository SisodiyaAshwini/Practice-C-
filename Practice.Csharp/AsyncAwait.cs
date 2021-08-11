using System.Threading.Tasks;

namespace Practice.Csharp
{
    //Best Article : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
    //About thread pool : https://docs.microsoft.com/en-us/dotnet/standard/threading/the-managed-thread-pool#using-the-thread-pool
    public class AsyncAwait
    {
        /*
         * first will mark the function as async -- We are telling we can call this method asyncronously
         * we need to create a Task You can think of Task as a unit of work to do 
         * Task is in another library that is System.Threading.Tasks
         * you will give the responsibility to complete the function to task
         * 
         * Task<int> task = new Task<int>(CountCharacter);
         * task.Start();
         * */

        public static async void Practice()
        {
            Task<int> task = new Task<int>(CountCharacter);
            task.Start();
            //Now task has been assigned
            //we have to have some signal to stop when this task gets completed, that is the job of await
            //Async method cant continue until await is reached, means that async method will have more lines of code after await
            //that can be processed only after await is reached
            //other code part of the file is running
            int count = await task; // Await after task gets done

        }

        public static int CountCharacter()
        {
            int[] number = { 3, 5, 6, 7, 3 };
            return number.Length;
        }

        //        Coffee cup = PourCoffee();
        //        Console.WriteLine("coffee is ready");

        // Started all task parallely

        //        Task<Egg> eggsTask = FryEggsAsync(2);
        //        Task<Bacon> baconTask = FryBaconAsync(3);
        //        Task<Toast> toastTask = ToastBreadAsync(2);

        //Await when result is needed

        //        Toast toast = await toastTask;
        //        ApplyButter(toast);
        //        ApplyJam(toast);
        //        Console.WriteLine("toast is ready");
        //        Juice oj = PourOJ();
        //        Console.WriteLine("oj is ready");

        //        Egg eggs = await eggsTask;
        //        Console.WriteLine("eggs are ready");
        //        Bacon bacon = await baconTask;
        //        Console.WriteLine("bacon is ready");

        //        Console.WriteLine("Breakfast is ready!");

        //static async Task Main(string[] args) //completes task, it has multiple tasks
        //{
        //    Coffee cup = PourCoffee();
        //    Console.WriteLine("coffee is ready");

        //    var eggsTask = FryEggsAsync(2); 
        //    var baconTask = FryBaconAsync(3);
        //    var toastTask = MakeToastWithButterAndJamAsync(2);

        //    var eggs = await eggsTask;
        //    Console.WriteLine("eggs are ready");

        //    var bacon = await baconTask;
        //    Console.WriteLine("bacon is ready");

        //    var toast = await toastTask;
        //    Console.WriteLine("toast is ready");

        //    Juice oj = PourOJ();
        //    Console.WriteLine("oj is ready");
        //    Console.WriteLine("Breakfast is ready!");
        //}
    }
}
