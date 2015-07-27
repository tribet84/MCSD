using System;

namespace Chapter1
{
    // Customized argument class
    public class MyArgs : EventArgs
    {
        public int Value { get; set; }

        public MyArgs(int value)
        {
            Value = value;
        }
    }

    // Event publisher
    public class Pub2
    {
        public event EventHandler<MyArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyArgs(20));
        }
    }

    // Event subscription
    public class Events2
    {
        public static void Run()
        {
            Pub2 p = new Pub2();

            p.OnChange += (sender, e)
                => Console.WriteLine("Event raised:{0}", e.Value);

            p.Raise();
        }
    }
}
// output
// Event raised:20