﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijGoedGeSpelt
{
    public partial class bakkerijForm : Form
    {
        private  Bakkerij bakkerij = new Bakkerij("Bakker");
        public bakkerijForm()
        {
            InitializeComponent();
           

        }

        private void bakkerijForm_Load(object sender, EventArgs e)
        {
            foreach (Brood brood in bakkerij.LaadBroodsoortenUitBestand())
            {
                cbBroodSoorten.Items.Add(brood.Beschrijving);
            }
        }

        private void btHaalBroodjesOp_Click(object sender, EventArgs e)
        {
            foreach (Broodje broodje in bakkerij.HaalBroodjesOp())
            {
                lbBroodjes.Items.Add(broodje.Naam);
            }
        }
    }
}
