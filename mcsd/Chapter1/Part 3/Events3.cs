using System;

namespace Chapter1
{
    // Event publisher
    public class Pub3
    {
        public event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }

        public void Run()
        {
            onChange(this, new MyArgs(20));
        }
    }
}