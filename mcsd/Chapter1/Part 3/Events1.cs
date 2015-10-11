using System;

namespace Chapter1
{
    public class Pub1
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }
    public class Events1
    {
        public static void Run()
        {
            Pub1 p = new Pub1();
            p.OnChange += () => Console.WriteLine("Method one raised");
            p.OnChange += () => Console.WriteLine("Method two raised");
            p.Raise();
        }
    }
}
// output
