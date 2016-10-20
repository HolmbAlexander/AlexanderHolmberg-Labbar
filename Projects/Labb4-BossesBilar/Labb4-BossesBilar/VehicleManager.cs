using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_BossesBilar
{
    class VehicleManager
    {

        #region Lists
        List<CarNew> newCarList = new List<CarNew>
        {
            new CarNew { Maker = "BMW",      Model = "3",        Amount = 4, Price = 189000, FreeScervice = 5, Color = "Dark green" },
            new CarNew { Maker = "Volvo",    Model = "S80",      Amount = 2, Price = 149000, FreeScervice = 5, Color = "White"      },
            new CarNew { Maker = "Ferrari",  Model = "GTB",      Amount = 5, Price = 689995, FreeScervice = 5, Color = "Red"        },
            new CarNew { Maker = "Skoda",    Model = "Roomster", Amount = 3, Price = 105995, FreeScervice = 3, Color = "Red"        }
        };
        List<CarUsed> usedCarList = new List<CarUsed>
        {
            new CarUsed { Maker = "Volvo",  Model = "V70",        Amount = 4, Price = 18995, Mileage = 23500, Owners = 4},
            new CarUsed { Maker = "Fiat",   Model = "Qubo",       Amount = 3, Price = 35995, Mileage = 12250, Owners = 2},
            new CarUsed { Maker = "Hyndai", Model = "Accent",     Amount = 4, Price = 8995,  Mileage = 18750, Owners = 3},
            new CarUsed { Maker = "BMW",    Model = "NoBlinkers", Amount = 2, Price = 95000, Mileage = 12000, Owners = 1}
        };
        List<MotorbikeNew> newBikeList = new List<MotorbikeNew>
        {
            new MotorbikeNew { Maker = "Yamaha",          Model = "Slider", Amount = 2, Price = 259995, FreeScervice = 4, Color = "Grey"  },
            new MotorbikeNew { Maker = "Honda",           Model = "MC",     Amount = 6, Price = 65995,  FreeScervice = 3, Color = "Red"   },
            new MotorbikeNew { Maker = "Harley Davidson", Model = "V Rod",  Amount = 2, Price = 589995, FreeScervice = 5, Color = "Black" },
            new MotorbikeNew { Maker = "Jawa",            Model = "350",    Amount = 7, Price = 26995,  FreeScervice = 2, Color = "Red"   }
        };
        List<MotorbikeUsed> usedBikeList = new List<MotorbikeUsed>
        {
            new MotorbikeUsed { Maker = "Honda",           Model = "Vrumm",  Amount = 3, Price = 35995,  Mileage = 12500, Owners = 1},
            new MotorbikeUsed { Maker = "Harley Davidson", Model = "V rod",  Amount = 4, Price = 349995, Mileage = 8500,  Owners = 1},
            new MotorbikeUsed { Maker = "Jamwa",           Model = "TWS 50", Amount = 6, Price = 15000,  Mileage = 15000, Owners = 3},
            new MotorbikeUsed { Maker = "Yamaha",          Model = "R25",    Amount = 3, Price = 275000, Mileage = 13500, Owners = 2}
        };
        #endregion

        #region Add Vehicles
        public void AddNewCar()
        {
            Console.Clear();
            Console.Write("Maker: ");
            string maker = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Free service years: ");
            int freeScervice = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            string color = Console.ReadLine();

            CarNew newCar = new CarNew
            { Maker = maker, Model = model, Amount = 0, Price = price, FreeScervice = freeScervice, Color = color };
            newCarList.Add(newCar);
        }
        public void AddUsedCar()
        {
            Console.Clear();
            Console.Write("Maker: ");
            string maker = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Mileage: ");
            int mileage = int.Parse(Console.ReadLine());
            Console.Write("Owners: ");
            int owners = int.Parse(Console.ReadLine());

            CarUsed usedCar = new CarUsed
            { Maker = maker, Model = model, Amount = 0, Price = price, Mileage = mileage, Owners = owners };
            usedCarList.Add(usedCar);
        }
        public void AddNewBike()
        {
            Console.Clear();
            Console.Write("Maker: ");
            string maker = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Free service years: ");
            int freeScervice = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            string color = Console.ReadLine();

            MotorbikeNew newBike = new MotorbikeNew
            { Maker = maker, Model = model, Amount = 0, Price = price, FreeScervice = freeScervice, Color = color };
            newBikeList.Add(newBike);
        }
        public void AddUsedBike()
        {
            Console.Clear();
            Console.Write("Maker: ");
            string maker = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Mileage: ");
            int mileage = int.Parse(Console.ReadLine());
            Console.Write("Owners: ");
            int owners = int.Parse(Console.ReadLine());

            MotorbikeUsed usedBike = new MotorbikeUsed
            { Maker = maker, Model = model, Amount = 0, Price = price, Mileage = mileage, Owners = owners };
            usedBikeList.Add(usedBike);
        }
        #endregion

        #region Show Vehicles
        public void ShowNewCar()
        {
            Console.Clear();
            int i = 0;
            foreach (var NewCar in newCarList)
            {
                i++;
                Console.WriteLine(i + ": " + NewCar.BasicInfo());
            }
        }
        public void ShowUsedCar()
        {
            Console.Clear();
            int i = 0;
            foreach (var UsedCar in usedCarList)
            {
                i++;
                Console.WriteLine(i + ": " + UsedCar.BasicInfo());
            }
        }
        public void ShowUsedBike()
        {
            Console.Clear();
            int i = 0;
            foreach (var UsedBike in usedBikeList)
            {
                i++;
                Console.WriteLine(i + ": " + UsedBike.BasicInfo());
            }
        }
        public void ShowNewBike()
        {
            Console.Clear();
            int i = 0;
            foreach (var NewBike in newBikeList)
            {
                i++;
                Console.WriteLine(i + ": " + NewBike.BasicInfo());
            }
        }
        #endregion

        #region Remove Vehicles
        public void RemoveNewCar()
        {
            Console.Clear();
            ShowNewCar();
            Console.WriteLine("Enter number of car to remove.");
            int input = int.Parse(Console.ReadLine());
            newCarList.RemoveAt(input - 1);
        }
        public void RemoveUsedCar()
        {
            Console.Clear();
            ShowUsedCar();
            Console.WriteLine("Enter number of car to remove.");
            int input = int.Parse(Console.ReadLine());
            usedCarList.RemoveAt(input - 1);
        }

        public void RemoveNewBike()
        {
            Console.Clear();
            ShowNewBike();
            Console.WriteLine("Enter number of bike to remove.");
            int input = int.Parse(Console.ReadLine());
            newBikeList.RemoveAt(input - 1);
        }

        public void RemoveUsedBike()
        {
            Console.Clear();
            ShowUsedBike();
            Console.WriteLine("Enter number of bike to remove.");
            int input = int.Parse(Console.ReadLine());
            usedCarList.RemoveAt(input - 1);
        }

        #endregion

        #region Buy Vehicles
        public void BuyNewCar()
        {
            Console.Clear();
            ShowNewCar();
            Console.Write("What car do you like to buy in(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many would you like to order: ");
            int order = int.Parse(Console.ReadLine());

            newCarList[listIndex - 1].Amount += order;
        }

        public void BuyUsedCar()
        {
            Console.Clear();
            ShowUsedCar();
            Console.Write("What car do you like to buy in(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many would you like to order: ");
            int order = int.Parse(Console.ReadLine());

            usedCarList[listIndex - 1].Amount += order;
        }

        public void BuyNewBike()
        {
            Console.Clear();
            ShowNewBike();
            Console.Write("What bike do you like to buy in(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many would you like to order: ");
            int order = int.Parse(Console.ReadLine());

            newBikeList[listIndex - 1].Amount += order;
        }

        public void BuyUsedBike()
        {
            Console.Clear();
            ShowUsedBike();
            Console.Write("What bike do you like to buy in(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many would you like to order: ");
            int order = int.Parse(Console.ReadLine());

            usedBikeList[listIndex - 1].Amount += order;
        }
        #endregion

        #region Sell vehicles
        public void SellNewCar()
        {
            Console.Clear();
            ShowNewCar();
            Console.Write("What car have you sold(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many: ");
            int order = int.Parse(Console.ReadLine());

            newCarList[listIndex - 1].Amount -= order;
        }

        public void SellUsedCar()
        {
            Console.Clear();
            ShowUsedCar();
            Console.Write("What car have you sold(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many: ");
            int order = int.Parse(Console.ReadLine());

            usedCarList[listIndex - 1].Amount -= order;
        }

        public void SellNewBike()
        {
            Console.Clear();
            ShowNewBike();
            Console.Write("What bike have you sold(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many: ");
            int order = int.Parse(Console.ReadLine());

            newBikeList[listIndex - 1].Amount -= order;
        }

        public void SellUsedBike()
        {
            Console.Clear();
            ShowUsedBike();
            Console.Write("What bike have you sold(anwers with number): ");
            int listIndex = int.Parse(Console.ReadLine());
            Console.Write("How many: ");
            int order = int.Parse(Console.ReadLine());

            usedBikeList[listIndex - 1].Amount -= order;
        }
        #endregion
    }
}
