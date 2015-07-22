using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1
{
    class AsyncAwait
    {
        public static void Run()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}