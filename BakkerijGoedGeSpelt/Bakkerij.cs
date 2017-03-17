using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijGoedGeSpelt
{
    public class Bakkerij
    {
        public List<Broodje> Broodjes { get; private set; } 
        public string Naam { get; private set; }
        public Bakkerij(string naam)
        {
            Broodjes = new List<Broodje>();
            Naam = naam;
        }

        public bool VoegBroodjeToe(Broodje broodje)
        {
            foreach (Broodje b in Broodjes)
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
            FileStream fs = new FileStream("BroodSoortenLijst-versie2.bin", FileMode.Open);
            return FromByteArray<List<Brood>>(fs);
        }
        
        public void MaakPrijsLijst()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            File.WriteAllText(saveFile.FileName, String.Empty);
            using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Broodje broodje in HaalBroodjesOp())
                    {
                        sw.WriteLine(broodje.NaamEnPrijs(broodje.Naam,broodje.Prijs));
                    }
                }
            }
        }

        public void SlaBroodjesOp()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.ShowDialog();
                File.WriteAllText(saveFile.FileName, string.Empty);
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Append, FileAccess.Write);
                ToByteArray(Broodjes, fs);
                fs.Close();
            }
            catch (ArgumentException)
            {

            }
        }

        public List<Broodje> HaalBroodjesOp()
        {
            Broodjes.Clear();
            Broodje b1 = new Broodje("q3regt",BelegSoort.Fruit);
            Broodje b2 = new Broodje("eregt",BelegSoort.Groente);
            Broodjes.Add(b1);
            Broodjes.Add(b2);
            //FileStream file = File.Create("broodjes.bin");
            //BinaryFormatter binary = new BinaryFormatter();
            //binary.Serialize(file,Broodjes);
            //file.Close();


            FileStream fs = File.Open("broodjes.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Broodje> broodjes = (List<Broodje>) bf.Deserialize(fs);
            fs.Close();
            //foreach (Broodje b in FromByteArray<List<Broodje>>(fs))
            //{
            //    Broodjes.Add(b);
            //}
            return Broodjes;
        }
        public T FromByteArray<T>(FileStream fs)
        {
            byte[] bin = null;
            object obj = null;

                if (fs.Length != 0)
                {
                    BinaryReader br = new BinaryReader(fs);
                    bin = br.ReadBytes(Convert.ToInt32(fs.Length));
                        BinaryFormatter bf = new BinaryFormatter();
                        fs.Write(bin, 0, bin.Length);
                        fs.Seek(0, SeekOrigin.Begin);
                        obj = bf.Deserialize(fs);
                }
            fs.Close();
            return (T)obj;
        }

        public FileStream ToByteArray(List<Broodje> broodjes, FileStream fs )
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,broodjes);
            return fs;
        }
    }
}
