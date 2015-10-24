using System.Diagnostics;

namespace Chapter3
{
    public static class EventLogExample
    {
        public static void HowToWriteToEventLog()
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                System.Console.WriteLine("CreatedEventSource");
                System.Console.WriteLine("Please restart your application");
                System.Console.ReadKey();
                return;
            }

            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event triggered!");
        }
    }
}