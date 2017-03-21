using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moestijn
{
    public partial class Form1 : Form
    {
        private Moestuin Moestuin;
        public Form1()
        {
            Moestuin = new Moestuin();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Moestuin.Vullijst();
            cbZaaitijd.DataSource = Enum.GetValues(typeof(Maand));
            List<Groente> cbGroente = Moestuin.Groenten.GroupBy(typeof(Groente)).ToList();
            cbKiesGroente.DataSource = Moestuin.Groenten;
        }
    }
}
