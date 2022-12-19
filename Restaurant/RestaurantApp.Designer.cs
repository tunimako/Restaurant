
namespace Restaurant
{
    partial class RestaurantApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiveTable = new System.Windows.Forms.Button();
            this.txtGiveTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableOneClientID = new System.Windows.Forms.TextBox();
            this.txtTableOneProgress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTableTwoProgress = new System.Windows.Forms.TextBox();
            this.txtTableTwoClientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTableThreeProgress = new System.Windows.Forms.TextBox();
            this.txtTableThreeClientID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listNewClients = new System.Windows.Forms.ListView();
            this.ClientID = new System.Windows.Forms.ColumnHeader();
            this.ClientCount = new System.Windows.Forms.ColumnHeader();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTableOneTakeOrder = new System.Windows.Forms.Button();
            this.btnTableTwoTakeOrder = new System.Windows.Forms.Button();
            this.btnTableThreeTakeOrder = new System.Windows.Forms.Button();
            this.btnOpenRestaurant = new System.Windows.Forms.Button();
            this.listViewTableOneOrder = new System.Windows.Forms.ListView();
            this.No = new System.Windows.Forms.ColumnHeader();
            this.Dish = new System.Windows.Forms.ColumnHeader();
            this.Drink = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.listViewTableTwoOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.listViewTableThreeOrder = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnTableOneClear = new System.Windows.Forms.Button();
            this.btnTableTwoClear = new System.Windows.Forms.Button();
            this.btnTableThreeClear = new System.Windows.Forms.Button();
            this.listViewReceipt = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.btnCloseRestaurant = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnSendReceipt = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelRestaurantStatus = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSendReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiveTable
            // 
            this.btnGiveTable.Location = new System.Drawing.Point(171, 288);
            this.btnGiveTable.Name = "btnGiveTable";
            this.btnGiveTable.Size = new System.Drawing.Size(99, 29);
            this.btnGiveTable.TabIndex = 0;
            this.btnGiveTable.Text = "Give Table";
            this.btnGiveTable.UseVisualStyleBackColor = true;
            this.btnGiveTable.Click += new System.EventHandler(this.btnGiveTable_Click);
            // 
            // txtGiveTable
            // 
            this.txtGiveTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiveTable.Location = new System.Drawing.Point(135, 288);
            this.txtGiveTable.Name = "txtGiveTable";
            this.txtGiveTable.Size = new System.Drawing.Size(25, 29);
            this.txtGiveTable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of people waiting in the line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(475, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Table 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(604, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of seats available: 5";
            // 
            // txtTableOneClientID
            // 
            this.txtTableOneClientID.Enabled = false;
            this.txtTableOneClientID.Location = new System.Drawing.Point(475, 124);
            this.txtTableOneClientID.Name = "txtTableOneClientID";
            this.txtTableOneClientID.ReadOnly = true;
            this.txtTableOneClientID.Size = new System.Drawing.Size(123, 23);
            this.txtTableOneClientID.TabIndex = 8;
            // 
            // txtTableOneProgress
            // 
            this.txtTableOneProgress.Enabled = false;
            this.txtTableOneProgress.Location = new System.Drawing.Point(475, 163);
            this.txtTableOneProgress.Name = "txtTableOneProgress";
            this.txtTableOneProgress.ReadOnly = true;
            this.txtTableOneProgress.Size = new System.Drawing.Size(123, 23);
            this.txtTableOneProgress.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(405, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Client ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(405, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Progress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(405, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Progress:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(405, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Client ID:";
            // 
            // txtTableTwoProgress
            // 
            this.txtTableTwoProgress.Enabled = false;
            this.txtTableTwoProgress.Location = new System.Drawing.Point(475, 351);
            this.txtTableTwoProgress.Name = "txtTableTwoProgress";
            this.txtTableTwoProgress.ReadOnly = true;
            this.txtTableTwoProgress.Size = new System.Drawing.Size(123, 23);
            this.txtTableTwoProgress.TabIndex = 18;
            // 
            // txtTableTwoClientID
            // 
            this.txtTableTwoClientID.Enabled = false;
            this.txtTableTwoClientID.Location = new System.Drawing.Point(475, 312);
            this.txtTableTwoClientID.Name = "txtTableTwoClientID";
            this.txtTableTwoClientID.ReadOnly = true;
            this.txtTableTwoClientID.Size = new System.Drawing.Size(123, 23);
            this.txtTableTwoClientID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(604, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of seats available: 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(475, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Table 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(405, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Progress:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(405, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Client ID:";
            // 
            // txtTableThreeProgress
            // 
            this.txtTableThreeProgress.Enabled = false;
            this.txtTableThreeProgress.Location = new System.Drawing.Point(475, 540);
            this.txtTableThreeProgress.Name = "txtTableThreeProgress";
            this.txtTableThreeProgress.ReadOnly = true;
            this.txtTableThreeProgress.Size = new System.Drawing.Size(123, 23);
            this.txtTableThreeProgress.TabIndex = 27;
            // 
            // txtTableThreeClientID
            // 
            this.txtTableThreeClientID.Enabled = false;
            this.txtTableThreeClientID.Location = new System.Drawing.Point(475, 501);
            this.txtTableThreeClientID.Name = "txtTableThreeClientID";
            this.txtTableThreeClientID.ReadOnly = true;
            this.txtTableThreeClientID.Size = new System.Drawing.Size(123, 23);
            this.txtTableThreeClientID.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(604, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Number of seats available: 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(475, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Table 3";
            // 
            // listNewClients
            // 
            this.listNewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientID,
            this.ClientCount});
            this.listNewClients.GridLines = true;
            this.listNewClients.HideSelection = false;
            this.listNewClients.Location = new System.Drawing.Point(30, 114);
            this.listNewClients.Name = "listNewClients";
            this.listNewClients.Size = new System.Drawing.Size(249, 160);
            this.listNewClients.TabIndex = 30;
            this.listNewClients.UseCompatibleStateImageBehavior = false;
            this.listNewClients.View = System.Windows.Forms.View.Details;
            // 
            // ClientID
            // 
            this.ClientID.Text = "ClientID";
            this.ClientID.Width = 130;
            // 
            // ClientCount
            // 
            this.ClientCount.Text = "Number Of Guests";
            this.ClientCount.Width = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(31, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Table number:";
            // 
            // btnTableOneTakeOrder
            // 
            this.btnTableOneTakeOrder.Location = new System.Drawing.Point(405, 211);
            this.btnTableOneTakeOrder.Name = "btnTableOneTakeOrder";
            this.btnTableOneTakeOrder.Size = new System.Drawing.Size(78, 42);
            this.btnTableOneTakeOrder.TabIndex = 32;
            this.btnTableOneTakeOrder.Text = "Take Order";
            this.btnTableOneTakeOrder.UseVisualStyleBackColor = true;
            this.btnTableOneTakeOrder.Click += new System.EventHandler(this.btnTableOneTakeOrder_Click);
            // 
            // btnTableTwoTakeOrder
            // 
            this.btnTableTwoTakeOrder.Location = new System.Drawing.Point(405, 399);
            this.btnTableTwoTakeOrder.Name = "btnTableTwoTakeOrder";
            this.btnTableTwoTakeOrder.Size = new System.Drawing.Size(78, 42);
            this.btnTableTwoTakeOrder.TabIndex = 33;
            this.btnTableTwoTakeOrder.Text = "Take Order";
            this.btnTableTwoTakeOrder.UseVisualStyleBackColor = true;
            this.btnTableTwoTakeOrder.Click += new System.EventHandler(this.btnTableTwoTakeOrder_Click);
            // 
            // btnTableThreeTakeOrder
            // 
            this.btnTableThreeTakeOrder.Location = new System.Drawing.Point(405, 588);
            this.btnTableThreeTakeOrder.Name = "btnTableThreeTakeOrder";
            this.btnTableThreeTakeOrder.Size = new System.Drawing.Size(78, 42);
            this.btnTableThreeTakeOrder.TabIndex = 34;
            this.btnTableThreeTakeOrder.Text = "Take Order";
            this.btnTableThreeTakeOrder.UseVisualStyleBackColor = true;
            this.btnTableThreeTakeOrder.Click += new System.EventHandler(this.btnTableThreeTakeOrder_Click);
            // 
            // btnOpenRestaurant
            // 
            this.btnOpenRestaurant.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenRestaurant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenRestaurant.Location = new System.Drawing.Point(31, 7);
            this.btnOpenRestaurant.Name = "btnOpenRestaurant";
            this.btnOpenRestaurant.Size = new System.Drawing.Size(111, 66);
            this.btnOpenRestaurant.TabIndex = 35;
            this.btnOpenRestaurant.Text = "Open Restaurant";
            this.btnOpenRestaurant.UseVisualStyleBackColor = false;
            this.btnOpenRestaurant.Click += new System.EventHandler(this.btnOpenRestaurant_Click);
            // 
            // listViewTableOneOrder
            // 
            this.listViewTableOneOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Dish,
            this.Drink,
            this.Price});
            this.listViewTableOneOrder.GridLines = true;
            this.listViewTableOneOrder.HideSelection = false;
            this.listViewTableOneOrder.Location = new System.Drawing.Point(604, 124);
            this.listViewTableOneOrder.Name = "listViewTableOneOrder";
            this.listViewTableOneOrder.Size = new System.Drawing.Size(369, 129);
            this.listViewTableOneOrder.TabIndex = 36;
            this.listViewTableOneOrder.UseCompatibleStateImageBehavior = false;
            this.listViewTableOneOrder.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 30;
            // 
            // Dish
            // 
            this.Dish.Text = "Main Course";
            this.Dish.Width = 150;
            // 
            // Drink
            // 
            this.Drink.Text = "Drink";
            this.Drink.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 65;
            // 
            // listViewTableTwoOrder
            // 
            this.listViewTableTwoOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTableTwoOrder.GridLines = true;
            this.listViewTableTwoOrder.HideSelection = false;
            this.listViewTableTwoOrder.Location = new System.Drawing.Point(604, 312);
            this.listViewTableTwoOrder.Name = "listViewTableTwoOrder";
            this.listViewTableTwoOrder.Size = new System.Drawing.Size(369, 129);
            this.listViewTableTwoOrder.TabIndex = 37;
            this.listViewTableTwoOrder.UseCompatibleStateImageBehavior = false;
            this.listViewTableTwoOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Main Course";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Drink";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 65;
            // 
            // listViewTableThreeOrder
            // 
            this.listViewTableThreeOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTableThreeOrder.GridLines = true;
            this.listViewTableThreeOrder.HideSelection = false;
            this.listViewTableThreeOrder.Location = new System.Drawing.Point(604, 501);
            this.listViewTableThreeOrder.Name = "listViewTableThreeOrder";
            this.listViewTableThreeOrder.Size = new System.Drawing.Size(369, 129);
            this.listViewTableThreeOrder.TabIndex = 38;
            this.listViewTableThreeOrder.UseCompatibleStateImageBehavior = false;
            this.listViewTableThreeOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No";
            this.columnHeader5.Width = 30;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Main Course";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Drink";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 65;
            // 
            // btnTableOneClear
            // 
            this.btnTableOneClear.Location = new System.Drawing.Point(489, 211);
            this.btnTableOneClear.Name = "btnTableOneClear";
            this.btnTableOneClear.Size = new System.Drawing.Size(109, 42);
            this.btnTableOneClear.TabIndex = 39;
            this.btnTableOneClear.Text = "Clear Table";
            this.btnTableOneClear.UseVisualStyleBackColor = true;
            this.btnTableOneClear.Click += new System.EventHandler(this.btnTableOneClear_Click);
            // 
            // btnTableTwoClear
            // 
            this.btnTableTwoClear.Location = new System.Drawing.Point(489, 399);
            this.btnTableTwoClear.Name = "btnTableTwoClear";
            this.btnTableTwoClear.Size = new System.Drawing.Size(109, 42);
            this.btnTableTwoClear.TabIndex = 40;
            this.btnTableTwoClear.Text = "Clear Table";
            this.btnTableTwoClear.UseVisualStyleBackColor = true;
            this.btnTableTwoClear.Click += new System.EventHandler(this.btnTableTwoClear_Click);
            // 
            // btnTableThreeClear
            // 
            this.btnTableThreeClear.Location = new System.Drawing.Point(489, 588);
            this.btnTableThreeClear.Name = "btnTableThreeClear";
            this.btnTableThreeClear.Size = new System.Drawing.Size(109, 42);
            this.btnTableThreeClear.TabIndex = 41;
            this.btnTableThreeClear.Text = "Clear Table";
            this.btnTableThreeClear.UseVisualStyleBackColor = true;
            this.btnTableThreeClear.Click += new System.EventHandler(this.btnTableThreeClear_Click);
            // 
            // listViewReceipt
            // 
            this.listViewReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader10,
            this.columnHeader12});
            this.listViewReceipt.GridLines = true;
            this.listViewReceipt.HideSelection = false;
            this.listViewReceipt.Location = new System.Drawing.Point(30, 361);
            this.listViewReceipt.Name = "listViewReceipt";
            this.listViewReceipt.Size = new System.Drawing.Size(345, 221);
            this.listViewReceipt.TabIndex = 42;
            this.listViewReceipt.UseCompatibleStateImageBehavior = false;
            this.listViewReceipt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ClientID";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Guests";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total Price";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Time";
            this.columnHeader12.Width = 90;
            // 
            // btnCloseRestaurant
            // 
            this.btnCloseRestaurant.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseRestaurant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseRestaurant.Location = new System.Drawing.Point(159, 7);
            this.btnCloseRestaurant.Name = "btnCloseRestaurant";
            this.btnCloseRestaurant.Size = new System.Drawing.Size(111, 66);
            this.btnCloseRestaurant.TabIndex = 44;
            this.btnCloseRestaurant.Text = "Close Restaurant";
            this.btnCloseRestaurant.UseVisualStyleBackColor = false;
            this.btnCloseRestaurant.Click += new System.EventHandler(this.btnCloseRestaurant_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(31, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "List of receipts:";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(30, 589);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(72, 42);
            this.btnPrintReceipt.TabIndex = 47;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnSendReceipt
            // 
            this.btnSendReceipt.Location = new System.Drawing.Point(108, 589);
            this.btnSendReceipt.Name = "btnSendReceipt";
            this.btnSendReceipt.Size = new System.Drawing.Size(76, 42);
            this.btnSendReceipt.TabIndex = 48;
            this.btnSendReceipt.Text = "Send Receipt";
            this.btnSendReceipt.UseVisualStyleBackColor = true;
            this.btnSendReceipt.Click += new System.EventHandler(this.btnSendReceipt_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(225, 588);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(72, 43);
            this.btnPrintReport.TabIndex = 49;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(300, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 21);
            this.label15.TabIndex = 50;
            this.label15.Text = "Restaurant Status:";
            // 
            // labelRestaurantStatus
            // 
            this.labelRestaurantStatus.AutoSize = true;
            this.labelRestaurantStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRestaurantStatus.ForeColor = System.Drawing.Color.Red;
            this.labelRestaurantStatus.Location = new System.Drawing.Point(442, 2);
            this.labelRestaurantStatus.Name = "labelRestaurantStatus";
            this.labelRestaurantStatus.Size = new System.Drawing.Size(78, 30);
            this.labelRestaurantStatus.TabIndex = 51;
            this.labelRestaurantStatus.Text = "Closed";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(866, 7);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 21);
            this.labelDate.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(821, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 21);
            this.label18.TabIndex = 52;
            this.label18.Text = "Date:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(866, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 21);
            this.labelTime.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(821, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 21);
            this.label20.TabIndex = 54;
            this.label20.Text = "Time:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSendReport
            // 
            this.btnSendReport.Location = new System.Drawing.Point(303, 587);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(72, 43);
            this.btnSendReport.TabIndex = 56;
            this.btnSendReport.Text = "Send Report";
            this.btnSendReport.UseVisualStyleBackColor = true;
            this.btnSendReport.Click += new System.EventHandler(this.btnSendReport_Click);
            // 
            // RestaurantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 649);
            this.Controls.Add(this.btnSendReport);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelRestaurantStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnSendReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCloseRestaurant);
            this.Controls.Add(this.listViewReceipt);
            this.Controls.Add(this.btnTableThreeClear);
            this.Controls.Add(this.btnTableTwoClear);
            this.Controls.Add(this.btnTableOneClear);
            this.Controls.Add(this.listViewTableThreeOrder);
            this.Controls.Add(this.listViewTableTwoOrder);
            this.Controls.Add(this.listViewTableOneOrder);
            this.Controls.Add(this.btnOpenRestaurant);
            this.Controls.Add(this.btnTableThreeTakeOrder);
            this.Controls.Add(this.btnTableTwoTakeOrder);
            this.Controls.Add(this.btnTableOneTakeOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listNewClients);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTableThreeProgress);
            this.Controls.Add(this.txtTableThreeClientID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTableTwoProgress);
            this.Controls.Add(this.txtTableTwoClientID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTableOneProgress);
            this.Controls.Add(this.txtTableOneClientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiveTable);
            this.Controls.Add(this.btnGiveTable);
            this.Name = "RestaurantApp";
            this.Text = "RestaurantApp";
            this.Load += new System.EventHandler(this.RestaurantApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiveTable;
        private System.Windows.Forms.TextBox txtGiveTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableOneClientID;
        private System.Windows.Forms.TextBox txtTableOneProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTableTwoProgress;
        private System.Windows.Forms.TextBox txtTableTwoClientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTableThreeProgress;
        private System.Windows.Forms.TextBox txtTableThreeClientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listNewClients;
        private System.Windows.Forms.ColumnHeader ClientID;
        private System.Windows.Forms.ColumnHeader ClientCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTableOneTakeOrder;
        private System.Windows.Forms.Button btnTableTwoTakeOrder;
        private System.Windows.Forms.Button btnTableThreeTakeOrder;
        private System.Windows.Forms.Button btnOpenRestaurant;
        private System.Windows.Forms.ListView listViewTableOneOrder;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Dish;
        private System.Windows.Forms.ColumnHeader Drink;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView listViewTableTwoOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewTableThreeOrder;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnTableOneClear;
        private System.Windows.Forms.Button btnTableTwoClear;
        private System.Windows.Forms.Button btnTableThreeClear;
        private System.Windows.Forms.ListView listViewReceipt;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnCloseRestaurant;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnSendReceipt;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelRestaurantStatus;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnSendReport;
    }
}
