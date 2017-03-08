using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijGoedGeSpelt
{
    public class Bakkerij
    {
        public string Naam { get; private set; }

        public Bakkerij(string naam)
        {
            Naam = naam;
        }

        public bool VoegBroodjeToe(Broodje broodje)
        {
            foreach (Broodje b in HaalBroodjesOp())
            {
                if (b.Naam == broodje.Naam)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public List<Brood> LaadBroodsoortenUitBestand()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            List<Brood> Broden = new List<Brood>();
            StringBuilder sb = new StringBuilder();
            string myString = null;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFile.FileName, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));
                    myString = Convert.ToBase64String(bin);
                }
            }
            MessageBox.Show(myString);
            return new List<Brood>();
        }

        public void MaakPrijsLijst()
        {
            
        }

        public void SlaBroodjesOp()
        {
            
        }

        public List<Broodje> HaalBroodjesOp()
        {
            return new List<Broodje>();
        }
    }
}
