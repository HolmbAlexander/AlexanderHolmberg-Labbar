using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Lists_and_Menus
{
    class ListsMenus
    {
        #region Lists
        public List<ISellable> inventoryList = new List<ISellable>()
        {
            new Clothes { ProductType = "T-Shirt", Brand = "HM",      Quantity = 45, Price = 495,  Size = "Small, Medium, Extra Large" },
            new Clothes { ProductType = "Dress",   Brand = "Lindex",  Quantity = 25, Price = 350,  Size = "Medium, Large"              },
            new Clothes { ProductType = "Fidora",  Brand = "SwagBoy", Quantity = 5,  Price = 9000, Size = "Small, Medium, Large, "     },
            new Electronics { ProductType = "Microwave",   Brand = "Philips", Quantity = 85, Color = "Black or Red", Price = 890  },
            new Electronics { ProductType = "Mobilephone", Brand = "Iphone",  Quantity = 40, Color = "Gold or White",  Price = 6500 },
            new Electronics { ProductType = "Stavemixer",  Brand = "Philips", Quantity = 15, Color = "Red or Green",   Price = 1350 },
            new Food { ProductType = "Meat",   Brand = "Bullens pilsnerkorv", Quantity = 560, Weight = 500, Price = 45 },
            new Food { ProductType = "Apples", Brand = "Pen",                 Quantity = 800, Weight = 45,  Price = 29 },
            new Food { ProductType = "Cheese", Brand = "Gouda",               Quantity = 150, Weight = 950, Price = 89 }
        };
        public List<ISellable> shoppingCart = new List<ISellable>();
        #endregion

        #region Menus
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Buy-My-Shit. By: Alexander Holmberg.");
            Console.WriteLine("1: Buy products");
            Console.WriteLine("2: See shoppingcart");
            Console.WriteLine("3: Admin");
            Console.WriteLine("4: Quit");
        }

        public void ProductsMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a topic");
            Console.WriteLine("1: Clothes");
            Console.WriteLine("2: Electronics");
            Console.WriteLine("3: Food");
            Console.WriteLine("\n4: Previous page");
        }

        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Add product");
            Console.WriteLine("2: Remove product");
            Console.WriteLine("3: Go back");
        }
        #endregion

        #region PrintMethods
        public void ShowInventoryAdmin(string inventory)
        {
            int index = 1;
            if (inventory == "Clothes")
            {
                foreach (var clothes in inventoryList.OfType<Clothes>())
                {
                    Console.WriteLine(index + ": " + clothes.PrintProductAdmin()); index++;
                }
            }
            else if (inventory == "Electronics")
            {
                foreach (var electronic in inventoryList.OfType<Electronics>())
                {
                    Console.WriteLine(index + ": " + electronic.PrintProductAdmin()); index++;
                }
            }
            else if (inventory == "Food")
            {
                foreach (var food in inventoryList.OfType<Food>())
                {
                    Console.WriteLine(index + ": " + food.PrintProductAdmin()); index++;
                }
            }
        }

        public void ShowInventory(string inventory)
        {
            int index = 1;
            if (inventory == "Clothes")
            {
                foreach (var clothes in inventoryList.OfType<Clothes>())
                {
                    Console.WriteLine(index + ": " + clothes.PrintProductCustomer()); index++;
                }
            }
            else if (inventory == "Electronics")
            {
                foreach (var electronic in inventoryList.OfType<Electronics>())
                {
                    Console.WriteLine(index + ": " + electronic.PrintProductCustomer()); index++;
                }
            }
            else if (inventory == "Food")
            {
                foreach (var food in inventoryList.OfType<Food>())
                {
                    Console.WriteLine(index + ": " + food.PrintProductCustomer()); index++;
                }
            }
        }

        #region First attempt to display
        //public void ShowClothes()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var clothes in inventoryList.OfType<Clothes>())
        //    {
        //        Console.WriteLine(index + ": " + clothes.PrintProductCustomer()); index++;
        //    }
        //}

        //public void ShowClothesAdmin()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var clothes in inventoryList.OfType<Clothes>())
        //    {
        //        Console.WriteLine(index + ": " + clothes.PrintProductAdmin()); index++;
        //    }
        //}

        //public void ShowElectronics()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var electronic in inventoryList.OfType<Electronics>())
        //    {
        //        Console.WriteLine(index + ": " + electronic.PrintProductCustomer()); index++;
        //    }
        //}

        //public void ShowElectronicsAdmin()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var electronic in inventoryList.OfType<Electronics>())
        //    {
        //        Console.WriteLine(index + ": " + electronic.PrintProductAdmin()); index++;
        //    }
        //}

        //public void ShowFood()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var food in inventoryList.OfType<Food>())
        //    {
        //        Console.WriteLine(index + ": " + food.PrintProductCustomer()); index++;
        //    }
        //}

        //public void ShowFoodAdmin()
        //{
        //    Console.Clear();
        //    int index = 1;
        //    foreach (var food in inventoryList.OfType<Food>())
        //    {
        //        Console.WriteLine(index + ": " + food.PrintProductAdmin()); index++;
        //    }
        //}
        #endregion

        public void ShowShoppingCart()
        {
            Console.Clear();
            int index = 1;
            foreach (var food in shoppingCart.OfType<Food>())
            {
                Console.WriteLine(index + ": " + food.PrintProductCustomer()); index++;
            }
            foreach (var clothes in shoppingCart.OfType<Clothes>())
            {
                Console.WriteLine(index + ": " + clothes.PrintProductCustomer()); index++;
            }
            foreach (var electronics in shoppingCart.OfType<Electronics>())
            {
                Console.WriteLine(index + ": " + electronics.PrintProductCustomer()); index++;
            }
        }
        #endregion

        #region BuyMethods
        public void BuyClothes()
        {
            Console.Clear();
            ShowInventory("Clothes");
            Console.Write("\nEnter the type of clothing you would like to buy: ");
            string input = Console.ReadLine();
            Console.Write("Enter what size you want: ");
            string addSize = Console.ReadLine();
            Console.Write("Enter the number of units you would like to buy: ");
            int units = int.Parse(Console.ReadLine());
            ISellable single = inventoryList.OfType<Clothes>().SingleOrDefault(item => string.Equals(item.ProductType, input));
            single.Quantity -= units;
            int price = single.Price * units;
            Runtime.totalPrice += price;
            Clothes addClothes = new Clothes
            {
                ProductType = single.ProductType,
                Brand = single.Brand,
                Price = single.Price,
                Quantity = units,
                Size = addSize
            };
            shoppingCart.Add(addClothes);
        }

        public void BuyElectronics()
        {
            Console.Clear();
            ShowInventory("Electronics");
            Console.WriteLine("Enter the type of electronics you would like to buy: ");
            string input = Console.ReadLine();
            Console.WriteLine("Type in the color you would like to have: ");
            string color = Console.ReadLine();
            Console.Write("Enter the number of units you would like to buy: ");
            int units = int.Parse(Console.ReadLine());
            ISellable single = inventoryList.OfType<Electronics>().SingleOrDefault(item => string.Equals(item.ProductType, input));
            single.Quantity -= units;
            int price = single.Price * units;
            Runtime.totalPrice += price;
            Electronics addElectronics = new Electronics
            {
                ProductType = single.ProductType,
                Brand = single.Brand,
                Price = single.Price,
                Quantity = units,
                Color = color
            };
            shoppingCart.Add(addElectronics);
        }

        public void BuyFood()
        {
            Console.Clear();
            ShowInventory("Food");
            Console.WriteLine("Enter the type of food you would like to buy: ");
            string input = Console.ReadLine();
            Console.Write("Enter the number of units you would like to buy: ");
            int units = int.Parse(Console.ReadLine());
            ISellable single = inventoryList.OfType<Food>().SingleOrDefault(item => string.Equals(item.ProductType, input));
            single.Quantity -= units;
            int price = single.Price * units;
            Runtime.totalPrice += price;
            Food addFood = new Food
            {
                ProductType = single.ProductType,
                Brand = single.Brand,
                Price = single.Price,
                Quantity = units
            };
            shoppingCart.Add(addFood);
        }
        #endregion

        #region AddItemAdmin
        public void AddClothes()
        {
            Console.Clear();
            ShowInventoryAdmin("Clothes");
            Console.Write("\nEnter the type of clothing you would like to add: ");
            string input = Console.ReadLine();
            Console.Write("Enter what size: ");
            string addSize = Console.ReadLine();
            Console.Write("Enter the number of units: ");
            int units = int.Parse(Console.ReadLine());
            ISellable single = inventoryList.OfType<Clothes>().SingleOrDefault(item => string.Equals(item.ProductType, input));
            single.Quantity -= units;
            int price = single.Price * units;
            Runtime.totalPrice += price;
            Clothes addClothes = new Clothes
            {
                ProductType = single.ProductType,
                Brand = single.Brand,
                Price = single.Price,
                Quantity = units,
                Size = addSize
            };
            shoppingCart.Add(addClothes);
        }

        public void AddElectronics()
        {
            Console.Clear();
            ShowInventoryAdmin("Electronics");
            Console.WriteLine("Enter the type of electronics you would like to add: ");
            string input = Console.ReadLine();
            Console.WriteLine("Type in the color: ");
            string color = Console.ReadLine();
            Console.Write("Enter the number of units you would like to buy: ");
            int units = int.Parse(Console.ReadLine());
            ISellable single = inventoryList.OfType<Electronics>().SingleOrDefault(item => string.Equals(item.ProductType, input));
            single.Quantity -= units;
            int price = single.Price * units;
            Runtime.totalPrice += price;
            Electronics addElectronics = new Electronics
            {
                ProductType = single.ProductType,
                Brand = single.Brand,
                Price = single.Price,
                Quantity = units,
                Color = color
            };
            shoppingCart.Add(addElectronics);
        }

        #endregion
    }
}
