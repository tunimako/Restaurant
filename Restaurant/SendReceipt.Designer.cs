namespace Restaurant
{
    partial class SendReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendReceipt = new System.Windows.Forms.Button();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lableErrorMessage = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendReceipt
            // 
            this.btnSendReceipt.Location = new System.Drawing.Point(101, 167);
            this.btnSendReceipt.Name = "btnSendReceipt";
            this.btnSendReceipt.Size = new System.Drawing.Size(102, 36);
            this.btnSendReceipt.TabIndex = 0;
            this.btnSendReceipt.Text = "Send Receipt";
            this.btnSendReceipt.UseVisualStyleBackColor = true;
            this.btnSendReceipt.Click += new System.EventHandler(this.btnSendReceipt_Click);
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(54, 117);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(195, 23);
            this.txtClientEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Clients Email";
            // 
            // lableErrorMessage
            // 
            this.lableErrorMessage.AutoSize = true;
            this.lableErrorMessage.Location = new System.Drawing.Point(54, 143);
            this.lableErrorMessage.Name = "lableErrorMessage";
            this.lableErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lableErrorMessage.TabIndex = 3;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(54, 70);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(195, 23);
            this.txtClientId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ClientId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // SendReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lableErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.btnSendReceipt);
            this.Name = "SendReceipt";
            this.Text = "SendReceipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendReceipt;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableErrorMessage;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}