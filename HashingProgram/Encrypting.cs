using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingProgram
{
    public class Encrypting
    {
        public string Encrypt(string text)
        {
            byte[] encrypted;
            using (Rijndael rijndael = new RijndaelManaged())
            {
                rijndael.GenerateKey();
                rijndael.GenerateIV();
                encrypted = EncryptStringToBytes(text, rijndael.Key, rijndael.IV);
            }
            string s = Encoding.UTF8.GetString(encrypted);
            return s;
        }

        public byte[] EncryptStringToBytes(string plaintext, byte[] key, byte[] IV)
        {
            if (plaintext == null || plaintext.Length <= 0)
            {
                throw new ArgumentNullException("plaintext");
            }

            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            byte[] encrypted;

            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.Key = key;
                rijndael.IV = IV;

                ICryptoTransform encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

    }
}
