using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.DataStores
{
    class MyLists
    {
        private static List<Game> games = null;
        private static List<Movie> movies = null;

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;
            }
        }

        public static List<Movie> Movies
        {
            get
            {
                if (movies == null)
                    movies = new List<Movie>();

                return movies;
            }
        }
    }
}
