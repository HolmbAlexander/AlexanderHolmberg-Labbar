using Labb10.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookFilters
    {
        public static bool IsNovel(Book books)
        {
            return books.Pages >= 250;
        }

        public static bool IsShortStory(Book books)
        {
            return books.Pages <= 249;
        }

        public static bool GenreMystery(Book books)
        {
            return books.Genre == "Mystery";
        }

        public static bool GenreFantasy(Book books)
        {
            return books.Genre == "Fantasy";
        }

        public static bool GenreRomance(Book books)
        {
            return books.Genre == "Romance";
        }

        public static bool isCheap(Book books)
        {
            return books.Price <= 200;
        }

        public static bool isExpensive(Book books)
        {
            return books.Price >= 199;
        }
    }
}
