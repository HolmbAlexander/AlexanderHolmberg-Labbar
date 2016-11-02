using OOPLektionRepositoryInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLektionRepositoryInterface.DataStores
{
    class MyLists
    {
        private static List<Game> games = null;

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;
            }
        }
    }
}
