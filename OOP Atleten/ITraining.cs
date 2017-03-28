using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public interface ITraining:IComparable<Training>
    {
        DateTime Tijdstip { get;  }
        int Tijdsduur { get;  }
        int Intensiteit { get;  }
        string Omschrijving { get;  }
        string ToString();
    }
}
