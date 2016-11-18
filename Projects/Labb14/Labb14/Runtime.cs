using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Runtime
    {
        Book book = new Book();
        Magazine magazine = new Magazine();
        Paper paper = new Paper();
        Author author = new Author();
        Lists listManager = new Lists();

        public void Start()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1: Search for author");
                Console.WriteLine("2: See list of authors and there work");
                Console.WriteLine("3: Exit");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        ShowAuthors();
                        SearchAuthor();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        ShowAuthorAndWork();
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }

        void ShowAuthors()
        {
            int i = 1;
            foreach (var author in listManager.authorsList)
            {
                Console.WriteLine(i + ": " + author.Name); i++;
            }
        }

        void ShowAuthorAndWork()
        {
            Console.Clear();
            int i = 1;
            foreach (var author in listManager.booksList)
            {
                Console.WriteLine(i + ": " + "Author: {0}. Title: {1}. Pages: {2}. Realse date: {3}. ",
                                 author.Author.Name,
                                 author.Title,
                                 author.Pages,
                                 author.RealseDate.ToShortDateString()); i++;
            }
            foreach (var author in listManager.magazinesList)
            {
                Console.WriteLine(i + ": " + "Author: {0}. Title: {1}. Realse date: {2}. ",
                                 author.Author.Name,
                                 author.Title,
                                 author.RealseDate.ToShortDateString()); i++;
            }
            foreach (var author in listManager.paperList)
            {
                Console.WriteLine(i + ": " + "Author: {0}. Title: {1}. Realse date: {2}. ",
                                 author.Author.Name,
                                 author.Title,
                                 author.RealseDate.ToShortDateString()); i++;
            }
            Console.ReadKey(true);
        }

        void SearchAuthor()
        {
            Console.Write("Enter name or part of name from author to see their work: ");
            string nameInput = Console.ReadLine();

            var getBooks = listManager.booksList.Where(author => author.Author.Name.Contains(nameInput));
            var getMagazines = listManager.magazinesList.Where(author => author.Author.Name.Contains(nameInput));
            var getPapers = listManager.paperList.Where(author => author.Author.Name.Contains(nameInput));

            if (getBooks.Any() || getMagazines.Any() || getPapers.Any())
            {
                foreach (var author in getBooks)
                {
                    Console.WriteLine("Author: {0}. Title: {1}. Pages: {2}. Realse date: {3}. ",
                                     author.Author.Name,
                                     author.Title,
                                     author.Pages,
                                     author.RealseDate.ToShortDateString());
                }

                foreach (var author in getMagazines)
                {
                    Console.WriteLine("Author: {0}. Title: {1}. Realse date: {2}. ",
                                     author.Author.Name,
                                     author.Title,
                                     author.RealseDate.ToShortDateString());
                }

                foreach (var author in getPapers)
                {
                    Console.WriteLine("Author: {0}. Title: {1}. Realse date: {2}. ",
                                     author.Author.Name,
                                     author.Title,
                                     author.RealseDate.ToShortDateString());
                }
            }
            else
                Console.WriteLine("No author with that name found.");
        }
    }
}
