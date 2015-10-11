using System;
using System.Security.Cryptography;
using System.Text;

namespace Chapter3
{
    class RSAEncryption
    {
        private static string privateKeyXML;
        private static string publicKeyXML;

        public static void EncryptSomeText()
        {
            //Init keys
            GeneratePublicAndPrivateKeys();

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My ultra secret message!");

            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXML);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXML);
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine(decryptedString);
        }

        public static void GeneratePublicAndPrivateKeys()
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                publicKeyXML = RSA.ToXmlString(false);
                privateKeyXML = RSA.ToXmlString(true); // true: exports the private part of your key
            }
        }
    }
}
// OUTPUT:
// My ultra secret message!