using System;
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
       
        public bakkerijForm()
        {
            InitializeComponent();
           

        }

        private void bakkerijForm_Load(object sender, EventArgs e)
        {

        }

        private void btHaalBroodjesOp_Click(object sender, EventArgs e)
        {
            Bakkerij b = new Bakkerij("ffss");
            b.LaadBroodsoortenUitBestand();
        }
    }
}
