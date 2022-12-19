using RestaurantLibrary.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantLibrary.Repositories
{
    public class OrderRepository
    {
        public List<Order> ClientOrder { get; set; }
        public OrderRepository(Client client)
        {
            ClientOrder = new List<Order>();
            var meniu = new Meniu();

            for (int i = 1; i <= client.GuestCount; i++)
            {
                ClientOrder.Add(new Order(i, meniu.GenerateDish(), meniu.GenerateDrink()));
            }
        }
        public ListViewItem[] TakeOrder()
        {
            var listItemArray = new ListViewItem[ClientOrder.Count];

            foreach (Order item in ClientOrder)
            {  
                var listItem = new ListViewItem(item.OrderNumber.ToString());

                listItem.SubItems.Add(item.SelectedDish.DishName);
                listItem.SubItems.Add(item.SelectedDrink.DrinkName);
                listItem.SubItems.Add(item.OrderPrice.ToString());

                listItemArray[item.OrderNumber - 1] = listItem;
            }
            return listItemArray;
        }
    }
}