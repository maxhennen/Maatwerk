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
            foreach (Team T in Competitie.Teams)
            {
                cbThuis.Items.Add(T.Naam);
                cbUit.Items.Add(T.Naam);
            }

            lbTeams.Items.Clear();
            Competitie.Teams.Sort();
            foreach (Team T in Competitie.Teams)
            {
                lbTeams.Items.Add(T.ToString());
            }
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Competitie.CompetitieOpslaan(fbd.SelectedPath);
            }
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Competitie.CompetitieLaden(fbd.SelectedPath);
            }
            RefreshListBoxTeams();
        }

        private void btnWedstrijdAanmaken_Click(object sender, EventArgs e)
        {
            Wedstrijd wedstrijd;

                if (chbOefenwedstrijd.Checked == true)
                {
                    foreach (Team T1 in Competitie.Teams)
                    {
                        foreach (Team T2 in Competitie.Teams)
                        {
                            if (T1.Naam == cbThuis.Text)
                            {
                                if (T2.Naam == cbUit.Text)
                                {
                                    wedstrijd = new OefenWedstrijd(T1, T2, (int) nuDoelpuntenThuis.Value,
                                        (int) nuDoelpuntenUit.Value);
                                    T1.Wedstrijden.Add(wedstrijd);
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (Team T1 in Competitie.Teams)
                    {
                        if (T1.Naam == cbThuis.Text)
                        {
                            foreach (Team T2 in Competitie.Teams)
                            {
                                if (T2.Naam == cbUit.Text)
                                {
                                    wedstrijd = new CompetitieWedstrijd(T1, T2, (int) nuDoelpuntenThuis.Value,
                                        (int) nuDoelpuntenUit.Value, tbScheidsrechter.Text);
                                    Competitie.NieuweWedstrijd((CompetitieWedstrijd) wedstrijd);
                                    T1.NieuweWedstrijd(wedstrijd);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
        }

        private void btnToonWedstrijden_Click(object sender, EventArgs e)
        {
            foreach (Team T in Competitie.Teams)
            {
                if (lbTeams.GetItemText(lbTeams.SelectedItem) == T.Naam)
                {
                    lbWedstrijdenTeam.DataSource = T.Wedstrijden;
                    lbWedstrijdenTeam.ValueMember = "TeamThuis";
                }
            }
        }
    }
}
