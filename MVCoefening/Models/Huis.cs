using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCoefening.Models
{
    public class Huis
    {
        public List<Persoon> Personen()
        {
            List<Persoon> personen = new List<Persoon>();
            personen.Add(new Persoon("Max"));
            personen.Add(new Persoon("Henk"));
            personen.Add(new Persoon("Piet"));
            return personen;
        }
    }
}