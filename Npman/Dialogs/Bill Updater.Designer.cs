namespace Npman.Dialogs
{
    partial class ManualBillUpdater
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualBillUpdater));
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.New_Bill = new System.Windows.Forms.TextBox();
            this.BillUpdater = new System.Windows.Forms.TabControl();
            this.BillPayment = new System.Windows.Forms.TabPage();
            this.New_Bill1 = new System.Windows.Forms.TextBox();
            this.pay_rec = new System.Windows.Forms.Label();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.Save1 = new System.Windows.Forms.Button();
            this.Cur_Bill1 = new System.Windows.Forms.Label();
            this.Cust_Add1 = new System.Windows.Forms.Label();
            this.ManualBillUpdate = new System.Windows.Forms.TabPage();
            this.Cur_Bill = new System.Windows.Forms.Label();
            this.Cust_Add = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.BillUpdater.SuspendLayout();
            this.BillPayment.SuspendLayout();
            this.ManualBillUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // New_Bill
            // 
            this.New_Bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Error.SetIconPadding(this.New_Bill, 5);
            this.New_Bill.Location = new System.Drawing.Point(127, 108);
            this.New_Bill.MaxLength = 32;
            this.New_Bill.Name = "New_Bill";
            this.New_Bill.Size = new System.Drawing.Size(122, 20);
            this.New_Bill.TabIndex = 8;
            // 
            // BillUpdater
            // 
            this.BillUpdater.Controls.Add(this.BillPayment);
            this.BillUpdater.Controls.Add(this.ManualBillUpdate);
            this.BillUpdater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillUpdater.Location = new System.Drawing.Point(0, 0);
            this.BillUpdater.Name = "BillUpdater";
            this.BillUpdater.SelectedIndex = 0;
            this.BillUpdater.Size = new System.Drawing.Size(310, 260);
            this.BillUpdater.TabIndex = 0;
            // 
            // BillPayment
            // 
            this.BillPayment.BackColor = System.Drawing.SystemColors.Control;
            this.BillPayment.Controls.Add(this.New_Bill1);
            this.BillPayment.Controls.Add(this.pay_rec);
            this.BillPayment.Controls.Add(this.Cancel1);
            this.BillPayment.Controls.Add(this.Save1);
            this.BillPayment.Controls.Add(this.Cur_Bill1);
            this.BillPayment.Controls.Add(this.Cust_Add1);
            this.BillPayment.Location = new System.Drawing.Point(4, 22);
            this.BillPayment.Name = "BillPayment";
            this.BillPayment.Padding = new System.Windows.Forms.Padding(3);
            this.BillPayment.Size = new System.Drawing.Size(302, 234);
            this.BillPayment.TabIndex = 0;
            this.BillPayment.Text = "Bill Payment";
            // 
            // New_Bill1
            // 
            this.New_Bill1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Bill1.Location = new System.Drawing.Point(153, 105);
            this.New_Bill1.Name = "New_Bill1";
            this.New_Bill1.Size = new System.Drawing.Size(100, 20);
            this.New_Bill1.TabIndex = 18;
            // 
            // pay_rec
            // 
            this.pay_rec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pay_rec.AutoSize = true;
            this.pay_rec.Location = new System.Drawing.Point(40, 108);
            this.pay_rec.Name = "pay_rec";
            this.pay_rec.Size = new System.Drawing.Size(106, 13);
            this.pay_rec.TabIndex = 17;
            this.pay_rec.Text = "Payment Received : ";
            // 
            // Cancel1
            // 
            this.Cancel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel1.Location = new System.Drawing.Point(153, 145);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(100, 23);
            this.Cancel1.TabIndex = 16;
            this.Cancel1.Text = "Cancel";
            this.Cancel1.UseVisualStyleBackColor = true;
            this.Cancel1.Click += new System.EventHandler(this.Cancel_Clicked);
            // 
            // Save1
            // 
            this.Save1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save1.Location = new System.Drawing.Point(40, 145);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(100, 23);
            this.Save1.TabIndex = 15;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // Cur_Bill1
            // 
            this.Cur_Bill1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cur_Bill1.AutoSize = true;
            this.Cur_Bill1.Location = new System.Drawing.Point(40, 80);
            this.Cur_Bill1.Name = "Cur_Bill1";
            this.Cur_Bill1.Size = new System.Drawing.Size(66, 13);
            this.Cur_Bill1.TabIndex = 14;
            this.Cur_Bill1.Text = "Current Bill : ";
            // 
            // Cust_Add1
            // 
            this.Cust_Add1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cust_Add1.AutoSize = true;
            this.Cust_Add1.Location = new System.Drawing.Point(40, 52);
            this.Cust_Add1.Name = "Cust_Add1";
            this.Cust_Add1.Size = new System.Drawing.Size(101, 13);
            this.Cust_Add1.TabIndex = 13;
            this.Cust_Add1.Text = "Customer Address : ";
            // 
            // ManualBillUpdate
            // 
            this.ManualBillUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.ManualBillUpdate.Controls.Add(this.Cur_Bill);
            this.ManualBillUpdate.Controls.Add(this.Cust_Add);
            this.ManualBillUpdate.Controls.Add(this.Cancel);
            this.ManualBillUpdate.Controls.Add(this.Save);
            this.ManualBillUpdate.Controls.Add(this.New_Bill);
            this.ManualBillUpdate.Controls.Add(this.label1);
            this.ManualBillUpdate.Location = new System.Drawing.Point(4, 22);
            this.ManualBillUpdate.Name = "ManualBillUpdate";
            this.ManualBillUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.ManualBillUpdate.Size = new System.Drawing.Size(302, 234);
            this.ManualBillUpdate.TabIndex = 1;
            this.ManualBillUpdate.Text = "Manual Bill  Update";
            // 
            // Cur_Bill
            // 
            this.Cur_Bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cur_Bill.AutoSize = true;
            this.Cur_Bill.Location = new System.Drawing.Point(39, 80);
            this.Cur_Bill.Name = "Cur_Bill";
            this.Cur_Bill.Size = new System.Drawing.Size(66, 13);
            this.Cur_Bill.TabIndex = 12;
            this.Cur_Bill.Text = "Current Bill : ";
            // 
            // Cust_Add
            // 
            this.Cust_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cust_Add.AutoSize = true;
            this.Cust_Add.Location = new System.Drawing.Point(39, 52);
            this.Cust_Add.Name = "Cust_Add";
            this.Cust_Add.Size = new System.Drawing.Size(101, 13);
            this.Cust_Add.TabIndex = 11;
            this.Cust_Add.Text = "Customer Address : ";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(149, 145);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Clicked);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.Location = new System.Drawing.Point(42, 145);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter New Bill : ";
            // 
            // ManualBillUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 260);
            this.Controls.Add(this.BillUpdater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualBillUpdater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Bill";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.BillUpdater.ResumeLayout(false);
            this.BillPayment.ResumeLayout(false);
            this.BillPayment.PerformLayout();
            this.ManualBillUpdate.ResumeLayout(false);
            this.ManualBillUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.TabControl BillUpdater;
        private System.Windows.Forms.TabPage BillPayment;
        private System.Windows.Forms.TabPage ManualBillUpdate;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox New_Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cur_Bill;
        private System.Windows.Forms.Label Cust_Add;
        private System.Windows.Forms.Label Cur_Bill1;
        private System.Windows.Forms.Label Cust_Add1;
        private System.Windows.Forms.TextBox New_Bill1;
        private System.Windows.Forms.Label pay_rec;
        private System.Windows.Forms.Button Cancel1;
        private System.Windows.Forms.Button Save1;
    }
}