using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Filters
{
    class GameFilters
    {
        public static bool isPlayedOver(Games games)
        {
            return games.HoursPlayed >= 100;
        }

        public static bool isPlayedUnder(Games games)
        {
            return games.HoursPlayed < 100;
        }

        public static bool isGenreRPG(Games games)
        {
                return games.Genre == "RPG";                
        }

        public static bool isGenreMMORPG(Games games)
        {
                return games.Genre == "MMORPG";
        }

        public static bool isGenreFPS(Games games)
        {
            return games.Genre == "FPS";
        }

        public static bool isGenreSIMULATOR(Games games)
        {
                return games.Genre == "SIMULATOR";
        }
    }
}
