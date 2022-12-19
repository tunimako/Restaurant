namespace RestaurantLibrary.Models
{
    public class Drink
    {
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public Drink(string drinkName, decimal drinkPrice)
        {
            DrinkName = drinkName;
            DrinkPrice = drinkPrice;
        }
    }
}