namespace Npman
{
    partial class Settings
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
            this.NewPapers = new System.Windows.Forms.TabControl();
            this.Newspapers = new System.Windows.Forms.TabPage();
            this.Newspapers_Grid = new System.Windows.Forms.DataGridView();
            this.Newspapers_Table = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Magzines = new System.Windows.Forms.TabPage();
            this.Magzines_Grid = new System.Windows.Forms.DataGridView();
            this.Magzines_Table = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection = new System.Windows.Forms.TabPage();
            this.Schemes = new System.Windows.Forms.TabPage();
            this.Schemes_Grid = new System.Windows.Forms.DataGridView();
            this.Schemes_Table = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPapers.SuspendLayout();
            this.Newspapers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Newspapers_Grid)).BeginInit();
            this.Newspapers_Table.SuspendLayout();
            this.Magzines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Magzines_Grid)).BeginInit();
            this.Magzines_Table.SuspendLayout();
            this.Schemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schemes_Grid)).BeginInit();
            this.Schemes_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPapers
            // 
            this.NewPapers.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.NewPapers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPapers.Controls.Add(this.Newspapers);
            this.NewPapers.Controls.Add(this.Magzines);
            this.NewPapers.Controls.Add(this.Collection);
            this.NewPapers.Controls.Add(this.Schemes);
            this.NewPapers.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.NewPapers.ItemSize = new System.Drawing.Size(30, 140);
            this.NewPapers.Location = new System.Drawing.Point(2, 0);
            this.NewPapers.Multiline = true;
            this.NewPapers.Name = "NewPapers";
            this.NewPapers.Padding = new System.Drawing.Point(6, 4);
            this.NewPapers.SelectedIndex = 0;
            this.NewPapers.Size = new System.Drawing.Size(1078, 596);
            this.NewPapers.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NewPapers.TabIndex = 0;
            this.NewPapers.Click += new System.EventHandler(this.Tabs_Selected);
            // 
            // Newspapers
            // 
            this.Newspapers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Newspapers.Controls.Add(this.Newspapers_Grid);
            this.Newspapers.Location = new System.Drawing.Point(144, 4);
            this.Newspapers.Name = "Newspapers";
            this.Newspapers.Padding = new System.Windows.Forms.Padding(3);
            this.Newspapers.Size = new System.Drawing.Size(930, 588);
            this.Newspapers.TabIndex = 0;
            this.Newspapers.Text = "Newpapers";
            // 
            // Newspapers_Grid
            // 
            this.Newspapers_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Newspapers_Grid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Newspapers_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Newspapers_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Newspapers_Grid.ContextMenuStrip = this.Newspapers_Table;
            this.Newspapers_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Newspapers_Grid.Location = new System.Drawing.Point(3, 3);
            this.Newspapers_Grid.Name = "Newspapers_Grid";
            this.Newspapers_Grid.Size = new System.Drawing.Size(924, 582);
            this.Newspapers_Grid.StandardTab = true;
            this.Newspapers_Grid.TabIndex = 0;
            // 
            // Newspapers_Table
            // 
            this.Newspapers_Table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.Newspapers_Table.Name = "Settigs_Table";
            this.Newspapers_Table.Size = new System.Drawing.Size(114, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.Np_Refreshed);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Np_Save);
            // 
            // Magzines
            // 
            this.Magzines.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Magzines.Controls.Add(this.Magzines_Grid);
            this.Magzines.Location = new System.Drawing.Point(144, 4);
            this.Magzines.Name = "Magzines";
            this.Magzines.Padding = new System.Windows.Forms.Padding(3);
            this.Magzines.Size = new System.Drawing.Size(930, 588);
            this.Magzines.TabIndex = 1;
            this.Magzines.Text = "Magzines";
            // 
            // Magzines_Grid
            // 
            this.Magzines_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Magzines_Grid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Magzines_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Magzines_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Magzines_Grid.ContextMenuStrip = this.Magzines_Table;
            this.Magzines_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Magzines_Grid.Location = new System.Drawing.Point(3, 3);
            this.Magzines_Grid.Name = "Magzines_Grid";
            this.Magzines_Grid.Size = new System.Drawing.Size(924, 582);
            this.Magzines_Grid.TabIndex = 0;
            // 
            // Magzines_Table
            // 
            this.Magzines_Table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.Magzines_Table.Name = "Magzines_Table";
            this.Magzines_Table.Size = new System.Drawing.Size(114, 48);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.Mag_Refreshed);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.Mag_Save);
            // 
            // Collection
            // 
            this.Collection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Collection.Location = new System.Drawing.Point(144, 4);
            this.Collection.Name = "Collection";
            this.Collection.Size = new System.Drawing.Size(930, 588);
            this.Collection.TabIndex = 2;
            this.Collection.Text = "Collection";
            // 
            // Schemes
            // 
            this.Schemes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Schemes.Controls.Add(this.Schemes_Grid);
            this.Schemes.Location = new System.Drawing.Point(144, 4);
            this.Schemes.Name = "Schemes";
            this.Schemes.Size = new System.Drawing.Size(930, 588);
            this.Schemes.TabIndex = 3;
            this.Schemes.Text = "Schemes";
            // 
            // Schemes_Grid
            // 
            this.Schemes_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Schemes_Grid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.Schemes_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Schemes_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schemes_Grid.ContextMenuStrip = this.Schemes_Table;
            this.Schemes_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schemes_Grid.Location = new System.Drawing.Point(0, 0);
            this.Schemes_Grid.Name = "Schemes_Grid";
            this.Schemes_Grid.Size = new System.Drawing.Size(930, 588);
            this.Schemes_Grid.TabIndex = 0;
            // 
            // Schemes_Table
            // 
            this.Schemes_Table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem2,
            this.saveToolStripMenuItem2});
            this.Schemes_Table.Name = "Schemes_Table";
            this.Schemes_Table.Size = new System.Drawing.Size(114, 48);
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem2.Text = "Refresh";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.Sch_Refreshed);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.Sch_Save);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 596);
            this.Controls.Add(this.NewPapers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1096, 635);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Pressed);
            this.NewPapers.ResumeLayout(false);
            this.Newspapers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Newspapers_Grid)).EndInit();
            this.Newspapers_Table.ResumeLayout(false);
            this.Magzines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Magzines_Grid)).EndInit();
            this.Magzines_Table.ResumeLayout(false);
            this.Schemes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schemes_Grid)).EndInit();
            this.Schemes_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NewPapers;
        private System.Windows.Forms.TabPage Newspapers;
        private System.Windows.Forms.TabPage Magzines;
        private System.Windows.Forms.TabPage Collection;
        private System.Windows.Forms.TabPage Schemes;
        private System.Windows.Forms.DataGridView Magzines_Grid;
        private System.Windows.Forms.DataGridView Newspapers_Grid;
        private System.Windows.Forms.ContextMenuStrip Newspapers_Table;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView Schemes_Grid;
        private System.Windows.Forms.ContextMenuStrip Schemes_Table;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip Magzines_Table;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;


    }
}