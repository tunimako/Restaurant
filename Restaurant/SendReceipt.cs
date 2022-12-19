using RestaurantLibrary.Repositories;
using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class SendReceipt : Form
    {
        public ClientRepository? ClientData;
        public SendReceipt()
        {
            InitializeComponent();
        }
        private void btnSendReceipt_Click(object sender, EventArgs e)
        {
            if (Email.EmailCheck(txtClientEmail, lableErrorMessage) &&
                ClientData is not null)
            {
                ClientData.SendEmail(txtClientEmail.Text, btnSendReceipt.Text);
                ClientData.AddClientEmail(ClientData.DinedClients ,txtClientId.Text, txtClientEmail.Text);

                this.Close();
            }
        }
        public void GatherInformation(ClientRepository clientData, ListViewItem listItem)
        {
            ClientData = clientData;
            txtClientId.Text = listItem.Text;
        }
    }
}