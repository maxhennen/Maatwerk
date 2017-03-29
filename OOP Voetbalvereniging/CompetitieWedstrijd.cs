using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Voetbalvereniging
{
    [Serializable]
    public class CompetitieWedstrijd : Wedstrijd
    {
        public string Scheidsrechter { get; private set; }
        public CompetitieWedstrijd(Team teamThuis, Team teamUit, int doelpuntenThuis, int doelpuntenUit,string scheidsrechter) : base(teamThuis, teamUit, doelpuntenThuis, doelpuntenUit)
        {
            Scheidsrechter = scheidsrechter;
        }
    }
}
