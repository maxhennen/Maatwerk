﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moestijn
{
    public partial class MoestuinForm : Form
    {
        private Moestuin Moestuin;
        public MoestuinForm()
        {
            Moestuin = new Moestuin();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Moestuin.Vullijst();
            cbZaaitijd.DataSource = Enum.GetValues(typeof(Maand));
            var groenten = (from g in Moestuin.Groenten select g.GetType());
            var distinctGroenten = groenten.Distinct();
            cbKiesGroente.DataSource = distinctGroenten.ToArray();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            var maand = (Maand) Enum.Parse(typeof(Maand), cbZaaitijd.Text);
            if (Moestuin.ZoekGroentes((object)cbKiesGroente.Text,maand).Count != 0)
            {
                lbGroente.DataSource = Moestuin.ZoekGroentes((object)cbKiesGroente.Text, maand);
                lbGroente.ValueMember = "Naam";
            }
            else
            {
                MessageBox.Show("Geen groente");
            }
        }
    }
}
