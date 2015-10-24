using System.Diagnostics;

namespace Chapter3
{
    public static class ReadEventLog
    {
        public static void HowToReadEventLog()
        {
            // Reading...
            EventLog log = new EventLog("MyNewLog");

            System.Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            System.Console.WriteLine("Index: " + last.Index);
            System.Console.WriteLine("Source: " + last.Source);
            System.Console.WriteLine("Type: " + last.EntryType);
            System.Console.WriteLine("Time: " + last.TimeWritten);
            System.Console.WriteLine("Message: " + last.Message);
        }

        // OUTPUT
        // Total entries: 1
        // Index: 1
        // Source: MySource
        // Type: Information
        // Time: 11/10/2015 17:45:40
        // Message: Log event triggered!

        public static void SubscribeToEventLog()
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
                {
                    System.Console.WriteLine(e.Entry.Message);
                };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            System.Console.ReadKey();
        }
    }
}