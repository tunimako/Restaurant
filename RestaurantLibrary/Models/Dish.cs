namespace RestaurantLibrary.Models
{
    public class Dish
    {
        public string DishName { get; set; }
        public decimal DishPrice { get; set; }
        public Dish(string dishName, decimal dishPrice)
        {
            DishName = dishName;
            DishPrice = dishPrice;
        }
    }
}