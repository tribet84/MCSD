using System.Diagnostics;
using System.IO;

namespace Chapter3
{
    public static class TraceSourceListenerExample
    {
        public static void HowToUseTheTraceListenerClass()
        {
            Stream outputFile = File.Create("traceFile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);

            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);

            traceSource.TraceInformation("Tracing app");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });

            traceSource.Flush();
            traceSource.Close();
        }
    }
}