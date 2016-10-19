using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class EventManager
    {
        
        #region Lists
        public List<Konserter> konsertBokaList = new List<Konserter>();
        public List<Filmer> filmBokaList = new List<Filmer>();
        public List<Festivaler> festivalBokaList = new List<Festivaler>();

        public List<Konserter> konserterList = new List<Konserter>
        {   new Konserter { NamnBokare = "", NamnEvangemang = "Fallout Boy",       FörBand = "Aqua",             Sittplats = "Nej", Pris = 699, Stad = "Stockholm" },
            new Konserter { NamnEvangemang = "System of a down",  FörBand = "Backstreet Boys",  Sittplats = "Ja",  Pris = 599, Stad = "Trosa"     },
            new Konserter { NamnEvangemang = "Beyonce",           FörBand = "Iron Maiden",      Sittplats = "Nej", Pris = 699, Stad = "Luleå"     },
            new Konserter { NamnEvangemang = "Björn Rosenström",  FörBand = "Lillbabs",         Sittplats = "Nej", Pris = 699, Stad = "Halmstad"  }};

        public List<Filmer> filmerList = new List<Filmer>
        {   new Filmer { NamnEvangemang = "Rambo 13",            Genre = "Action",    Pris = 120, SittPlats = "Finns", Stad = "Heron City" },
            new Filmer { NamnEvangemang = "Scary Movie",         Genre = "Skräck",    Pris = 120, SittPlats = "Finns", Stad = "Heron City" },
            new Filmer { NamnEvangemang = "The Notepad",         Genre = "Romantik",  Pris = 120, SittPlats = "Finns", Stad = "Södermalm" },
            new Filmer { NamnEvangemang = "Elephanto porno2000", Genre = "Vuxen",     Pris = 90,  SittPlats = "Finns", Stad = "Roletto" }};

        public List<Festivaler> festivalerList = new List<Festivaler>
        {   new Festivaler { NamnEvangemang = "Emmaboda",       FestivalGenre = "Electro",    AntalDagar = 3, Pris = 1500, Stad = "Emmaboda" },
            new Festivaler { NamnEvangemang = "Hultsfred",      FestivalGenre = "Mainstream", AntalDagar = 2, Pris = 1500, Stad = "Hultsfred" },
            new Festivaler { NamnEvangemang = "Sweden Rock",    FestivalGenre = "Rock",       AntalDagar = 4, Pris = 1500, Stad = "Bålsta" },
            new Festivaler { NamnEvangemang = "Peace and Love", FestivalGenre = "Hippie",     AntalDagar = 4, Pris = 1500, Stad = "Lovecity" }};
        #endregion

        public void ShowKonsert()
        {
            Console.Clear();
            int i = 1;
            foreach (var konsert in konserterList)
            {
                Console.WriteLine(i + ": " + konsert.Bokning()); i++;
            }
        }
        public void ShowFilm()
        {
            Console.Clear();
            int i = 1;
            foreach (var film in filmerList)
            {
                Console.WriteLine(i + ": " + film.Bokning()); i++;
            }
        }
        public void ShowFestival()
        {
            Console.Clear();
            int i = 1;
            foreach (var festival in festivalerList)
            {
                Console.WriteLine(i + ": " + festival.Bokning()); i++;
            }
        }

        public void BokaKonsert()
        {
            Console.Clear();
            Console.WriteLine("Vänlig skriv in ditt namn: ");
            string Namn = Console.ReadLine();          

            int i;
            ShowKonsert();
            bool loop = false;
            do
            {
                Console.WriteLine("Välj mellan konsert 1-4.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: i = 0; konserterList[i].NamnBokare = Namn;
                        konsertBokaList.Add(konserterList[i]); break;
                    case ConsoleKey.D2: i = 1; konserterList[i].NamnBokare = Namn;
                        konsertBokaList.Add(konserterList[i]); break;
                    case ConsoleKey.D3: i = 2; konserterList[i].NamnBokare = Namn;
                        konsertBokaList.Add(konserterList[i]); break;
                    case ConsoleKey.D4: i = 3; konserterList[i].NamnBokare = Namn;
                        konsertBokaList.Add(konserterList[i]); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
        public void BokaFilm()
        {
            Console.Clear();
            Console.WriteLine("Vänlig skriv in ditt namn: ");
            string Namn = Console.ReadLine();

            int i;
            ShowFilm();
            bool loop = false;
            do
            {
                Console.WriteLine("Välj mellan konsert 1-4.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        i = 0; filmerList[i].NamnBokare = Namn;
                        filmBokaList.Add(filmerList[i]); break;
                    case ConsoleKey.D2: i = 1; filmerList[i].NamnBokare = Namn;
                        filmBokaList.Add(filmerList[i]); break;
                    case ConsoleKey.D3: i = 2; filmerList[i].NamnBokare = Namn;
                        filmBokaList.Add(filmerList[i]); break;
                    case ConsoleKey.D4: i = 3; filmerList[i].NamnBokare = Namn;
                        filmBokaList.Add(filmerList[i]); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
        public void BokaFestival()
        {
            Console.Clear();
            Console.WriteLine("Vänlig skriv in ditt namn: ");
            string Namn = Console.ReadLine();

            int i;
            ShowFestival();
            bool loop = false;
            do
            {
                Console.WriteLine("Välj mellan konsert 1-4.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        i = 0; festivalerList[i].NamnBokare = Namn;
                        festivalBokaList.Add(festivalerList[i]); break;
                    case ConsoleKey.D2: i = 1; festivalerList[i].NamnBokare = Namn;
                        festivalBokaList.Add(festivalerList[i]); break;
                    case ConsoleKey.D3: i = 2; festivalerList[i].NamnBokare = Namn;
                        festivalBokaList.Add(festivalerList[i]); break;
                    case ConsoleKey.D4: i = 3; festivalerList[i].NamnBokare = Namn;
                        festivalBokaList.Add(festivalerList[i]); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        public void ShowBookings()
        {
            Console.Clear();
            foreach (var Konsert in konsertBokaList)
            {
                Console.WriteLine(Konsert.BokningNamn());
            }
            

            foreach (var Film in filmBokaList)
            {
                Console.WriteLine(Film.BokningNamn());
            }
            

            foreach (var Festival in festivalBokaList)
            {
                Console.WriteLine(Festival.BokningNamn());
            }
            Console.ReadKey(true);
        }
    }
}
