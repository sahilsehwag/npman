namespace Npman.Dialogs
{
    partial class SchemeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemeSelector));
            this.Newspaper_Chooser = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.cust_add = new System.Windows.Forms.Label();
            this.choose_news = new System.Windows.Forms.Label();
            this.cheque = new System.Windows.Forms.CheckBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Details = new System.Windows.Forms.Button();
            this.s_date = new System.Windows.Forms.Label();
            this.e_date = new System.Windows.Forms.Label();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.scheme_start = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Newspaper_Chooser
            // 
            this.Newspaper_Chooser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Newspaper_Chooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Newspaper_Chooser.FormattingEnabled = true;
            this.Newspaper_Chooser.Location = new System.Drawing.Point(149, 112);
            this.Newspaper_Chooser.Name = "Newspaper_Chooser";
            this.Newspaper_Chooser.Size = new System.Drawing.Size(108, 21);
            this.Newspaper_Chooser.TabIndex = 0;
            this.Newspaper_Chooser.SelectedIndexChanged += new System.EventHandler(this.Selected_News_Changed);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(39, 279);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start Scheme";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(156, 279);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(101, 23);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop Scheme";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(39, 317);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(156, 317);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(101, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // cust_add
            // 
            this.cust_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cust_add.AutoSize = true;
            this.cust_add.Location = new System.Drawing.Point(39, 76);
            this.cust_add.Name = "cust_add";
            this.cust_add.Size = new System.Drawing.Size(107, 13);
            this.cust_add.TabIndex = 5;
            this.cust_add.Text = "Customer Address  :  ";
            // 
            // choose_news
            // 
            this.choose_news.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choose_news.AutoSize = true;
            this.choose_news.Location = new System.Drawing.Point(39, 115);
            this.choose_news.Name = "choose_news";
            this.choose_news.Size = new System.Drawing.Size(103, 13);
            this.choose_news.TabIndex = 6;
            this.choose_news.Text = "Select Newspaper : ";
            // 
            // cheque
            // 
            this.cheque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cheque.AutoSize = true;
            this.cheque.Enabled = false;
            this.cheque.Location = new System.Drawing.Point(42, 170);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(112, 17);
            this.cheque.TabIndex = 7;
            this.cheque.Text = "Cheque Recieved";
            this.cheque.UseVisualStyleBackColor = true;
            this.cheque.CheckedChanged += new System.EventHandler(this.Check_Changed);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Details
            // 
            this.Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Details.Enabled = false;
            this.Details.Location = new System.Drawing.Point(39, 357);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(218, 23);
            this.Details.TabIndex = 8;
            this.Details.Text = "Show Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // s_date
            // 
            this.s_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s_date.AutoSize = true;
            this.s_date.Location = new System.Drawing.Point(39, 401);
            this.s_date.Name = "s_date";
            this.s_date.Size = new System.Drawing.Size(0, 13);
            this.s_date.TabIndex = 9;
            // 
            // e_date
            // 
            this.e_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e_date.AutoSize = true;
            this.e_date.Location = new System.Drawing.Point(39, 434);
            this.e_date.Name = "e_date";
            this.e_date.Size = new System.Drawing.Size(0, 13);
            this.e_date.TabIndex = 10;
            // 
            // Start_Date
            // 
            this.Start_Date.Enabled = false;
            this.Start_Date.Location = new System.Drawing.Point(39, 236);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(218, 20);
            this.Start_Date.TabIndex = 11;
            // 
            // scheme_start
            // 
            this.scheme_start.AutoSize = true;
            this.scheme_start.Location = new System.Drawing.Point(36, 220);
            this.scheme_start.Name = "scheme_start";
            this.scheme_start.Size = new System.Drawing.Size(153, 13);
            this.scheme_start.TabIndex = 12;
            this.scheme_start.Text = "Select Scheme Starting Date : ";
            // 
            // SchemeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(306, 465);
            this.Controls.Add(this.scheme_start);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.e_date);
            this.Controls.Add(this.s_date);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.cheque);
            this.Controls.Add(this.choose_news);
            this.Controls.Add(this.cust_add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Newspaper_Chooser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 434);
            this.Name = "SchemeSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchemeSelector";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Newspaper_Chooser;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label cust_add;
        private System.Windows.Forms.Label choose_news;
        private System.Windows.Forms.CheckBox cheque;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Label e_date;
        private System.Windows.Forms.Label s_date;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Label scheme_start;
        private System.Windows.Forms.DateTimePicker Start_Date;
    }
}