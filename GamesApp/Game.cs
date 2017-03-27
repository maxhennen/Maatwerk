using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesApp
{
    public class Game
    {
        public string Titel { get; private set; }
        public Genres Genre { get; private set; }
        public Platforms Platform { get; private set; }
        public double Prijs { get; private set; }

        public Game(string titel,Genres  genre, Platforms platform, double prijs)
        {
            Titel = titel;
            Genre = genre;
            Platform = platform;
            Prijs = prijs;
        }

        public string AlsString(Game game)
        {
            return "Titel: " + game.Titel + " Genre: " + game.Genre + " Platform: " + game.Platform + " Prijs: " +
                   game.Prijs;
        }
    }
}
