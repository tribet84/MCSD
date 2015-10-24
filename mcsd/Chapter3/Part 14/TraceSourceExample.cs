using System.Diagnostics;

namespace Chapter3
{
    public static class TraceSourceExample
    {
        public static void HowToUseTheTraceSourceClass()
        {
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.TraceInformation("Tracing app");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });

            traceSource.Flush();
            traceSource.Close();
        }
    }
}
// OUTPUT:
// myTraceSource Information: 0 : Tracing app
// myTraceSource Critical: 0 : Critical trace
// myTraceSource Information: 1 : a, b, c