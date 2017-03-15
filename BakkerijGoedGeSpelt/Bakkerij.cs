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
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        for (int i = 0; i < ToByteArray(HaalBroodjesOp()).Length; i++)
                        {
                            sw.WriteLine(ToByteArray(HaalBroodjesOp())[i]);
                        }
                    }
                fs.Close();
            }
            catch (ArgumentException)
            {

            }
        }

        public List<Broodje> HaalBroodjesOp()
        {
            FileStream fs = new FileStream("broodjes.bin", FileMode.Open);
            return FromByteArray<List<Broodje>>(fs);
        }
        public T FromByteArray<T>(FileStream fs)
        {
            byte[] bin = null;
            object obj = null;

                if (fs.Length != 0)
                {
                    BinaryReader br = new BinaryReader(fs);
                    bin = br.ReadBytes(Convert.ToInt32(fs.Length));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        ms.Write(bin, 0, bin.Length);
                        ms.Seek(0, SeekOrigin.Begin);
                        obj = bf.Deserialize(ms);
                    }
                }
            fs.Close();
            return (T)obj;
        }

        public byte[] ToByteArray(List<Broodje> broodjes )
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms,broodjes);
                return ms.ToArray();
            }
        }
    }
}
