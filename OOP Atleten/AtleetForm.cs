using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Atleten
{
    public partial class AtleetForm : Form
    {
        private Atleet Atleet;
        public AtleetForm()
        {
            Atleet = new Atleet("Max",20);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DummyData();
        }

        public void DummyData()
        {
            Atleet.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("28-03-2017 13:00:00"), 30, 3, "Hardlopen","Zon",new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang",20,5,50,false)));
            Atleet.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("27-03-2017 12:30:00"),45,4,"lekker zwemmen","vlinder",true,2000));
            Atleet.VoegTrainingToe(new Hardlooptrainings(Convert.ToDateTime("26-03-2017 12:00:00"),60,4,"Rondje rennen","regen", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false)));
            Atleet.VoegTrainingToe(new Zwemtraining(Convert.ToDateTime("25-03-2017 14:00:00"),70,3,"In de zee","borst",false,1500));

            Atleet.VoegBlessureToe(new Blessure("Gekneusde enkel","enkel",Convert.ToDateTime("10-10-2016 00:00:00")));
            Atleet.VoegBlessureToe(new Blessure("Gebroken vinger","linker duim",Convert.ToDateTime("09-09-2016 00:00:00")));

            Atleet.VoegSchoenToe(new Schoen(10,true,"Nike run"));
            Atleet.VoegSchoenToe(new Schoen(50,false,"Adidas run"));
        }

        private void btnSchoenen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Schoen S in Atleet.Schoenen)
            {
                listBox1.Items.Add(S.ToString());
            }
        }

        private void BtnBlessure_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Blessure B in Atleet.Blessures)
            {
                listBox1.Items.Add(B.ToString());
            }
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            if (cbSorteerTraining.SelectedItem == "Datum")
            {
                Atleet.SorteerTrainingenOpDatum();
                foreach (Training t in Atleet.Trainingen)
                {
                    listBox1.Items.Add(t.ToString());
                }
            }

            else if (cbSorteerTraining.SelectedItem == "Intensiteit en duur")
            {
                Atleet.SorteerOpIntensiteitEnTrainingsduur();
                foreach (Training training in Atleet.Trainingen)
                {
                    listBox1.Items.Add(training.ToString());
                }
            }
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Image I = Image.FromFile("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png");
            Training H = new Hardlooptrainings(Convert.ToDateTime("28-03-2017 14:20:00"),30,5,"leuk","zon", new Parcours("C:\\Users\\maxhe\\Source\\Repos\\Maatwerk\\OOP Atleten\\kaart.png", "lang", 20, 5, 50, false));
            Atleet.VoegTrainingToe(H);
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            TextWriter twWriter = new StreamWriter("training.txt");
            foreach (Training T in Atleet.Trainingen)
            {
                twWriter.WriteLine(T.ToString());
            }
            twWriter.Close();
        }
    }
}
