using RestaurantLibrary.Interfaces;
using RestaurantLibrary.Models;
using RestaurantLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantLibrary.Repositories
{
    public class ClientRepository : IEmail
    {
        public List<Client> Clients { get; private set; }
        public List<DinedClient> DinedClients { get; private set; }
        public RestaurantData RestaurantData { get; private set; }
        public Receipt Receipt { get; set; }
        public ClientRepository()
        {
            Clients = new List<Client>();
            DinedClients = new List<DinedClient>();
            RestaurantData = new RestaurantData();
            Receipt = new Receipt();
        }
        public async Task GenerateClientsAsync(ListView clientList, CancellationToken token)
        {
            GenerateClient(clientList);
            var random = new Random();
            
            for (; ; )
            {
                await Task.Delay(random.Next(10000, 20000));

                if (token.IsCancellationRequested)
                {
                    break;
                }
                else if (clientList.Items.Count > 2)
                {
                    continue;
                }
                else
                {
                    GenerateClient(clientList);
                }
            }
        }
        private void GenerateClient(ListView clientList)
        {
            Client newClient = NewClient();
            
            var listItem = new ListViewItem(newClient.ClientId);
            listItem.SubItems.Add(newClient.GuestCount.ToString());
            clientList.Items.Add(listItem);
        }
        private Client NewClient()
        {
            var client = new Client();

            client.ClientId = ClientIdGenerator();
            client.GuestCount = NumberOfCliets();
            Clients.Add(client);

            return client;
        }
        public DinedClient GenerateDinedClient(Table table, TextBox dinedClientId, List<Order> orders)
        {
            var dinedClient = new DinedClient();

            dinedClient.DinedClientCount = DinedClientsCount();
            dinedClient.DinedClientId = dinedClientId.Text;
            dinedClient.TableNumber = table.TableId;
            dinedClient.GuestCount = orders.Count;
            dinedClient.OrderId = OrderIdGenerator();
            dinedClient.DinedClientOrder = orders;
            dinedClient.EntryTime = table.TimeTableTaken;
            dinedClient.ExitingTime = DateTime.Now;
            dinedClient.Bill = orders.Sum(order => order.OrderPrice);
            RestaurantData.SaveDinedClient(dinedClient);
            DinedClients.Add(dinedClient);

            return dinedClient;
        }
        public bool IsClientSelected(ListView list, string buttonName)
        {
            if (list.SelectedItems.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select the client from the list!", buttonName);
                return false;
            }
        }
        public bool ContainsEmail(ListViewItem listItem, string buttonName)
        {
            DinedClient dinedClient = DinedClients.GetDinedClient(listItem.Text);
            
            if (dinedClient.DinedClientEmail == null)
            {              
                return true;
            }
            else
            {
                MessageBox.Show("Client receipt was already send!", buttonName);
                return false;
            }
        }
        private string OrderIdGenerator()
        {
            return DinedClientsCount().ToString("D4");
        }
        private string ClientIdGenerator()
        {
            var sb = new StringBuilder();

            sb.Append("ID");
            sb.Append(DateTime.Today.ToShortDateString().Replace("-",""));
            sb.Append(DateTime.Now.ToString("mm:ss").Replace(":",""));
            sb.Append("-");
            sb.Append(ClientsCount().ToString("D4"));

            return sb.ToString();
        }
        private int ClientsCount()
        {
            return Clients.Count + 1;
        }
        private int DinedClientsCount()
        {
            return DinedClients.Count + 1;
        }
        private int NumberOfCliets()
        {
            var random = new Random();
            return random.Next(1,6);
        }
        public ListViewItem SaveReceipt(DinedClient client)
        {            
            var listItem = new ListViewItem(client.DinedClientId);

            listItem.SubItems.Add(client.GuestCount.ToString());
            listItem.SubItems.Add(client.Bill.ToString());
            listItem.SubItems.Add(client.ExitingTime.ToLongTimeString());
            
            return listItem;
        }
        public void SendEmail(string emailAddress, string buttonName)
        {
            MessageBox.Show($"Client receipt has been send to Email: {emailAddress}.",buttonName);
        }
        public DinedClient AddClientEmail(List<DinedClient> dinedClients, string clientId, string emailAddress)
        {
            DinedClient dinedClient = dinedClients.Where(c => c.DinedClientId == clientId).FirstOrDefault();
            dinedClient.DinedClientEmail = emailAddress;
            RestaurantData.SaveDinedClientEmail(dinedClient, emailAddress);

            return dinedClient;
        }
    }
    public static class ClientRepositoryExtention
    {
        public static Client GetClient(this List<Client> clients, string clientId)
        {
            return clients.Where(c => c.ClientId == clientId).FirstOrDefault();
        }
        public static DinedClient GetDinedClient(this List<DinedClient> dinedClients, string clientId)
        {
            return dinedClients.Where(c => c.DinedClientId == clientId).FirstOrDefault();
        }
        public static void PrintClientReceipt(this List<DinedClient> dinedClients, string clientId)
        {
            var receipt = new Receipt();
            DinedClient dinedClient = dinedClients.Where(c => c.DinedClientId == clientId).FirstOrDefault();

            receipt.PrintReceipt(dinedClient);
        }
    }
}