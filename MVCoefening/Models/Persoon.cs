using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCoefening.Models
{
    public class Persoon
    {
        public string Naam { get; private set; }
        public List<Persoon> personen { get; private set; }

        public Persoon(string naam)
        {
            Naam = naam;
        }
    }
}