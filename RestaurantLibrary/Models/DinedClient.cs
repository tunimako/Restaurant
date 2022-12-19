using System;
using System.Collections.Generic;

namespace RestaurantLibrary.Models
{
    public class DinedClient
    {
        public int DinedClientCount  { get; set; }
        public string DinedClientId  { get; set; }
        public int GuestCount { get; set; }
        public int TableNumber { get; set; } 
        public DateTime ExitingTime { get; set; }
        public DateTime EntryTime { get; set; }
        public string OrderId { get; set; }
        public List<Order> DinedClientOrder { get; set; }
        public decimal Bill { get; set; }
        public string DinedClientEmail { get; set; }
    }
}