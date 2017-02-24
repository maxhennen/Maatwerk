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
    public partial class Form1 : Form
    {
        private Encrypting encrypting;
        private Decrypting decrypting;
        public Form1()
        {
            encrypting = new Encrypting();
            decrypting = new Decrypting();
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbDecrypt.Text = encrypting.Encrypt(tbEncrypt.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbEncrypt.Text = decrypting.Decrypt(encrypting.Encrypt(tbDecrypt.Text));
        }
    }
}
