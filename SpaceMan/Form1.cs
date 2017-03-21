using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceMan
{
    public partial class SpaceManForm : Form
    {
        private SpaceControl spaceControl;
        private SpaceMan spaceMan;
        public SpaceManForm()
        {
            InitializeComponent();
            spaceControl = new SpaceControl();

            GenereerData();
        }

        public void GenereerData()
        {
            spaceMan = new SpaceMan("Max",20);
            spaceMan.VoegBezochtePlaneetToe(new Planeet("Zorg", true, Convert.ToDateTime("01 / 01 / 2017 00:00:00"), Convert.ToDateTime("03/01/2017")));
            spaceMan.VoegBezochtePlaneetToe(new Planeet("Tatooine", true, Convert.ToDateTime("01 / 02 / 2017 00:00:00"), Convert.ToDateTime("03/02/2017")));
            spaceMan.VoegBezochtePlaneetToe(new Planeet("Jupiter", false, Convert.ToDateTime("10 / 01 / 2017 00:00:00"), Convert.ToDateTime("14/01/2017")));
            spaceMan.VoegBezochtePlaneetToe(new Planeet("Mars", false, Convert.ToDateTime("21 / 01 / 2017 00:00:00"), Convert.ToDateTime("22/01/2017")));
            spaceMan.VoegBezochtePlaneetToe(new Planeet("Saturnus", false, Convert.ToDateTime("23 / 01 / 2017 00:00:00"), Convert.ToDateTime("30/01/2017")));

            SpaceMan spaceMan1 = new SpaceMan("Hoi",29);
            spaceMan1.VoegBezochtePlaneetToe(new Planeet("Zorg", true, Convert.ToDateTime("01 / 01 / 2017 00:00:00"), Convert.ToDateTime("05/01/2017")));
            spaceMan1.VoegBezochtePlaneetToe(new Planeet("Tatooine", true, Convert.ToDateTime("01 / 01 / 2017 00:00:00"), Convert.ToDateTime("03/01/2017")));
            spaceMan1.VoegBezochtePlaneetToe(new Planeet("Jupiter", false, Convert.ToDateTime("01 / 01 / 2017 00:00:00"), Convert.ToDateTime("02/01/2017")));
            spaceMan1.VoegBezochtePlaneetToe(new Planeet("Mars", false, Convert.ToDateTime("01 / 01 / 2017 00:00:00"), Convert.ToDateTime("03/01/2017")));
            spaceMan1.VoegBezochtePlaneetToe(new Planeet("Saturnus", false, Convert.ToDateTime("08 / 01 / 2017 00:00:00"), Convert.ToDateTime("10/01/2017")));
            spaceControl.SpaceMans.Add(spaceMan1);
            spaceControl.SpaceMans.Add(spaceMan);
        }

        private void btHaalPlaneten_Click(object sender, EventArgs e)
        {
            lbPlaneten.Items.Clear();
            foreach (Planeet p in spaceMan.HaalBezochteBewoondePlaneten())
            {
                lbPlaneten.Items.Add(p.Naam);
            }
        }

        private void btnPlaneten_Click(object sender, EventArgs e)
        {
            foreach (SpaceMan S in spaceControl.SpaceManZelfdeTijdOpPlaneet(spaceMan))
            {
                lbPlaneten.Items.Add(S.Naam);
            }
        }
    }
}
