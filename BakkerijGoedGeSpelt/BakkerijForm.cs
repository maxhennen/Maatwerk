using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijGoedGeSpelt
{
    public partial class bakkerijForm : Form
    {
        private  Bakkerij bakkerij = new Bakkerij("Bakker");
        public bakkerijForm()
        {
            InitializeComponent();
           

        }

        private void bakkerijForm_Load(object sender, EventArgs e)
        {
            foreach (Brood brood in bakkerij.LaadBroodsoortenUitBestand())
            {
                cbBroodSoorten.Items.Add(brood.Beschrijving);
            }
        }

        private void btHaalBroodjesOp_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Broodje broodje in bakkerij.HaalBroodjesOp())
                {
                    if (broodje.Naam == null)
                    {
                        lbBroodjes.Items.Add(broodje.NaamPrijs(broodje.Naam,broodje.Prijs));
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Bestand is leeg");
            }
        }

        private void btMaakPrijsLijst_Click(object sender, EventArgs e)
        {
            bakkerij.MaakPrijsLijst();
        }

        private void btSlaBroodjesOp_Click(object sender, EventArgs e)
        {
            bakkerij.SlaBroodjesOp();
        }
    }
}
