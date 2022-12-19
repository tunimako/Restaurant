using RestaurantLibrary.Models;
using RestaurantLibrary.Repositories;
using RestaurantLibrary.Services;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class RestaurantApp : Form
    {
        public CancellationTokenSource TokenSource;
        public Graphics? TableOneGraphics;
        public Graphics? TableTwoGraphics;
        public Graphics? TableThreeGraphics;
        public OrderRepository TableOneOrder;
        public OrderRepository TableTwoOrder;
        public OrderRepository TableThreeOrder;
        public TableRepository TableData;
        public ClientRepository ClientData;
        public RestaurantData RestaurantData;
        public bool RestaurantStatus = false;
        public RestaurantApp()
        {
            TableData = new();
            ClientData = new();
            RestaurantData = new();

            InitializeComponent();
            InitializeGraphics();
        }
        private void InitializeGraphics()
        {
            TableOneGraphics = CreateGraphics();
            TableTwoGraphics = CreateGraphics();
            TableThreeGraphics = CreateGraphics();
        }
        private void btnOpenRestaurant_Click(object sender, EventArgs e)
        {
            if (RestaurantStatus == false)
            {
                RestaurantStatus = true;
                TokenSource = new CancellationTokenSource();
                var token = TokenSource.Token;
                labelRestaurantStatus.Text = "Open";
                labelRestaurantStatus.ForeColor = Color.Green;
                ClientData.GenerateClientsAsync(listNewClients, token);
                TableData.TurnTablesGreenLight(TableOneGraphics, TableTwoGraphics, TableThreeGraphics);
            }
            else
            {
                MessageBox.Show("\tRestaurant is Opened.\t", "Open Restaurant");
            }
        }
        private void btnGiveTable_Click(object sender, EventArgs e)
        {
            if (!ClientData.IsClientSelected(listNewClients, btnGiveTable.Text))
            {
                return;
            }
            switch (txtGiveTable.Text)
            {
                case "1":
                    TableData.GiveTable(listNewClients.SelectedItems[0],
                                        txtGiveTable,
                                        txtTableOneClientID,
                                        txtTableOneProgress,
                                        TableOneGraphics,
                                        btnGiveTable.Text);
                    break;

                case "2":
                    TableData.GiveTable(listNewClients.SelectedItems[0],
                                        txtGiveTable,
                                        txtTableTwoClientID,
                                        txtTableTwoProgress,
                                        TableTwoGraphics,
                                        btnGiveTable.Text);
                    break;

                case "3":
                    TableData.GiveTable(listNewClients.SelectedItems[0],
                                       txtGiveTable,
                                       txtTableThreeClientID,
                                       txtTableThreeProgress,
                                       TableThreeGraphics,
                                       btnGiveTable.Text);
                    break;

                default:
                    MessageBox.Show("Such table do not exists", btnGiveTable.Text);

                    break;
            }
        }
        private void btnCloseRestaurant_Click(object sender, EventArgs e)
        {
            if (RestaurantStatus == true)
            {
                RestaurantStatus = false;
                listNewClients.Items.Clear();
                labelRestaurantStatus.Text = "Closed";
                labelRestaurantStatus.ForeColor = Color.Red;
                TokenSource.Cancel();
            }
            else
            {
                MessageBox.Show("\tRestaurant is Closed.\t", "Close Restaurant");
            }
        }
        private void btnTableOneTakeOrder_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(1);

            if (table.ProgressStatus == Table.STATUS_READY &&
                listViewTableOneOrder.Items.Count == 0)
            {
                TableOneOrder = new OrderRepository(ClientData.Clients.GetClient(txtTableOneClientID.Text));
                listViewTableOneOrder.Items.AddRange(TableOneOrder.TakeOrder());
                TableData.EatingStatusAsync(table, txtTableOneProgress);
            }
            else if (listViewTableOneOrder.Items.Count > 0)
            {
                MessageBox.Show("Client has already ordered", btnTableOneTakeOrder.Text);
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableOneTakeOrder.Text);
            }
            else
            {
                MessageBox.Show("Client is not ready to order", btnTableOneTakeOrder.Text);
            }
        }
        private void btnTableTwoTakeOrder_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(2);

            if (table.ProgressStatus == Table.STATUS_READY &&
                listViewTableTwoOrder.Items.Count == 0)
            {
                TableTwoOrder = new OrderRepository(ClientData.Clients.GetClient(txtTableTwoClientID.Text));
                listViewTableTwoOrder.Items.AddRange(TableTwoOrder.TakeOrder());
                TableData.EatingStatusAsync(table, txtTableTwoProgress);
            }
            else if (listViewTableTwoOrder.Items.Count > 0)
            {
                MessageBox.Show("Client has already ordered.", btnTableTwoTakeOrder.Text);
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableTwoTakeOrder.Text);
            }
            else
            {
                MessageBox.Show("Client is not ready to order.", btnTableTwoTakeOrder.Text);
            }
        }
        private void btnTableThreeTakeOrder_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(3);

            if (table.ProgressStatus == Table.STATUS_READY &&
                listViewTableThreeOrder.Items.Count == 0)
            {
                TableThreeOrder = new OrderRepository(ClientData.Clients.GetClient(txtTableThreeClientID.Text));
                listViewTableThreeOrder.Items.AddRange(TableThreeOrder.TakeOrder());
                TableData.EatingStatusAsync(table, txtTableThreeProgress);
            }
            else if (listViewTableThreeOrder.Items.Count > 0)
            {
                MessageBox.Show("Client has already ordered.", btnTableThreeTakeOrder.Text);
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableThreeTakeOrder.Text);
            }
            else
            {
                MessageBox.Show("Client is not ready to order.", btnTableThreeTakeOrder.Text);
            }
        }
        private void btnTableOneClear_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(1);

            if (table.ProgressStatus == Table.STATUS_PAY)
            {
                DinedClient dinedClient = ClientData.GenerateDinedClient(table, txtTableOneClientID, TableOneOrder.ClientOrder);
                TableData.ClearTable(table, txtTableOneClientID, txtTableOneProgress, listViewTableOneOrder, TableOneGraphics);
                listViewReceipt.Items.Add(ClientData.SaveReceipt(dinedClient));
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableOneClear.Text);
            }
            else
            {
                MessageBox.Show("Client is still eating.", btnTableOneClear.Text);
            }
        }
        private void btnTableTwoClear_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(2);

            if (table.ProgressStatus == Table.STATUS_PAY)
            {
                DinedClient dinedClient = ClientData.GenerateDinedClient(table, txtTableTwoClientID, TableTwoOrder.ClientOrder);
                TableData.ClearTable(table, txtTableTwoClientID, txtTableTwoProgress, listViewTableTwoOrder, TableTwoGraphics);
                listViewReceipt.Items.Add(ClientData.SaveReceipt(dinedClient));
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableTwoClear.Text);
            }
            else
            {
                MessageBox.Show("Client is still eating.", btnTableTwoClear.Text);
            }
        }
        private void btnTableThreeClear_Click(object sender, EventArgs e)
        {
            Table table = TableData.ReturnTable(3);

            if (table.ProgressStatus == Table.STATUS_PAY)
            {
                DinedClient dinedClient = ClientData.GenerateDinedClient(table, txtTableThreeClientID, TableThreeOrder.ClientOrder);
                TableData.ClearTable(table, txtTableThreeClientID, txtTableThreeProgress, listViewTableThreeOrder, TableThreeGraphics);
                listViewReceipt.Items.Add(ClientData.SaveReceipt(dinedClient));
            }
            else if (table.ProgressStatus == Table.STATUS_EMPTY)
            {
                MessageBox.Show("Table is empty.", btnTableThreeClear.Text);
            }
            else
            {
                MessageBox.Show("Client is still eating.", btnTableThreeClear.Text);
            }
        }
        private void RestaurantApp_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("d");
            Clock.ClockAsync(labelTime);
        }
        private void btnSendReceipt_Click(object sender, EventArgs e)
        {
            SendReceipt sendReceiptForm = new SendReceipt();

            if (!ClientData.IsClientSelected(listViewReceipt, btnSendReceipt.Text)||
                !ClientData.ContainsEmail(listViewReceipt.SelectedItems[0], btnSendReceipt.Text))
            {
                return;
            }
            else
            {
                sendReceiptForm.GatherInformation(ClientData,listViewReceipt.SelectedItems[0]);
                sendReceiptForm.ShowDialog();
            }
        }
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (!ClientData.IsClientSelected(listViewReceipt, btnPrintReceipt.Text))
            {
                return;
            }
            else
            {   
                ClientData.DinedClients.PrintClientReceipt(listViewReceipt.SelectedItems[0].Text);
                MessageBox.Show("Client receipt has been printed!", btnPrintReceipt.Text);
            }
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            RestaurantData.PrintRestaurantReport(ClientData.DinedClients, btnPrintReport.Text);
        }
        private void btnSendReport_Click(object sender, EventArgs e)
        {
            string restaurnatEmail = "TastyFood@gmail.com";
            RestaurantData.SendEmail(restaurnatEmail, btnSendReport.Text);
        }
    }
}