using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    // Event publisher
    public class Pub4
    {
        public event EventHandler<EventArgs> OnChange = delegate { };

        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }

    public class Events4
    {
        public void CreateAndRaise()
        {
            Pub4 p = new Pub4();

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
                => { throw new Exception(); };
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
    }
}
// output
// Subscriber 1 called
// Subscriber 3 called
// 1