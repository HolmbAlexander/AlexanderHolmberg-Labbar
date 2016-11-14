﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Lists_and_Menus
{
    class ListsMenus
    {
        public List<ISellable> inventoryList = new List<ISellable>()
        {
            new Clothes { ProductType = "T-Shirt", Brand = "HM",      Quantity = 45, Price = 495,  Size = "Small, Medium, Extra Large" },
            new Clothes { ProductType = "Dress",   Brand = "Lindex",  Quantity = 25, Price = 350,  Size = "Medium, Large"              },
            new Clothes { ProductType = "Fidora",  Brand = "SwagBoy", Quantity = 5,  Price = 9000, Size = "Small, Medium, Large, "     },
            new Electronics { ProductType = "Microwave",   Brand = "Philips", Quantity = 85, Color = "Black", Price = 890  },
            new Electronics { ProductType = "Mobilephone", Brand = "Iphone",  Quantity = 40, Color = "Gold",  Price = 6500 },
            new Electronics { ProductType = "Stavemixer",  Brand = "Philips", Quantity = 15, Color = "Red",   Price = 1350 },
            new Food { ProductType = "Meat",   Brand = "Bullens pilsnerkorv", Quantity = 560, Weight = 500, Price = 45 },
            new Food { ProductType = "Apples", Brand = "Pen",                 Quantity = 800, Weight = 45,  Price = 29 },
            new Food { ProductType = "Cheese", Brand = "Gouda",               Quantity = 150, Weight = 950, Price = 89 }
        };
        public List<ISellable> shoppingCart = new List<ISellable>();

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
            Console.WriteLine("Choose a topic to see inventory of:");
            Console.WriteLine("1: Clothes");
            Console.WriteLine("2: Electronics");
            Console.WriteLine("3: Food");
            Console.WriteLine();
            Console.WriteLine("4: Previous page");
        }
        #endregion

        #region PrintMethods
        public void ShowClothes()
        {
            Console.Clear();
            int index = 1;
            foreach (var clothes in inventoryList.OfType<Clothes>())
            {
                Console.WriteLine(index + ": " + clothes.PrintProductCustomer()); index++;
            }
        }

        public void ShowClothesAdmin()
        {
            Console.Clear();
            int index = 1;
            foreach (var clothes in inventoryList.OfType<Clothes>())
            {
                Console.WriteLine(index + ": " + clothes.PrintProductAdmin()); index++;
            }
        }

        public void ShowElectronics()
        {
            Console.Clear();
            int index = 1;
            foreach (var electronic in inventoryList.OfType<Electronics>())
            {
                Console.WriteLine(index + ": " + electronic.PrintProductCustomer()); index++;
            }
        }

        public void ShowElectronicsAdmin()
        {
            Console.Clear();
            int index = 1;
            foreach (var electronic in inventoryList.OfType<Electronics>())
            {
                Console.WriteLine(index + ": " + electronic.PrintProductAdmin()); index++;
            }
        }

        public void ShowFood()
        {
            Console.Clear();
            int index = 1;
            foreach (var food in inventoryList.OfType<Food>())
            {
                Console.WriteLine(index + ": " + food.PrintProductCustomer()); index++;
            }
        }

        public void ShowFoodAdmin()
        {
            Console.Clear();
            int index = 1;
            foreach (var food in inventoryList.OfType<Food>())
            {
                Console.WriteLine(index + ": " + food.PrintProductAdmin()); index++;
            }
        }

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
            ShowClothes();
            Console.Write("\n Enter the type of clothing you would like to buy: ");
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
                Size = addSize
            };
        }

        public void BuyElectronics()
        {
            ShowElectronics();
            Console.WriteLine("Enter the type of electronics you would like to buy: ");
            int input = int.Parse(Console.ReadLine());
        }
        #endregion
    }
}
