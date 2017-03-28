using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Atleet
    {
        public string Naam { get; private set; }
        public int Leeftijd { get; private set; }
        public List<Blessure> Blessures { get; private set; }
        public List<Schoen> Schoenen { get; private set; }
        public List<Training> Trainingen { get; private set; }

        public Atleet(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Blessures = new List<Blessure>();
            Schoenen = new List<Schoen>();
            Trainingen = new List<Training>();
        }

        public void VoegTrainingToe(Training training)
        {
            Trainingen.Add(training);
            if (training.GetType() == typeof(Hardlooptrainings))
            {
                foreach (Schoen S in Schoenen)
                {
                    if (S.InGebruik)
                    {
                        Hardlooptrainings hardloop = (Hardlooptrainings)training;
                        S.AantalKmOptellen(hardloop.Parcour.AfstandKm);
                    }
                }
            }
        }

        public void VoegBlessureToe(Blessure blessure)
        {
            Blessures.Add(blessure);
        }

        public void VoegSchoenToe(Schoen schoen)
        {
            Schoenen.Add(schoen);
        }

        public void SorteerTrainingenOpDatum()
        {
            Trainingen.Sort();
        }

        public void SorteerOpIntensiteitEnTrainingsduur()
        {
            Trainingen.Sort(new Training.SorteerOpIntensiteitEnTijdsduur());
        }


    }
}
