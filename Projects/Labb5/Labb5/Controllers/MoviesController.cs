using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.DataStores.Repositories;

namespace Labb5.Controllers
{
    class MoviesController
    {
        private IRepository repositoryMovies = new ListRepositories();

        public void PrintMoviesList()
        {
            UI.PrintMovieList(repositoryMovies.GetMovies());
            Console.ReadKey(true);
        }
        
        public void CreateMovie()
        {
            var newMovie = UI.CreateMovie();
            repositoryMovies.AddMovie(newMovie);
        }
        
        public void RemoveMovie()
        {
            var movies = repositoryMovies.GetMovies();
            var index = UI.SelectMovie(repositoryMovies.GetMovies()) - 1;
            repositoryMovies.RemoveMovie(movies[index]);
        }

        public void EditMovie()
        {
            var movies = repositoryMovies.GetMovies();
            UI.PrintMovieList(movies);
            int index = UI.SelectMovie(movies) - 1;

            UI.EditMovie(movies[index]);
        }
    }
}
