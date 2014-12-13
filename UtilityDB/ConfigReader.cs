using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JentrousMarketing.UtilityDB
{
    class ConfigReader
    {
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        private const int keysize = 256;

        private static string host;        
        private static string port;
        private static string database;
        private static string user;
        private static string password;

        public static void readFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Config.xml");

            host = xmlDoc.SelectSingleNode("Config/host").InnerText;
            port = xmlDoc.SelectSingleNode("Config/port").InnerText;
            database = xmlDoc.SelectSingleNode("Config/database").InnerText;
            user = xmlDoc.SelectSingleNode("Config/user").InnerText;
            //password = Decrypt(xmlDoc.SelectSingleNode("Config/pass").InnerText, "jentrous");
            password = xmlDoc.SelectSingleNode("Config/pass").InnerText;
        }

        private static string Decrypt(string cipherText, string passPhrase)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
            {
                byte[] keyBytes = password.GetBytes(keysize / 8);
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.Mode = CipherMode.CBC;
                    using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                    {
                        using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        public static string Host
        {
            get { return ConfigReader.host; }
        }

        public static string Port
        {
            get { return ConfigReader.port; }
        }

        public static string Database
        {
            get { return ConfigReader.database; }
        }

        public static string User
        {
            get { return ConfigReader.user; }
        }

        public static string Password
        {
            get { return ConfigReader.password; }
        }
    }
}
