using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantLibrary.Models;
using System.Windows.Forms;
using RestaurantLibrary.Extentions;
using System.Drawing;

namespace RestaurantLibrary.Repositories
{
    public class TableRepository
    {
        public List<Table> Tables { get; set; }
        public TableRepository()
        {
            Tables = new List<Table>();
            Tables.Add(new Table(1, 5, true, Table.STATUS_EMPTY));
            Tables.Add(new Table(2, 4, true, Table.STATUS_EMPTY));
            Tables.Add(new Table(3, 4, true, Table.STATUS_EMPTY));
        }
        public void GiveTable(ListViewItem list, TextBox selectedTable, TextBox clientId, TextBox progress, Graphics graphics, string buttonName)
        {
            Table table = ReturnTable(selectedTable, buttonName);

            if (IsTableAvailable(table, buttonName) && IsTableHaveEnoughSeats(table, list, buttonName))
            {   
                ReserveTable(table,list);
                clientId.Text = list.Text;
                table.TimeTableTaken = DateTime.Now;
                SelectedTableGreenLight(selectedTable.Text, graphics, false);
                _ = PendingStatusAsync(table, progress);
            }
        }
        public void ClearTable(Table selectedTable, TextBox clientId, TextBox progress, ListView listView, Graphics graphics)
        {
            clientId.Clear();
            listView.Items.Clear();
            selectedTable.AvailabilityStatus = true;
            SelectedTableGreenLight(selectedTable.TableId.ToString(), graphics, true);
            selectedTable.ProgressStatus = Table.STATUS_EMPTY;
            progress.Text = Table.STATUS_EMPTY;
        }
        public void TurnTablesGreenLight(Graphics tableOne, Graphics tableTwo, Graphics tableThree)
        {
            tableOne.TableOneGreenLight(true);
            tableTwo.TableTwoGreenLight(true);
            tableThree.TableThreeGreenLight(true);
        }
        public Table ReserveTable(Table table, ListViewItem list)
        {
            list.Remove();
            table.AvailabilityStatus = false;

            return table;
        }
        public Table ReturnTable(int tableId)
        {
            if (tableId > 0 && tableId <= Tables.Count)
            {
                return Tables.Where(table => table.TableId == tableId).FirstOrDefault();
            }
            else
            {
                throw new Exception("Table do not exists!");
            }
        }
        private Table ReturnTable(TextBox selectedTable, string buttonName)
        {
            if (Int32.TryParse(selectedTable.Text, out int tableId))
            {
                return ReturnTable(tableId);
            }
            else
            {
                MessageBox.Show("Such table do not exists", buttonName);
                return null;
            }
        }
        public async Task PendingStatusAsync(Table table, TextBox textBox)
        {
            var random = new Random();
            table.ProgressStatus = Table.STATUS_WAITING;
            textBox.Text = table.ProgressStatus;

            await Task.Delay(random.Next(10000,20000));
            table.ProgressStatus = Table.STATUS_READY;
            textBox.Text = table.ProgressStatus;
        }
        public async Task EatingStatusAsync(Table table, TextBox textBox)
        {
            var random = new Random();
            table.ProgressStatus = Table.STATUS_EATING;
            textBox.Text = table.ProgressStatus;

            await Task.Delay(random.Next(15000,35000));
            table.ProgressStatus = Table.STATUS_PAY;
            textBox.Text = table.ProgressStatus;
        }
        public static bool IsTableAvailable(Table table, string buttonName)
        {
            if (table.AvailabilityStatus)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Table is already taken. Choose another table!", buttonName);
                return false;
            }
        }
        private static bool IsTableHaveEnoughSeats(Table table, ListViewItem list, string buttonName)
        {
            if (table.NumberOfSeats < Int32.Parse(list.SubItems[1].Text))
            {
                MessageBox.Show("Table do not have enough seats. Choose another table!", buttonName);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SelectedTableGreenLight(string selectedTable, Graphics graphics, bool status)
        {
            switch (selectedTable)
            {
                case "1":
                    graphics.TableOneGreenLight(status);
                    break;

                case "2":
                    graphics.TableTwoGreenLight(status);
                    break;

                case "3":
                    graphics.TableThreeGreenLight(status);
                    break;
            }
        }
    }
}