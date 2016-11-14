using Labb10.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovelFilter = BookFilters.IsNovel;
            BookFilter isShortStoryFilter = BookFilters.IsShortStory;
            BookFilter isGenreMysteryFilter = BookFilters.GenreMystery;
            BookFilter isGenreFantasyFilter = BookFilters.GenreFantasy;
            BookFilter isGenreRomanceFilter = BookFilters.GenreRomance;
            BookFilter isCheapFilter = BookFilters.isCheap;
            BookFilter isExpensiveFilter = BookFilters.isExpensive;

            Console.WriteLine("All novels:");
            manager.PrintWhere(isNovelFilter);

            Console.WriteLine("\nAll ShortStorys:");
            manager.PrintWhere(isShortStoryFilter);

            Console.WriteLine("\nGenres: ");
            Console.WriteLine("Mystery books:");
            manager.PrintWhere(isGenreMysteryFilter);

            Console.WriteLine("\nFantasy books:");
            manager.PrintWhere(isGenreFantasyFilter);

            Console.WriteLine("\nRomance books:");
            manager.PrintWhere(isGenreRomanceFilter);

            Console.WriteLine("\nBooks over 250kr:");
            manager.PrintWhere(isExpensiveFilter);

            Console.WriteLine("\nBooks under 250kr:");
            manager.PrintWhere(isCheapFilter);

            Console.ReadKey(true);
        }
    }
}
