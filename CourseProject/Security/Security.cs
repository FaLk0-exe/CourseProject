using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Security
{
    public static class Deserializer
    {


        public static T DeserializeBinary<T>(ref T obj, string filename)
        {

            BinaryFormatter reader = new BinaryFormatter();
            FileStream fs = new FileStream(filename, FileMode.Open);
            obj = (T)reader.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }

    public static class SecureChecker
    {
        public static bool CheckPassword(string checkedValue)
        {
            string r1 = "", r2 = "";
            r1 = Deserializer.DeserializeBinary<String>(ref r1, @"res\A56gngi10JK3hav.bin");
            r2 = Deserializer.DeserializeBinary<String>(ref r2, @"res\A79Ftja15jl.bin");
            if (Decrypter.Decrypt(r1, r2) == checkedValue)
                return true;
            return false;
        }
    }
    public static class Decrypter
    {

        public static string Decrypt(string cipher, string key)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

    }
}
