using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingProgram
{
    public class Decrypting
    {
        //Encrypting encrypting = new Encrypting();
        //public string Decrypt(string encrypt)
        //{
        //    string decrypt;
        //    byte[] y = Encoding.UTF8.GetBytes(encrypt);
        //    using (Rijndael rijndael = new RijndaelManaged())
        //    {
        //        decrypt = DecryptStringFromBytes(y, encrypting.Rijndael.Key, encrypting.Rijndael.IV);
        //    }
        //    return decrypt;
        //}
        //
        //
        //public string DecryptStringFromBytes(byte[] encryptText,byte[] Key, byte[] IV)
        //{
        //        if (encryptText == null || encryptText.Length <= 0)
        //        {
        //            throw new ArgumentNullException("encryptText");
        //        }
        //
        //        string decrypt = null;
        //
        //        using (RijndaelManaged rijndael = new RijndaelManaged())
        //        {
        //            rijndael.Key = Key;
        //            rijndael.IV = IV;
        //
        //            ICryptoTransform decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);
        //
        //            using (MemoryStream msDecrypt = new MemoryStream(encryptText))
        //            {
        //                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        //                {
        //                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
        //                    {
        //                        decrypt = srDecrypt.ReadToEnd();
        //                    }
        //                }
        //            }
        //        return decrypt;
        //    }
        //}

        public string Decrypt(string privateKey, byte[] encryptedBytes)
        {
            CspParameters cspParameters = new CspParameters { ProviderType = 1 };
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider(cspParameters);
            rsaCrypto.ImportCspBlob(Convert.FromBase64String(privateKey));
            byte[] plainBytes = rsaCrypto.Decrypt(encryptedBytes, false);
            string plainText = Encoding.UTF8.GetString(plainBytes, 0, plainBytes.Length);

            return plainText;
        }
    }
}