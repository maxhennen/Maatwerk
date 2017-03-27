using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesApp
{
    public partial class GamesAppForm : Form
    {
        private GamesApp GamesApp;
        public GamesAppForm()
        {
            GamesApp = new GamesApp();
            InitializeComponent();
        }

        private void btnGameToevoegen_Click(object sender, EventArgs e)
        {
            GamesApp.Games.Clear();
            GamesListVullen();
            Game game = new Game(tbTitel.Text,(Genres)Enum.Parse(typeof(Genres),cbGenres.Text),(Platforms)Enum.Parse(typeof(Platforms),cbPlatforms.Text),Convert.ToDouble(nUDPrijs.Value));
            if (GamesApp.VoegGameToe(game))
            {
                MessageBox.Show(game.Titel + " is Toegevoegd");
                RefreshListbox();
            }
            else
            {
                MessageBox.Show(game.Titel + " bestaat al");
            }
        }

        public void GamesListVullen()
        {
            GamesApp.Games.Add(new Game("Call of Duty 4",Genres.Shooter, Platforms.PC, 49.99));
            GamesApp.Games.Add(new Game("CSGO",Genres.Shooter, Platforms.PC, 10.00));
            GamesApp.Games.Add(new Game("Fifa 17",Genres.Sport, Platforms.Playstation4, 70.00));
            GamesApp.Games.Add(new Game("GTA 5",Genres.Actie, Platforms.XBOXOne, 50.00));
        }

        private void GamesAppForm_Load(object sender, EventArgs e)
        {
            GamesListVullen();
            cbPlatforms.DataSource = Enum.GetValues(typeof(Platforms));
            cbGenres.DataSource = Enum.GetValues(typeof(Genres));
            cbFilterGenre.DataSource = Enum.GetValues(typeof(Genres));
            cbFilterPlatform.DataSource = Enum.GetValues(typeof(Platforms));
            RefreshListbox();
        }

        public void RefreshListbox()
        {
            lbGames.Items.Clear();
            foreach (Game G in GamesApp.Games)
            {
                lbGames.Items.Add(G.AlsString(G));
            }
        }

        private void clbFilterGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbFilterGames.SelectedItem == "Duurste")
            {
                cbFilterGenre.Visible = false;
                cbFilterPlatform.Visible = false;
            }

            else if (clbFilterGames.SelectedItem == "Genre")
            {
                cbFilterGenre.Visible = true;
                cbFilterPlatform.Visible = false;
            }

            else if (clbFilterGames.SelectedItem == "Platform")
            {
                cbFilterGenre.Visible = false;
                cbFilterPlatform.Visible = true;
            }
        }

        public List<Game> FilterGames()
        {
            lbGames.Items.Clear();
            List<Game> GamesFilter = new List<Game>();
            GamesFilter.Clear();
            if (clbFilterGames.GetItemText(clbFilterGames.SelectedItem) == "Duurste Game")
            {
                GamesFilter =
                    (from g in GamesApp.Games orderby g.Prijs descending select new Game(g.Titel, g.Genre, g.Platform, g.Prijs))
                    .Take(1).ToList<Game>();
            }

            else if (clbFilterGames.SelectedItem == "Genre")
            {
                Genres genre = (Genres)Enum.Parse(typeof(Genres), cbFilterGenre.Text);
                GamesFilter =
                    (from g in GamesApp.Games
                        where g.Genre == genre
                        select new Game(g.Titel, g.Genre, g.Platform, g.Prijs)).ToList<Game>();
            }

            else if (clbFilterGames.SelectedItem == "Platform")
            {
                Platforms platform = (Platforms)Enum.Parse(typeof(Platforms), cbFilterPlatform.Text);
                GamesFilter =
                    (List<Game>)
                    (from g in GamesApp.Games
                        where g.Platform == platform
                        select new Game(g.Titel, g.Genre, g.Platform, g.Prijs)).ToList<Game>();
            }
            return GamesFilter;
        }

        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            foreach (Game g in FilterGames())
            {
                lbGames.Items.Add(g.AlsString(g));
            }
        }
    }
}
