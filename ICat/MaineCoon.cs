using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICat
{
    public class MaineCoon:ICat,IFurCare
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavouriteFood { get; set; }

        public string WalkAround()
        {
            return "Als een clown";
        }

        public string MakeNoise()
        {
            return "“maw prrr mie mau prr";
        }

        public void WashHair()
        {
            
        }

        public void BrushHair()
        {
            
        }
    }
}
