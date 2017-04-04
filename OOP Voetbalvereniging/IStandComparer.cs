using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Voetbalvereniging
{
    public class IStandComparer
    {
        public class SorteerOpBehaaldePunten : IComparer<Team>
        {
            public int Compare(Team x, Team y)
            {
                return y.Behaaldpunten().CompareTo(x.Behaaldpunten());
            }
        }
    }
}
