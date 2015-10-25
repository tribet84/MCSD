using System.IO;
using System.Net;
using System.Security.AccessControl;

namespace Chapter4
{
    public static class WebRequestExample
    {
        public static void ExampleOfWebRequest()
        {
            WebRequest request = WebRequest.Create("http://www.google.com");
            WebResponse response = request.GetResponse();

            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            string responseText = responseStream.ReadToEnd();

            System.Console.WriteLine(responseText); // displays the html of the web site

            response.Close();
        }
    }
}