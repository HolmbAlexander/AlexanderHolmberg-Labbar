using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10.Classes
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>()
            {
                new Book { Title = "Kamasutra för nybörjare", Genre = "Mystery", Pages = 69, Price = 69 },
                new Book { Title = "Kalle Anka", Genre = "Fantasy", Pages = 36, Price = 45 },
                new Book { Title = "Mysteriet på Greveholm", Genre = "Fantasy", Pages = 238, Price = 299 },
                new Book { Title = "Sparkling Vampires", Genre = "Romance", Pages = 666, Price = 349 },
                new Book { Title = "Allt intressant i mitt liv", Genre = "Fantasy", Pages = 2, Price = 0 }
            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in Books)
            {
                if (filter(book))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
    }
}
