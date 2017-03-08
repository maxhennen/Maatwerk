using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICat
{
    public interface ICat
    {
        string Name { get; set; }
        int Age { get; set; }
        string FavouriteFood { get; set; }

        string WalkAround();
        string MakeNoise();

    }
}
