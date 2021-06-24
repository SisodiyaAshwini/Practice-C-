using System.Threading.Tasks;

namespace Practice.Csharp
{
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
    }
}
