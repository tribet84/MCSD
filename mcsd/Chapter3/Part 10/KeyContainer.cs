using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Chapter3
{
    class KeyContainer
    {
        public static void ContainerUsage()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My ultra secret message!");

            string containerName = "MySecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };

            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
        }
    }
}