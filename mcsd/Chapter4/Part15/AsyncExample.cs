using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter4
{
    public class AsyncExample
    {
        public static async Task HowToUseAsyncProperly()
        {
            HttpClient client = new HttpClient();   // add System.Net.Http reference to your project
            
            Stopwatch clock = new Stopwatch();
            clock.Start();

            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            string google = await client.GetStringAsync("http://www.google.com");

            clock.Stop();
            System.Console.WriteLine("Took {0:hh\\:mm\\:ss} seconds", clock.Elapsed);

            clock.Reset();
            clock.Start();

            Task microsoftTask =  client.GetStringAsync("http://www.microsoft.com");
            Task msdnTask =  client.GetStringAsync("http://msdn.microsoft.com");
            Task googleTask =  client.GetStringAsync("http://www.google.com");
            await Task.WhenAll(microsoftTask, msdnTask, googleTask);

            clock.Stop();
            System.Console.WriteLine("Took {0:hh\\:mm\\:ss} seconds", clock.Elapsed);
        }
    }
}
// Took 00:00:08 seconds
// Took 00:00:01 seconds