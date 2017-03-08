using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICat
{
    public class ScottishFold:ICat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavouriteFood { get; set; }

        public string WalkAround()
        {
            return "Sloom";
        }

        public string MakeNoise()
        {
            return "“Mi mi auw miauw prr prr";
        }
    }
}
