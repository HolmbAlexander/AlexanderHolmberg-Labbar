using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.DataStores.Repositories
{
    class ListRepositories : IRepository
    {
        #region Games
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }
        #endregion

        #region Movies
        public Movie[] GetMovies()
        {
            return MyLists.Movies.ToArray();
        }

        public void AddMovie(Movie newMovie)
        {
            MyLists.Movies.Add(newMovie);
        }

        public void RemoveMovie(Movie movie)
        {
            MyLists.Movies.Remove(movie);
        }
        #endregion
    }
}
