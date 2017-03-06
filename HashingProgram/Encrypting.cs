using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashingProgram
{
    public class Encrypting
    {
        //public byte[] Salt { get; private set; }
        //public Rijndael Rijndael = new RijndaelManaged(); 
        //public Encrypting()
        //{
        //    Salt = new byte[] { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c };
        //}
        //public string Encrypt(string text)
        //{
        //    byte[] encrypted;
        //
        //        Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(text,Salt);
        //        Rijndael.Key = rfc.GetBytes(32);
        //        Rijndael.IV = rfc.GetBytes(16);
        //        encrypted = EncryptStringToBytes(text);
        //    string s = Encoding.UTF8.GetString(encrypted);
        //    return s;
        //}
        //
        //public byte[] EncryptStringToBytes(string plaintext)
        //{
        //    if (plaintext == null || plaintext.Length <= 0)
        //    {
        //        throw new ArgumentNullException("plaintext");
        //    }
        //
        //    byte[] encrypted;
        //
        //        ICryptoTransform encryptor = Rijndael.CreateEncryptor(Rijndael.Key, Rijndael.IV);
        //
        //        using (MemoryStream msEncrypt = new MemoryStream())
        //        {
        //            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
        //                {
        //                    swEncrypt.Write(plaintext);
        //                }
        //                encrypted = msEncrypt.ToArray();
        //            }
        //        }
        //    return encrypted;
        //}

        public byte[] Encrypt(string publicKey, string data)
        {
            CspParameters cspParameters = new CspParameters {ProviderType = 1};
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider(cspParameters);
            rsaCrypto.ImportCspBlob(Convert.FromBase64String(publicKey));
            byte[] plainBytes = Encoding.UTF8.GetBytes(data);
            byte[] encryptedBytes = rsaCrypto.Encrypt(plainBytes, false);

            return encryptedBytes;
        }
    }
}
