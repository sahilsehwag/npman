namespace Npman.Dialogs
{
    partial class Pauser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pauser));
            this.start_picker = new System.Windows.Forms.DateTimePicker();
            this.end_picker = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.Label();
            this.paper = new System.Windows.Forms.Label();
            this.Paper_List = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_picker
            // 
            this.start_picker.Location = new System.Drawing.Point(32, 102);
            this.start_picker.Name = "start_picker";
            this.start_picker.Size = new System.Drawing.Size(200, 20);
            this.start_picker.TabIndex = 0;
            // 
            // end_picker
            // 
            this.end_picker.Location = new System.Drawing.Point(270, 102);
            this.end_picker.Name = "end_picker";
            this.end_picker.Size = new System.Drawing.Size(200, 20);
            this.end_picker.TabIndex = 1;
            this.end_picker.Enter += new System.EventHandler(this.DatePickerEntered);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(29, 23);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(107, 13);
            this.address.TabIndex = 2;
            this.address.Text = "Customer Address  :  ";
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Location = new System.Drawing.Point(29, 76);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(69, 13);
            this.start_date.TabIndex = 3;
            this.start_date.Text = "Starting Date";
            // 
            // end_date
            // 
            this.end_date.AutoSize = true;
            this.end_date.Location = new System.Drawing.Point(267, 76);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(66, 13);
            this.end_date.TabIndex = 4;
            this.end_date.Text = "Ending Date";
            // 
            // paper
            // 
            this.paper.AutoSize = true;
            this.paper.Location = new System.Drawing.Point(32, 40);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(50, 13);
            this.paper.TabIndex = 5;
            this.paper.Text = "Paper  :  ";
            // 
            // Paper_List
            // 
            this.Paper_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Paper_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paper_List.FormattingEnabled = true;
            this.Paper_List.Location = new System.Drawing.Point(88, 37);
            this.Paper_List.MaxDropDownItems = 50;
            this.Paper_List.Name = "Paper_List";
            this.Paper_List.Size = new System.Drawing.Size(121, 21);
            this.Paper_List.Sorted = true;
            this.Paper_List.TabIndex = 6;
            this.Paper_List.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            this.Paper_List.Enter += new System.EventHandler(this.Entered);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(290, 143);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(395, 143);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Clicked);
            // 
            // Pauser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(513, 211);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Paper_List);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.address);
            this.Controls.Add(this.end_picker);
            this.Controls.Add(this.start_picker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pauser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pauser";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker start_picker;
        private System.Windows.Forms.DateTimePicker end_picker;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.Label end_date;
        private System.Windows.Forms.Label paper;
        private System.Windows.Forms.ComboBox Paper_List;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}