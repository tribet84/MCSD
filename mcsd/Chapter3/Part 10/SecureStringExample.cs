using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Chapter3
{
    class SecureStringExample
    {
        public static void SecureAString()
        {
            using (SecureString ss = new SecureString()) // IDisposable implemented
            {
                Console.WriteLine("Please enter a password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                Console.WriteLine("\nPassword encrypted and stored succesfully!");
                ConvertToUnsecureString(ss);
                ss.MakeReadOnly();
            }
        }

        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            catch (Exception)
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
// OUTPUT
// Please enter a password:
// 
// Password encrypted and stored succesfully!
// 