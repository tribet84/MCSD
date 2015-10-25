using System.IO;
using System.Text;

namespace Chapter4
{
    public static class CompareFileStreamReader
    {
        public static void HowToReadAFile()
        {
            string path = @"c:\temp\test.txt";

            // read a file using a FileStream object
            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];

                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }
                System.Console.WriteLine(Encoding.UTF8.GetString(data));
            }

            // read a file using a StreamReader object
            using(StreamReader reader = File.OpenText(path))
            {
                System.Console.WriteLine(reader.ReadLine());
            }
        }
    }
}