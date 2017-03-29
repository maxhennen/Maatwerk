using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Voetbalvereniging
{
    public class Competitie
    {
        public List<Team> Teams { get; private set; }
        public List<CompetitieWedstrijd> Wedstrijden { get; private set; }

        public Competitie()
        {
            Teams = new List<Team>();
            Wedstrijden = new List<CompetitieWedstrijd>();
        }

        public void NieuweWedstrijd(CompetitieWedstrijd wedstrijd)
        {
            Wedstrijden.Add(wedstrijd);
        }

        public bool NieuwTeam(string naam)
        {
            bool nieuwTeam = false;
            int counter = 0;
            foreach (Team team in Teams)
            {
                if (team.Naam == naam)
                {
                    counter++;
                }
            }

            if (Teams.Count == 0 || counter <= 0)
            {
                Team t = new Team(naam);
                Teams.Add(t);
                nieuwTeam = true;
            }
            return nieuwTeam;
        }

        public bool VerwijderTeam(Team team)
        {
            foreach (Team T in Teams)
            {
                if (T == team)
                {
                    Teams.Remove(T);
                    return true;
                }
            }
            return false;
        }

        public string GenereerStand()
        {
            return "";
        }

        public void CompetitieOpslaan(string map)
        {
            FileIOPermission perm = new FileIOPermission(FileIOPermissionAccess.Write,map);
            if (SecurityManager.IsGranted(perm))
            {
                FileStream fs = new FileStream(map + "\\Teams.bin", FileMode.Append, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Teams);
                fs.Close();
            }
        }

        public void CompetitieLaden(string map)
        {
            byte[] bin = null;
            object obj = null;

            FileStream fs = new FileStream(map + "\\Teams.bin",FileMode.Open);

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
            Teams = (List<Team>) obj;
        }
    }
}
