using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class VoetbalverenigingForm : Form
    {
        private Competitie Competitie;
        public VoetbalverenigingForm()
        {
            InitializeComponent();
            Competitie = new Competitie();
        }

        private void btnTeamAanmaken_Click(object sender, EventArgs e)
        {
            if (Competitie.NieuwTeam(tbNieuwTeam.Text))
            {
                MessageBox.Show("Team is toegevoegd");
            }
            else
            {
                MessageBox.Show("Team bestaat al");
            }
            RefreshListBoxTeams();
        }

        private void RefreshListBoxTeams()
        {
            List<Team> Thuis = new List<Team>();
            List<Team> Uit = new List<Team>();
            foreach (Team T in Competitie.Teams)
            {
                Thuis.Add(T);
                Uit.Add(T);
            }

            cbThuis.DataSource = Thuis.Distinct().ToArray();
            cbThuis.ValueMember = "Naam";
            cbUit.DataSource = Uit.Distinct().ToArray();
            cbUit.ValueMember = "Naam";

            lbTeams.Items.Clear();
            Competitie.Teams.Sort();
            foreach (Team T in Competitie.Teams)
            {
                lbTeams.Items.Add(T.ToString());
            }
            tbStand.Text = Competitie.GenereerStand();
        }

        private void btnTeamVerwijderen_Click(object sender, EventArgs e)
        {
            foreach (Team T in Competitie.Teams)
            {
                if (lbTeams.GetItemText(lbTeams.SelectedItem) == T.Naam)
                {
                    if (Competitie.VerwijderTeam(T))
                    {
                        MessageBox.Show("Team is verwijderd");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets misgegaan");
                    }
                }
            }
            RefreshListBoxTeams();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWedstrijdAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                Wedstrijd wedstrijd = null;
                foreach (Team T1 in Competitie.Teams)
                {
                    foreach (Team T2 in Competitie.Teams)
                    {
                        if (T1.Naam == cbThuis.Text)
                        {
                            if (T2.Naam == cbUit.Text)
                            {
                                if (chbOefenwedstrijd.Checked)
                                {
                                    wedstrijd = new OefenWedstrijd(T1, T2, (int) nuDoelpuntenThuis.Value,
                                        (int) nuDoelpuntenUit.Value);
                                    T1.NieuweWedstrijd(wedstrijd);
                                    T2.NieuweWedstrijd(wedstrijd);
                                }
                                else
                                {
                                    wedstrijd = new CompetitieWedstrijd(T1, T2, (int) nuDoelpuntenThuis.Value,
                                        (int) nuDoelpuntenUit.Value, tbScheidsrechter.Text);
                                    Competitie.NieuweWedstrijd((CompetitieWedstrijd) wedstrijd);
                                }

                            }
                        }
                    }
                }
                MessageBox.Show("Wedstrijd is aangemaakt");
                RefreshListBoxTeams();
            }
            catch (OngeldigeWedstrijdException)
            {
                MessageBox.Show("Wedstrijd kon niet worden aangemaakt");
            }
            
        }

        private void btnToonWedstrijden_Click(object sender, EventArgs e)
        {
            lbWedstrijdenTeam.Items.Clear();
            foreach (Wedstrijd W in Competitie.Wedstrijden)
            {
                if (W.TeamThuis.Naam == lbTeams.GetItemText(lbTeams.SelectedItem) ||
                    W.TeamUit.Naam == lbTeams.GetItemText(lbTeams.SelectedItem))
                {
                    lbWedstrijdenTeam.Items.Add(W.ToString());
                }
            }

            var wedstrijden = (from W in Competitie.Wedstrijden
                where lbTeams.GetItemText(lbTeams.SelectedItem) == W.TeamThuis.Naam ||
                      lbTeams.GetItemText(lbTeams.SelectedItem) == W.TeamUit.Naam
                select W.ToString());
            var dubbelenVerwijderen = wedstrijden.Distinct();
            lbWedstrijdenTeam.DataSource = dubbelenVerwijderen.ToArray();
        }

        private void VoetbalverenigingForm_Load(object sender, EventArgs e)
        {
            Competitie.CompetitieLaden("E:\\Users\\maxhe\\Desktop");
            RefreshListBoxTeams();
        }

        private void VoetbalverenigingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Competitie.CompetitieOpslaan("E:\\Users\\maxhe\\Desktop",tbStand.Text);
        }

    }
}
