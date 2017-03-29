using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Voetbalvereniging
{
    public class OefenWedstrijd : Wedstrijd
    {
        public OefenWedstrijd(Team teamThuis, Team teamUit, int doelpuntenThuis, int doelpuntenUit) : base(teamThuis, teamUit, doelpuntenThuis, doelpuntenUit)
        {
        }
    }
}
