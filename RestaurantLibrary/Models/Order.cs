namespace RestaurantLibrary.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public Dish SelectedDish { get; set; }
        public Drink SelectedDrink { get; set; }
        public decimal OrderPrice { get; set; }
        public Order (int orderNumber, Dish selectedDish, Drink selectedDrink)
        {
            OrderNumber = orderNumber;
            SelectedDish = selectedDish;
            SelectedDrink = selectedDrink;
            OrderPrice = selectedDish.DishPrice + selectedDrink.DrinkPrice;
        }
    }
}