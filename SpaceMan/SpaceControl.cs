using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    public class SpaceControl
    {
        public List<SpaceMan> SpaceMans = new List<SpaceMan>();

        public SpaceMan Toevoegen(string naam, int leeftijd )
        {
            SpaceMan spaceMan = null;
            foreach (SpaceMan S in SpaceMans)
            {
                if (S.Naam == naam)
                {
                    return null;
                }

                else
                {
                    spaceMan = new SpaceMan(naam,leeftijd);
                }
            }
            return spaceMan;
        }

        public List<SpaceMan> SpaceManGegevenPlaneet(string planeet)
        {
            List<SpaceMan> SpacemanPlaneet = new List<SpaceMan>();
            foreach (SpaceMan S in SpaceMans)
            {
                foreach (Planeet P in S.PlanetenBezocht)
                {
                    if (P.Naam == planeet)
                    {
                        SpacemanPlaneet.Add(S);
                    }
                }
            }

            return SpacemanPlaneet;
        }

        public List<SpaceMan> SpaceManZelfdeTijdOpPlaneet(SpaceMan spaceMan)
        {
            List<SpaceMan> SpaceManZelfdePlaneet = new List<SpaceMan>();
            foreach (SpaceMan S in SpaceMans)
            {
                foreach (Planeet P in S.PlanetenBezocht)
                {
                    foreach (Planeet SPlaneet in spaceMan.PlanetenBezocht)
                    {
                        if (P.Naam == SPlaneet.Naam)
                        {
                            if (spaceMan.Naam != S.Naam)
                            {
                                if (P.Aangekomen <= SPlaneet.Aangekomen && P.Vertrek >= SPlaneet.Aangekomen)
                                {
                                    SpaceManZelfdePlaneet.Add(S);
                                }

                                else if (P.Aangekomen >= SPlaneet.Aangekomen && P.Vertrek <= SPlaneet.Aangekomen)
                                {
                                    SpaceManZelfdePlaneet.Add(S);
                                }
                            }
                        }
                    }
                }
            }
            return SpaceManZelfdePlaneet;
        }
        
    }
}
