using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concertkaartjes
{
    public partial class ConcertkaartjesForm : Form
    {
        private List<Concert> Concerten;
        public ConcertkaartjesForm()
        {
            Concerten = new List<Concert>();
            ConcertListVullen();
            InitializeComponent();
        }

        private void ConcertListVullen()
        {
            Concerten.Add(new Concert("Sting", new DateTime(2014, 12, 3), 75));
            Concerten.Add(new Concert("U2", new DateTime(2015, 1, 14), 88));
            Concerten.Add(new Concert("Coldplay", new DateTime(2015, 7, 10), 110));
            Concerten.Add(new Concert("Afrojack", new DateTime(2014, 11, 17), 65));
            Concerten.Add(new Concert("The Killers", new DateTime(2015, 3, 25), 58));
            Concerten.Add(new Concert("Pitbull", new DateTime(2015, 2, 24), 96.5));
            Concerten.Add(new Concert("Beyonce", new DateTime(2015, 8, 1), 75));
            Concerten.Add(new Concert("Pink", new DateTime(2015, 11, 3), 82));
            Concerten.Add(new Concert("Adele", new DateTime(2015, 9, 25), 92.5));
        }

        private void RefreshListbox()
        {
            lbConcerten.Items.Clear();
            foreach (Concert c in Concerten)
            {
                lbConcerten.Items.Add(c.ConcertInfo);
            }
        }

        private void btnArtiest_Click(object sender, EventArgs e)
        {
            Concerten.Sort(new Concert.SorteerOpArtiest());
            RefreshListbox();
        }

        private void btnDatum_Click(object sender, EventArgs e)
        {
            Concerten.Sort(new Concert.SorteerOpDatum());
            RefreshListbox();
        }

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            Concerten.Sort(new Concert.SorteerOpPrijs());
            RefreshListbox();
        }

        private void lbConcerten_SelectedIndexChanged(object sender, EventArgs e)
        {
            BestelSchermInstellen();
        }

        public void BestelSchermInstellen()
        {
            gbBestellen.Visible = true;
            lblBesteldeKaarten.Visible = false;
            lblTotaalPrijs.Visible = false;
            string[] concert = lbConcerten.SelectedItem.ToString().Split(new[] {" - "}, StringSplitOptions.None);
            lblArtiest.Text = "Artiest: " + concert[0];
            lblDatum.Text = concert[1];
            lblPrijs.Text = "Prijs: " + concert[2];
        }
    }
}
