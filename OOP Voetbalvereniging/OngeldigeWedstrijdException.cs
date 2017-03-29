using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Voetbalvereniging
{
    public class OngeldigeWedstrijdException:Exception
    {
        public OngeldigeWedstrijdException(string exception) : base(exception)
        {
            MessageBox.Show(exception);
        }
    }
}
