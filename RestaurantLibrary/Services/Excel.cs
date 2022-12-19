using Microsoft.Office.Interop.Excel;
using RestaurantLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MessageBox = System.Windows.Forms.MessageBox;

namespace RestaurantLibrary.Services
{
    public class Excel
    {
        public Application ExcelApp = new Application();
        public Workbook WorkBook { get; set; }
        public Worksheet WorkSheet { get; set; }
        public string FullPath { get; set; }
        public Excel(string filePath)
        {
            WorkBook = ExcelApp.Workbooks.Open(filePath);
            FullPath = filePath;
        }
        public void SaveData(DinedClient client)
        {
            WorkSheet = WorkBook.Worksheets[1];
            int row = 1;

            for (; ; )
            {
                row++;
                if (WorkSheet.Cells[row, 1].Value == null)
                {
                    WorkSheet.Cells[row, 1] = row - 1;
                    WorkSheet.Cells[row, 2] = client.TableNumber;
                    WorkSheet.Cells[row, 3] = client.DinedClientId;
                    WorkSheet.Cells[row, 4] = client.GuestCount;
                    WorkSheet.Cells[row, 5] = SaveOrderedDishes(client.DinedClientOrder);
                    WorkSheet.Cells[row, 6] = SaveOrderedDrinks(client.DinedClientOrder);
                    WorkSheet.Cells[row, 7] = client.Bill;
                    WorkSheet.Cells[row, 8] = client.EntryTime;
                    WorkSheet.Cells[row, 9] = client.ExitingTime;
                    WorkSheet.Cells[row, 10] = client.DinedClientEmail;
                    Borders border = WorkSheet.Range[$"A2", $"J{row}"].Borders;
                    border.LineStyle = XlLineStyle.xlContinuous;
                    border.Weight = 2d;

                    Save();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void SaveData(DinedClient client, string emailAddress)
        {
            WorkSheet = WorkBook.Worksheets[1];
            int lastRow = GetLastRow();

            for (int i = 2; i <= lastRow; i++)
            {
                if (WorkSheet.Cells[i, 3].Value == client.DinedClientId)
                {
                    WorkSheet.Cells[i, 10] = emailAddress;
                }
            }
            Save();
        }
        public List<Dish> GetDishes()
        {
            int lastRow = GetLastRow();
            List<Dish> dishes = new();
            WorkSheet = WorkBook.Worksheets[1];

            for (int i = 2; i <= lastRow; i++)
            {
                Dish dish = new((string)WorkSheet.Cells[i, 1].Value,
                                (decimal)WorkSheet.Cells[i, 2].Value);

                dishes.Add(dish);
            }
            Close();
            return dishes;
        }
        public List<Drink> GetDrinks()
        {
            int lastRow = GetLastRow();
            List<Drink> drinks = new();
            WorkSheet = WorkBook.Worksheets[1];

            for (int i = 2; i <= lastRow; i++)
            {
                drinks.Add(new Drink((string)WorkSheet.Cells[i, 1].Value,
                                     (decimal)WorkSheet.Cells[i, 2].Value));
            }

            Close();
            return drinks;
        }
        public void PrintReport(List<DinedClient> dinedClients)
        {
            int reportRow = 3;
            decimal totalPriceCount = 0;
            WorkSheet = WorkBook.Worksheets[2];
            ClearReport();

            Borders border = WorkSheet.Range[$"H{reportRow}", $"N{dinedClients.Count + reportRow - 1}"].Borders;
            border.LineStyle = XlLineStyle.xlContinuous;
            border.Weight = 2d;
            WorkSheet.Cells[3, 3] = dinedClients.Count;
            WorkSheet.Cells[3, 6] = DateTime.Today.ToString();
            foreach (DinedClient client in dinedClients)
            {
                totalPriceCount += client.Bill;
                WorkSheet.Cells[reportRow, 8] = client.DinedClientCount;
                WorkSheet.Cells[reportRow, 9] = client.DinedClientId;
                WorkSheet.Cells[reportRow, 10] = client.GuestCount;
                WorkSheet.Cells[reportRow, 11] = client.EntryTime.ToString("T");
                WorkSheet.Cells[reportRow, 12] = client.TableNumber;
                WorkSheet.Cells[reportRow, 13] = client.Bill;
                WorkSheet.Cells[reportRow, 14] = client.DinedClientEmail;
                GenerateDishReport(client.DinedClientOrder, WorkSheet);
                GenerateDrinkReport(client.DinedClientOrder, WorkSheet);
                reportRow++;
            }
            WorkSheet.Cells[4, 3] = totalPriceCount;
            WorkSheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Directory.GetParent(FullPath).Parent.FullName + @"\Report\Restaurant_Report.pdf");

            Save();
        }
        public void PrintReceipt(DinedClient client)
        {
            WorkSheet = WorkBook.Worksheets[1];
            ClearReceipt();

            WorkSheet.Cells[13, 2] = "#" + client.OrderId;
            WorkSheet.Cells[14, 2] = client.DinedClientId;
            WorkSheet.Cells[14, 5] = client.GuestCount;
            WorkSheet.Cells[15, 2] = client.EntryTime.Date;
            WorkSheet.Cells[16, 2] = client.EntryTime.ToString("HH:mm");
            WorkSheet.Cells[17, 2] = "#" + client.TableNumber;
            int line = GenerateDishOrders(client.DinedClientOrder, WorkSheet);
            GenerateDrinkOrders(client.DinedClientOrder, WorkSheet, line);
            WorkSheet.Cells[31, 5] = client.Bill.ToString();
            WorkSheet.Cells[33, 2] = client.ExitingTime.ToString("HH:mm");
            WorkSheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Directory.GetParent(FullPath).Parent.FullName + @$"\Receipts\{client.DinedClientId}.pdf");

            Save();
        }
        private void GenerateDishReport(List<Order> orders, Worksheet worksheet)
        {
            var dishNames = new List<string>();
            orders.ForEach(dish => dishNames.Add(dish.SelectedDish.DishName));
            var dishNamesSorted = dishNames.GroupBy(d => d)
                                           .Select(x => new { Value = x.Key, Count = x.Count() })
                                           .OrderByDescending(x => x.Count);
            int row = 8;

            foreach(var dish in dishNamesSorted)
            {  
                for(int i = row; i < row + 8; i++)
                {
                    if (worksheet.Cells[i, 2].Value == dish.Value)
                    {
                        worksheet.Cells[i, 3].Value += dish.Count;
                    }
                }
            }
        }
        private void GenerateDrinkReport(List<Order> orders, Worksheet worksheet)
        {
            var drinkNames = new List<string>();
            orders.ForEach(drink => drinkNames.Add(drink.SelectedDrink.DrinkName));
            drinkNames.RemoveAll(drink => drink == "-");
            var drinkNamesSorted = drinkNames.GroupBy(d => d)
                                             .Select(x => new { Value = x.Key, Count = x.Count() })
                                             .OrderByDescending(x => x.Count);
            int row = 8;

            foreach (var drink in drinkNamesSorted)
            {
                for (int i = row; i < row + 9; i++)
                {
                    if (worksheet.Cells[i, 5].Value == drink.Value)
                    {
                        worksheet.Cells[i, 6].Value += drink.Count;
                    }
                }
            }
        }
        private string SaveOrderedDishes(List<Order> order)
        {
            var dishNameList = new List<string>();
            order.ForEach(dishes => dishNameList.Add(dishes.SelectedDish.DishName));
            dishNameList.RemoveAll(dish => dish == "-");

            return string.Join(", ", dishNameList);
        }
        private string SaveOrderedDrinks(List<Order> order)
        {
            var drinkNameList = new List<string>();
            order.ForEach(dishes => drinkNameList.Add(dishes.SelectedDrink.DrinkName));
            drinkNameList.RemoveAll(drink => drink == "-");

            return string.Join(", ", drinkNameList);
        }
        private void ClearReceipt()
        {
            WorkSheet.Range["B13:B17"].ClearContents();
            WorkSheet.Cells[14, 5].ClearContents();
            WorkSheet.Range["A20:E29"].ClearContents();
            WorkSheet.Cells[31, 5].ClearContents();
            WorkSheet.Cells[33, 2].ClearContents();
        }
        private void ClearReport()
        {
            WorkSheet.Range["C3:C4"].ClearContents();
            WorkSheet.Cells[3, 7].ClearContents();
            WorkSheet.Range["C8:C15"].Value = 0;
            WorkSheet.Range["F8:F16"].Value = 0;
            WorkSheet.Range["H3:N100"].ClearContents();
            WorkSheet.Range["H3:N100"].Borders.LineStyle = XlLineStyle.xlLineStyleNone;
        }
        private int GenerateDishOrders(List<Order> orders, Worksheet worksheet)
        {
            var dishNames = new List<string>();
            orders.ForEach(dish => dishNames.Add(dish.SelectedDish.DishName));
            dishNames.RemoveAll(dish => dish == "-");
            var dishNamesSorted = dishNames.GroupBy(d => d)
                                .Select(x => new { Value = x.Key, Count = x.Count() })
                                .OrderByDescending(x => x.Count);
            int line = 20;

            foreach (var dish in dishNamesSorted)
            {
                worksheet.Cells[line, 1] = dish.Value;
                worksheet.Cells[line, 4] = dish.Count;
                worksheet.Cells[line, 5] = orders.Where(x => x.SelectedDish.DishName == dish.Value)
                                                 .FirstOrDefault().SelectedDish.DishPrice;
                line++;
            }
            return line;
        }
        private void GenerateDrinkOrders(List<Order> orders, Worksheet worksheet, int line)
        {
            var drinkNames = new List<string>();
            orders.ForEach(drink => drinkNames.Add(drink.SelectedDrink.DrinkName));
            drinkNames.RemoveAll(drink => drink == "-");
            var drinkNamesSorted = drinkNames.GroupBy(d => d)
                                .Select(x => new { Value = x.Key, Count = x.Count() })
                                .OrderByDescending(x => x.Count);

            foreach (var drink in drinkNamesSorted)
            {
                worksheet.Cells[line, 1] = drink.Value;
                worksheet.Cells[line, 4] = drink.Count;
                worksheet.Cells[line, 5] = orders.Where(x => x.SelectedDrink.DrinkName == drink.Value)
                                                 .FirstOrDefault().SelectedDrink.DrinkPrice;
                line++;
            }
        }
        private int GetLastRow()
        {
            WorkSheet = WorkBook.Worksheets[1];
            return WorkSheet.Cells.Find("*", SearchOrder: XlSearchOrder.xlByRows, SearchDirection: XlSearchDirection.xlPrevious).Row;
        }
        private void Save()
        {
            try
            {
                WorkBook.Save();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("INFORMATION HAVEN'T BEEN SAVED!\n\n(File must be closed before saving any data into it)");
            }
        }
        private void Close()
        {
            WorkBook.Close(0);
            ExcelApp.Quit();
        }
    }
}