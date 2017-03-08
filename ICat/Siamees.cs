using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICat
{
    public class Siamees:ICat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavouriteFood { get; set; }

        public string WalkAround()
        {
            return "Als een prins";
        }

        public string MakeNoise()
        {
            return "miaaaaaaaaauw maaaauw miiii";
        }
    }
}
