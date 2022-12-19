using RestaurantLibrary.Services;
using RestaurantLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace RestaurantLibrary.Repositories
{
    public class Meniu
    {
        public List<Dish> Dishes { get; private set; }
        public List<Drink> Drinks { get; private set; }
        public Meniu()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string fileDirectoryDish = @"\RestaurantLibrary\Excels\Food.xlsx";
            string fileDirectoryDrinks = @"\RestaurantLibrary\Excels\Drinks.xlsx";
            string dishExcelFullPath = Directory.GetParent(projectDirectory).Parent.Parent.Parent.FullName + fileDirectoryDish;
            string drinkExcelFullPath = Directory.GetParent(projectDirectory).Parent.Parent.Parent.FullName + fileDirectoryDrinks;
            
            Excel dishExcel = new(dishExcelFullPath);
            Excel drinkExcel = new(drinkExcelFullPath);

            Dishes = dishExcel.GetDishes();
            Drinks = drinkExcel.GetDrinks();
        }
        public Dish GenerateDish()
        {
            var random = new Random();
            return Dishes.ElementAt(random.Next(0, Dishes.Count()));
        }
        public Drink GenerateDrink()
        {
            var random = new Random();
            return Drinks.ElementAt(random.Next(0, Drinks.Count()));
        }
    }
}