using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{
    public class GamesApp
    {
        public List<Game> Games { get; private set; }

        public GamesApp()
        {
            Games = new List<Game>();
        }

        public bool VoegGameToe(Game game)
        {
            foreach (Game G in Games)
            {
                if (G.Titel != game.Titel)
                {
                    Games.Add(game);
                    return true;
                }
            }
            return false;
        }
    }
}
