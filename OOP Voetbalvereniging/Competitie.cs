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
    public class Competitie:IStandComparer
    {
        public List<Team> Teams { get; private set; }
        public List<CompetitieWedstrijd> Wedstrijden { get; private set; }

        public Competitie()
        {
            Teams = new List<Team>();
            Wedstrijden = new List<CompetitieWedstrijd>();
        }

        public void NieuweWedstrijd(CompetitieWedstrijd wedstrijd, CompetitieGewijzigd gewijzigd)
        {
                if (wedstrijd.TeamThuis == wedstrijd.TeamUit || wedstrijd.DoelpuntenThuis < 0 || wedstrijd.DoelpuntenUit < 0)
                {
                    throw new OngeldigeWedstrijdException("");
                }
                else
                {
                    Wedstrijden.Add(wedstrijd);
                    wedstrijd.TeamThuis.Wedstrijden.Add(wedstrijd);
                    wedstrijd.TeamUit.Wedstrijden.Add(wedstrijd);
                }
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
            Teams.Sort(new IStandComparer.SorteerOpBehaaldePunten());
            string stand = "";
            int counter = 0;
            foreach (Team T in Teams)
            {
                counter++;
                stand += String.Format("{0,2}.   	{1,-22}	{2,2}\r\n", counter, T.Naam, T.Behaaldpunten());
            }
            return stand;
        }

        public void CompetitieOpslaan(string map,string data)
        {
            TeamsOpslaan(map);
            WedstrijdenOpslaan(map);
            StandOpslaan(data);
        }

        public void TeamsOpslaan(string map)
        {
            File.WriteAllText(map + "\\Teams.txt", String.Empty);
            FileIOPermission perm = new FileIOPermission(FileIOPermissionAccess.Write, map);
            if (SecurityManager.IsGranted(perm))
            {
                TextWriter tw = new StreamWriter(map + "\\Teams.txt");
                foreach (Team t in Teams)
                {
                    tw.WriteLine(t.Naam);
                }
                tw.Close();
            }
        }

        public void WedstrijdenOpslaan(string map)
        {
            File.WriteAllText(map + "\\Wedstrijden.txt",String.Empty);
            FileIOPermission perm = new FileIOPermission(FileIOPermissionAccess.Write,map);
            if (SecurityManager.IsGranted(perm))
            {
                TextWriter tw = new StreamWriter(map + "\\Wedstrijden.txt");
                foreach (CompetitieWedstrijd W in Wedstrijden)
                {
                    tw.WriteLine(W.TeamThuis+":"+W.TeamUit+":"+W.DoelpuntenThuis+":"+W.DoelpuntenUit+":"+W.Scheidsrechter);
                }
                tw.Close();
            }
        }

        public void CompetitieLaden(string map)
        {
            TeamsLaden(map);
            WedstrijdenLaden(map);
            StandLaden();
        }

        public void TeamsLaden(string map)
        {
            string[] lines = File.ReadAllLines(map + "\\Teams.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Teams.Add(new Team(lines[i]));
            }
        }

        public void WedstrijdenLaden(string map)
        {
            string[] lines = File.ReadAllLines(map + "\\Wedstrijden.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] substring = lines[i].Split(':');
                CompetitieWedstrijd cw = new CompetitieWedstrijd(new Team(substring[0]), new Team(substring[1]),Convert.ToInt32(substring[2]),Convert.ToInt32(substring[3]),substring[4]);
                foreach (Team T in Teams)
                {
                    if (T.Naam == cw.TeamThuis.Naam || T.Naam == cw.TeamUit.Naam)
                    {
                        NieuweWedstrijd(cw);
                    }
                }
            }
        }

        public void StandOpslaan(string data)
        {
            File.WriteAllText("E:\\Users\\maxhe\\Desktop\\Stand.txt", String.Empty);
            File.WriteAllText("E:\\Users\\maxhe\\Desktop\\Stand.txt", data);
        }

        public void StandLaden()
        {
            string stand = "";
            string[] lines = File.ReadAllLines("E:\\Users\\maxhe\\Desktop\\Stand.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                stand += lines[i];
            }
        }

        public delegate void CompetitieGewijzigd();
    }
}
