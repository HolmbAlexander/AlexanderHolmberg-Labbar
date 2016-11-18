using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Lists
    {
        public List<Author> authorsList { get; set; }
        public List<Book> booksList { get; set; }
        public List<Magazine> magazinesList { get; set; }
        public List<Paper> paperList { get; set; }

        public Lists()
        {
            authorsList = new List<Author>
            {
                new Author { Name = "J.K Rowling", Age = 51 },
                new Author { Name = "Chuck Palahniuk", Age = 46 },
                new Author { Name = "Bret Easton Ellis", Age = 53 },
                new Author { Name = "Margaret Atwood", Age = 72 },
                new Author { Name = "Richard Yates", Age = 64 },
                new Author { Name = "Erica Jong", Age = 63 }
            };

            booksList = new List<Book>
            {
                new Book { Author = authorsList[0], Title = "Harry Potter and the Sorcerer's Stone", Pages = 231, RealseDate = new DateTime(1997,03,09) },
                new Book { Author = authorsList[1], Title = "Fight Club", Pages = 258, RealseDate = new DateTime(1996,08,17) },
            };

            magazinesList = new List<Magazine>
            {
                new Magazine { Author = authorsList[2], Title = "American Pshyco", RealseDate = new DateTime(1991,01,10) },
                new Magazine { Author = authorsList[3], Title = "The Handmaid's Tale", RealseDate = new DateTime(1985,05,25) }
            };

            paperList = new List<Paper>
            {
                new Paper { Author = authorsList[4], Title = "Revolutionary Road", RealseDate = new DateTime(1961,11,29) },
                new Paper { Author = authorsList[5], Title = "Fear of Flying", RealseDate = new DateTime(1973,08,21) }
            };
        }
    }
}
