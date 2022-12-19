using RestaurantLibrary.Models;
using System.IO;

namespace RestaurantLibrary.Services
{
    public class Receipt
    {
        public string FullPath { get; private set; }
        public Receipt()
        {   
            string projectDirectory = Directory.GetCurrentDirectory();
            string fileDirectory = @"\RestaurantLibrary\Excels\Receipt.xlsx";
            FullPath = Directory.GetParent(projectDirectory).Parent.Parent.Parent.FullName + fileDirectory;
        }
        public void PrintReceipt(DinedClient client)
        {
            var receipt = new Excel(FullPath);

            receipt.PrintReceipt(client);
        }
    }
}