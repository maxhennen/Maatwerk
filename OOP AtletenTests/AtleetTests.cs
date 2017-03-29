using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Atleten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_Atleten.Tests
{
    [TestClass()]
    public class AtleetTests
    {
        [TestMethod()]
        public void SorteerTrainingenOpDatumTest()
        {
            Atleet Atleet = new Atleet("Max",20);
            Atleet.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("28-03-2017 13:00:00"), 30, 3, "Hardlopen", "Zon", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false)));
            Atleet.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("27-03-2017 12:30:00"), 45, 4, "lekker zwemmen", "vlinder", true, 2000));
            Atleet.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("26-03-2017 12:00:00"), 60, 4, "Rondje rennen", "regen", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false)));
            Atleet.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("25-03-2017 14:00:00"), 70, 3, "In de zee", "borst", false, 1500));
            
            Atleet Verwacht = new Atleet("Atleet",20);
            Verwacht.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("28-03-2017 13:00:00"), 30, 3, "Hardlopen", "Zon", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false)));
            Verwacht.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("27-03-2017 12:30:00"), 45, 4, "lekker zwemmen", "vlinder", true, 2000));
            Verwacht.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("26-03-2017 12:00:00"), 60, 4, "Rondje rennen", "regen", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false)));
            Verwacht.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("25-03-2017 14:00:00"), 70, 3, "In de zee", "borst", false, 1500));


            Atleet.SorteerTrainingenOpDatum();
            Assert.AreEqual(Verwacht,Atleet.Trainingen);
        }
    }
}