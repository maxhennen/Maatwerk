using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        private List<Character> Characters;
        private int counter = 0;
        public Form1()
        {
            Characters = new List<Character>();
            InitializeComponent();
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            if (Characters.Count == 0)
            {
                Character player1 = new Knight(lblPlayer.Text,10);
                Characters.Add(player1);
                lblPlayer.Text = "Player 2";
            }
            else
            {
                Character player2 = new Knight(lblPlayer.Text,10);
                Characters.Add(player2);
                Start();
                UpdateForm();
            }
        }

        private void btnWizard_Click(object sender, EventArgs e)
        {
            if (Characters.Count == 0)
            {
                Character player1 = new Wizard(lblPlayer.Text,10);
                Characters.Add(player1);
                lblPlayer.Text = "Player 2";
            }
            else
            {
                Character player2 = new Wizard(lblPlayer.Text,10);
                Characters.Add(player2);
                Start();
                UpdateForm();
            }
        }

        private void UpdateForm()
        {
            lblPlayer.Visible = false;
            btnKnight.Visible = false;
            btnWizard.Visible = false;
            gbPlayer1.Visible = true;
            gbPlayer2.Visible = true;

            foreach (Character c in Characters)
            {
                if (c.Naam == "Player 1")
                {
                    lblHitpoints1.Text = "Hitpoints: " + c.HitPoints;
                }
                else
                {
                    lblHitpoints2.Text = "Hitpoints: " + c.HitPoints;
                }
            }

            if (Start() % 2 ==0)
            {
                btnAttack1.Visible = true;
                btnAttack2.Visible = false;
            }

            else
            {
                btnAttack1.Visible = false;
                btnAttack2.Visible = true;
            }
        }

        private int Start()
        {
            counter++;
            Random r = new Random();
            int random = r.Next(1, 100);
            return random + counter;
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            Start();
            UpdateForm();
        }

        private void btnAttack2_Click(object sender, EventArgs e)
        {
            Start();
            UpdateForm();
        }
    }
}
