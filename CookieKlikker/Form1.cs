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

namespace CookieKlikker
{
    public partial class Form1 : Form
    {
        private KoekjesController koekjesController;
        private Upgrade bakker;
        private Upgrade oven;
        private Upgrade deegroller;
        public Form1()
        {
            InitializeComponent();
            koekjesController = new KoekjesController();
            bakker = new Upgrade("Bakker", 10, 100, 150);
            oven = new Upgrade("Oven",50,2000,450);
            deegroller = new Upgrade("Deegroller",0,3500,700);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Laden();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes + koekjesController.Kps;
            UpdateKoekjes();
        }

        private void UpdateKoekjes()
        {
            lblKoekjes.Text = "Koekjes: " + koekjesController.Koekjes;
            lblKPS.Text = "KPS: " + koekjesController.Kps;
            ControleerUpdate();
        }

        private void ControleerUpdate()
        {
                btnBakker.Enabled = false;
                btnOven.Enabled = false;
                btnDeegroller.Enabled = false;

            if (bakker.Prijs <= koekjesController.Koekjes)
            {
                btnBakker.Enabled = true;
            }

            if(oven.Prijs <= koekjesController.Koekjes)
            {
                btnBakker.Enabled = true;
                btnOven.Enabled = true;
            }

            if (deegroller.Prijs <= koekjesController.Koekjes)
            {
                btnBakker.Enabled = true;
                btnOven.Enabled = true;
                btnDeegroller.Enabled = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes + koekjesController.KoekjesPerKlik;
            UpdateKoekjes();
        }

        private void btnBakker_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - bakker.Prijs;
            koekjesController.Kps = koekjesController.Kps + 10;
            bakker = new Upgrade("Bakker",10,bakker.Prijs + bakker.PrijsInterval,150);
            UpdateButtons();
            UpdateKoekjes();
        }

        private void btnOven_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - oven.Prijs;
            koekjesController.Kps = koekjesController.Kps + 50;
            oven = new Upgrade("Oven",50,oven.Prijs + oven.PrijsInterval,450);
            UpdateButtons();
            UpdateKoekjes();
        }

        private void btnDeegroller_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - deegroller.Prijs;
            koekjesController.KoekjesPerKlik = koekjesController.KoekjesPerKlik + 10;
            deegroller = new Upgrade("Deegroller",0,deegroller.Prijs + deegroller.PrijsInterval,700);
            UpdateButtons();
            UpdateKoekjes();
        }

        private void Opslaan()
        {
            List<string> Lines = new List<string>();
            Lines.Add(("Koekjes:" + Convert.ToString(koekjesController.Koekjes)));
            Lines.Add("Kps:" + Convert.ToString(koekjesController.Kps));
            Lines.Add("KoekjesPerKlik: " + Convert.ToString(koekjesController.KoekjesPerKlik));
            Lines.Add(bakker.Naam + ":" + bakker.Kps + ":" + bakker.Prijs + ":" + bakker.PrijsInterval);
            Lines.Add(oven.Naam + ":" + oven.Kps + ":" + oven.Prijs + ":" + oven.PrijsInterval);
            Lines.Add(deegroller.Naam + ":" + deegroller.Kps + ":" + deegroller.Prijs + ":" + deegroller.PrijsInterval);

            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Cookie.txt";
                save.Filter = "Text File | *.txt";
                
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    for (int i = 0; i < Lines.Count; i++)
                    {
                        writer.WriteLine(Lines[i].ToString());
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Laden()
        {
            OpenFileDialog f = new OpenFileDialog();
            List<string> lines = new List<string>();
            if (f.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                koekjesController.Koekjes = GegevensLaden(lines[0]);
                koekjesController.Kps = GegevensLaden(lines[1]);
                koekjesController.KoekjesPerKlik = GegevensLaden(lines[2]);

                bakker = UpgradesLaden(lines[3]);
                oven = UpgradesLaden(lines[4]);
                deegroller = UpgradesLaden(lines[5]);
                UpdateKoekjes();
                UpdateButtons();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Opslaan();
        }

        private int GegevensLaden(string txtGegevens)
        {
            string gegevens = txtGegevens;
            string[] substring = gegevens.Split(':');
            return Convert.ToInt32(substring[1]);
        }
        
        private Upgrade UpgradesLaden(string txtGegevens)
        {
            string[] substring = txtGegevens.Split(':');
            Upgrade upgrade = new Upgrade(substring[0].ToString(),Convert.ToInt32(substring[1]),Convert.ToInt32(substring[2]),Convert.ToInt32(substring[3]));
            return upgrade;
        }

        private void UpdateButtons()
        {
            btnBakker.Text = "Bakker (" + bakker.Prijs + ")";
            btnOven.Text = "Oven (" + oven.Prijs + ")";
            btnDeegroller.Text = "Deegroller (" + deegroller.Prijs + ")";
        }
    }
}
