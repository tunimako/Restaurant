using RestaurantLibrary.Interfaces;
using RestaurantLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RestaurantLibrary.Services
{
    public class RestaurantData : IEmail
    {
        public string FullPath { get; private set; }
        public RestaurantData()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string fileDirectory = @"\RestaurantLibrary\Excels\RestaurantData.xlsx";
            FullPath = Directory.GetParent(projectDirectory).Parent.Parent.Parent.FullName + fileDirectory;
        }
        public void SaveDinedClient(DinedClient client)
        {
            var restaurantData = new Excel(FullPath); 
            
            restaurantData.SaveData(client);
        }
        public void SaveDinedClientEmail(DinedClient client, string emailAdress)
        {
            var restaurantData = new Excel(FullPath); 

            restaurantData.SaveData(client, emailAdress);
        }
        public void PrintRestaurantReport(List<DinedClient> dinedClients, string buttonName)
        {
            var restaurantData = new Excel(FullPath);

            restaurantData.PrintReport(dinedClients);
            MessageBox.Show("Report has been printed!", buttonName);
        }
        public void SendEmail(string emailAddress, string buttonName)
        {
            MessageBox.Show($"Restaurant report has been send to Email: {emailAddress}.",buttonName);
        }
    }
}