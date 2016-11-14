using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class Runtime
    {
        List<Movies> movieList = new List<Movies>
        {
            new Movies { Title = "Teenage Ninja Mutant Turtels", Genre = "Action", Playtime = 146 },
            new Movies { Title = "Bamse the strong fucking bear", Genre = "Action", Playtime = 75 },
            new Movies { Title = "Ted 2", Genre = "Comedy", Playtime = 128 },
            new Movies { Title = "Fifty shades och gay", Genre = "Romance", Playtime = 86 },
            new Movies { Title = "Gladiator", Genre = "Action", Playtime = 190 }
        };

        public Movies[] AllTitles { get; set; }

        public void Start()
        {
            PrintOneTitle();
            PrintOneGenre();
            PrintShortMovies();
            PrintAllMovieTitles();
            PrintSpecificTitle();
            PrintChainLinq();
            Console.ReadKey(true);
        }

        void PrintOneTitle()
        {
            Console.WriteLine("All movies with the name Gladiator:");
            Movies singleMovie = movieList
                .SingleOrDefault(movie => String.Equals(movie.Title, "Gladiator"));
            Console.WriteLine(singleMovie.Title);
        }

        void PrintOneGenre()
        {
            Console.WriteLine("\nMovies under Action genre:");
            Movies[] printGenre = movieList.Where(movie => movie.Genre.Contains("Action")).ToArray();
            foreach (var movie in printGenre)
            {
                Console.WriteLine(movie.Title + ": " + movie.Genre);
            }
        }

        void PrintShortMovies()
        {
            Console.WriteLine("\nMovies under 120minutes:");
            Movies[] printShortMovies = movieList.Where(movie => movie.Playtime <= 120).ToArray();
            foreach (var movie in printShortMovies)
            {
                Console.WriteLine(movie.Title + ": " + movie.Playtime);
            }
        }

        void PrintAllMovieTitles()
        {
            Console.WriteLine("\nAll movie titels:");
            AllTitles = new Movies[5];
            for (int i = 0; i < AllTitles.Length; i++)
            {
                AllTitles[i] = new Movies { Title = movieList[i].Title };
            }

            foreach (var movies in AllTitles)
            {
                Console.WriteLine(movies.Title);
            }
        }

        void PrintSpecificTitle()
        {
            Console.WriteLine("\nSpecific title: ");
            Movies singleMovie = movieList
                .SingleOrDefault(movie => String.Equals(movie.Title, "Ted 2"));
            string saveTitleToString = singleMovie.Title;
            Console.WriteLine(saveTitleToString);
        }

        void PrintChainLinq()
        {
            Console.WriteLine("\nMovies that starts with T, is over 120minutes and is an Action movie...:");
            Movies[] printChain = movieList.Where(movie => movie.Genre.Contains("Action")
                                                           && movie.Title.Contains('T') 
                                                           && movie.Playtime >= 120).ToArray();
            foreach (var item in printChain)
            {
                Console.WriteLine(item.Title + ": " + item.Genre + " genre and " + item.Playtime + " minutes long.");
            }
            
        }
        
}
}
