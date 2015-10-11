using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Tasks5
    {
        public static void Run()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[0] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[0] = 2,
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                });
            finalTask.Wait();
        }
    }
}