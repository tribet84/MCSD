using System;
using System.IO;

namespace Chapter2
{
    class UnmanagedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }

        public UnmanagedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }

        ~UnmanagedWrapper()
        {
            Dispose(false);
        }

        public void Close()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }
}