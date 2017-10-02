namespace Npman.Dialogs
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.ByName = new System.Windows.Forms.Label();
            this.BySecCol = new System.Windows.Forms.Label();
            this.ByPocBlo = new System.Windows.Forms.Label();
            this.ByHN = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Sec = new System.Windows.Forms.TextBox();
            this.Poc = new System.Windows.Forms.TextBox();
            this.hn = new System.Windows.Forms.TextBox();
            this.srch = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ByName
            // 
            this.ByName.AutoSize = true;
            this.ByName.Location = new System.Drawing.Point(18, 19);
            this.ByName.Name = "ByName";
            this.ByName.Size = new System.Drawing.Size(50, 13);
            this.ByName.TabIndex = 0;
            this.ByName.Text = "By Name";
            // 
            // BySecCol
            // 
            this.BySecCol.AutoSize = true;
            this.BySecCol.Location = new System.Drawing.Point(137, 19);
            this.BySecCol.Name = "BySecCol";
            this.BySecCol.Size = new System.Drawing.Size(93, 13);
            this.BySecCol.TabIndex = 1;
            this.BySecCol.Text = "By Sector/ Colony";
            // 
            // ByPocBlo
            // 
            this.ByPocBlo.AutoSize = true;
            this.ByPocBlo.Location = new System.Drawing.Point(257, 19);
            this.ByPocBlo.Name = "ByPocBlo";
            this.ByPocBlo.Size = new System.Drawing.Size(91, 13);
            this.ByPocBlo.TabIndex = 2;
            this.ByPocBlo.Text = "By Pocket/ Block";
            // 
            // ByHN
            // 
            this.ByHN.AutoSize = true;
            this.ByHN.Location = new System.Drawing.Point(377, 19);
            this.ByHN.Name = "ByHN";
            this.ByHN.Size = new System.Drawing.Size(93, 13);
            this.ByHN.TabIndex = 3;
            this.ByHN.Text = "By House Number";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(21, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 4;
            // 
            // Sec
            // 
            this.Sec.Location = new System.Drawing.Point(140, 46);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(100, 20);
            this.Sec.TabIndex = 5;
            // 
            // Poc
            // 
            this.Poc.Location = new System.Drawing.Point(260, 46);
            this.Poc.Name = "Poc";
            this.Poc.Size = new System.Drawing.Size(100, 20);
            this.Poc.TabIndex = 6;
            // 
            // hn
            // 
            this.hn.Location = new System.Drawing.Point(380, 46);
            this.hn.Name = "hn";
            this.hn.Size = new System.Drawing.Size(100, 20);
            this.hn.TabIndex = 7;
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(274, 84);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(100, 23);
            this.srch.TabIndex = 8;
            this.srch.Text = "Search";
            this.srch.UseVisualStyleBackColor = true;
            this.srch.Click += new System.EventHandler(this.Search_Clicked);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(380, 84);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Clicked);
            // 
            // Search
            // 
            this.AcceptButton = this.srch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(508, 132);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.hn);
            this.Controls.Add(this.Poc);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ByHN);
            this.Controls.Add(this.ByPocBlo);
            this.Controls.Add(this.BySecCol);
            this.Controls.Add(this.ByName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ByName;
        private System.Windows.Forms.Label BySecCol;
        private System.Windows.Forms.Label ByPocBlo;
        private System.Windows.Forms.Label ByHN;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Sec;
        private System.Windows.Forms.TextBox Poc;
        private System.Windows.Forms.TextBox hn;
        private System.Windows.Forms.Button srch;
        private System.Windows.Forms.Button cancel;

    }
}