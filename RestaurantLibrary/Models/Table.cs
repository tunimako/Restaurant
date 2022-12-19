using System;

namespace RestaurantLibrary.Models
{
    public class Table
    {
        public const string STATUS_EMPTY = "";
        public const string STATUS_WAITING = "Waiting for order";
        public const string STATUS_READY = "Ready to order";
        public const string STATUS_EATING = "Eating";
        public const string STATUS_PAY = "Ready to pay";
        public int TableId { get; set; }
        public int NumberOfSeats { get; set; }
        public bool AvailabilityStatus { get; set; }
        public string ProgressStatus { get; set; }
        public DateTime TimeTableTaken { get; set; }
        public Table (int id, int numberOfSeats, bool availabilityStatus, string progressStatus)
        {
            TableId = id;
            NumberOfSeats = numberOfSeats;
            AvailabilityStatus = availabilityStatus;
            ProgressStatus = progressStatus;
        }
    }
}