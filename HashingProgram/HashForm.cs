using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashingProgram
{
    public partial class HashForm : Form
    {
        private Encrypting encrypting;
        private Decrypting decrypting;
        public HashForm()
        {
            encrypting = new Encrypting();
            decrypting = new Decrypting();
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbDecrypt.Text = encrypting.Encrypt(CreateKeys().Item1, tbEncrypt.Text).ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbEncrypt.Text = decrypting.Decrypt(CreateKeys().Item2, Encoding.UTF8.GetBytes(tbDecrypt.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateKeys();
        }
        public static Tuple<string, string> CreateKeys()
        {
            CspParameters cspParameters = new CspParameters { ProviderType = 1 };
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider(1024, cspParameters);
            string publicKey = Convert.ToBase64String(rsaCrypto.ExportCspBlob(false));
            string privateKey = Convert.ToBase64String(rsaCrypto.ExportCspBlob(true));

            return new Tuple<string, string>(privateKey, publicKey);
        }
    }
}
