namespace Npman
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listByPausedPapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBySchemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAddressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.Save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToAccessFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Advanced_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.Progressing = new System.Windows.Forms.ProgressBar();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.Status_Count = new System.Windows.Forms.ToolStripStatusLabel();
            this.Count = new System.Windows.Forms.ToolStripStatusLabel();
            this.Help = new System.Windows.Forms.ToolStripStatusLabel();
            this.Note = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tip = new System.Windows.Forms.ToolStripStatusLabel();
            this.Error = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Loading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.Search_Options = new System.Windows.Forms.ComboBox();
            this.GridMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMenu
            // 
            this.GridMenu.Enabled = false;
            this.GridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.GridMenu.Name = "GridMenu";
            this.GridMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.GridMenu.Size = new System.Drawing.Size(68, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Enabled = false;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // copyCellToolStripMenuItem
            // 
            this.copyCellToolStripMenuItem.Name = "copyCellToolStripMenuItem";
            this.copyCellToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainMenu
            // 
            this.MainMenu.AllowItemReorder = true;
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.listByAddressToolStripMenuItem,
            this.Load,
            this.Save1,
            this.Export_Menu,
            this.Import_Menu,
            this.Advanced_Search,
            this.aboutToolStripMenuItem1});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Size = new System.Drawing.Size(682, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBillToolStripMenuItem,
            this.Save,
            this.Settings,
            this.Exit});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(53, 20);
            this.File.Text = "File";
            // 
            // updateBillToolStripMenuItem
            // 
            this.updateBillToolStripMenuItem.Image = global::Npman.Properties.Resources.Bill;
            this.updateBillToolStripMenuItem.Name = "updateBillToolStripMenuItem";
            this.updateBillToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.updateBillToolStripMenuItem.Text = "Update Bill";
            this.updateBillToolStripMenuItem.Click += new System.EventHandler(this.UpdateBill_Clicked);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Name = "Save";
            this.Save.ShortcutKeyDisplayString = "Ctrl+S";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(179, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // Settings
            // 
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Name = "Settings";
            this.Settings.ShortcutKeyDisplayString = "Ctrl+Alt+S";
            this.Settings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.Settings.Size = new System.Drawing.Size(179, 22);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Clicked);
            this.Settings.MouseHover += new System.EventHandler(this.Settings_Hover);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeyDisplayString = "Esc";
            this.Exit.Size = new System.Drawing.Size(179, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Clicked);
            // 
            // listByAddressToolStripMenuItem
            // 
            this.listByAddressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByAddressToolStripMenuItem,
            this.toolStripSeparator1,
            this.listByPausedPapersToolStripMenuItem,
            this.listBySchemesToolStripMenuItem,
            this.listByAddressToolStripMenuItem1});
            this.listByAddressToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listByAddressToolStripMenuItem.Image")));
            this.listByAddressToolStripMenuItem.Name = "listByAddressToolStripMenuItem";
            this.listByAddressToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.listByAddressToolStripMenuItem.Text = "Edit/View";
            // 
            // sortByAddressToolStripMenuItem
            // 
            this.sortByAddressToolStripMenuItem.Image = global::Npman.Properties.Resources.SortedImage;
            this.sortByAddressToolStripMenuItem.Name = "sortByAddressToolStripMenuItem";
            this.sortByAddressToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sortByAddressToolStripMenuItem.Text = "Sort By Address";
            this.sortByAddressToolStripMenuItem.Click += new System.EventHandler(this.Sort_Add);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // listByPausedPapersToolStripMenuItem
            // 
            this.listByPausedPapersToolStripMenuItem.Name = "listByPausedPapersToolStripMenuItem";
            this.listByPausedPapersToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listByPausedPapersToolStripMenuItem.Text = "List By Paused Papers";
            this.listByPausedPapersToolStripMenuItem.Click += new System.EventHandler(this.List_By_Paused_Papers);
            // 
            // listBySchemesToolStripMenuItem
            // 
            this.listBySchemesToolStripMenuItem.Name = "listBySchemesToolStripMenuItem";
            this.listBySchemesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listBySchemesToolStripMenuItem.Text = "List By Schemes";
            this.listBySchemesToolStripMenuItem.Click += new System.EventHandler(this.List_By_Schemes);
            // 
            // listByAddressToolStripMenuItem1
            // 
            this.listByAddressToolStripMenuItem1.Name = "listByAddressToolStripMenuItem1";
            this.listByAddressToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.listByAddressToolStripMenuItem1.Text = "List By Address";
            this.listByAddressToolStripMenuItem1.Click += new System.EventHandler(this.List_By_Address);
            // 
            // Load
            // 
            this.Load.Image = ((System.Drawing.Image)(resources.GetObject("Load.Image")));
            this.Load.Name = "Load";
            this.Load.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Load.Size = new System.Drawing.Size(102, 20);
            this.Load.Text = "Load\\Reload";
            this.Load.Click += new System.EventHandler(this.Reload_Clicked);
            // 
            // Save1
            // 
            this.Save1.Image = ((System.Drawing.Image)(resources.GetObject("Save1.Image")));
            this.Save1.Name = "Save1";
            this.Save1.ShortcutKeyDisplayString = "";
            this.Save1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save1.Size = new System.Drawing.Size(59, 20);
            this.Save1.Text = "Save";
            this.Save1.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // Export_Menu
            // 
            this.Export_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exportToTextFileToolStripMenuItem,
            this.exportToExcelFileToolStripMenuItem,
            this.exportToAccessFileToolStripMenuItem,
            this.exportToPdfToolStripMenuItem});
            this.Export_Menu.Image = global::Npman.Properties.Resources.Export;
            this.Export_Menu.Name = "Export_Menu";
            this.Export_Menu.Size = new System.Drawing.Size(89, 20);
            this.Export_Menu.Text = "Export List";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::Npman.Properties.Resources.PrintImage;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+P";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.Print_Clicked);
            // 
            // exportToTextFileToolStripMenuItem
            // 
            this.exportToTextFileToolStripMenuItem.Image = global::Npman.Properties.Resources.TextFile;
            this.exportToTextFileToolStripMenuItem.Name = "exportToTextFileToolStripMenuItem";
            this.exportToTextFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportToTextFileToolStripMenuItem.Text = "Export To Text File";
            this.exportToTextFileToolStripMenuItem.Click += new System.EventHandler(this.Export_To_Text);
            // 
            // exportToExcelFileToolStripMenuItem
            // 
            this.exportToExcelFileToolStripMenuItem.Image = global::Npman.Properties.Resources.ExcelImage;
            this.exportToExcelFileToolStripMenuItem.Name = "exportToExcelFileToolStripMenuItem";
            this.exportToExcelFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportToExcelFileToolStripMenuItem.Text = "Export To Excel File";
            this.exportToExcelFileToolStripMenuItem.Click += new System.EventHandler(this.Export_To_Excel);
            // 
            // exportToAccessFileToolStripMenuItem
            // 
            this.exportToAccessFileToolStripMenuItem.Image = global::Npman.Properties.Resources.Access;
            this.exportToAccessFileToolStripMenuItem.Name = "exportToAccessFileToolStripMenuItem";
            this.exportToAccessFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportToAccessFileToolStripMenuItem.Text = "Export To Access File";
            // 
            // exportToPdfToolStripMenuItem
            // 
            this.exportToPdfToolStripMenuItem.Image = global::Npman.Properties.Resources.Pdf;
            this.exportToPdfToolStripMenuItem.Name = "exportToPdfToolStripMenuItem";
            this.exportToPdfToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportToPdfToolStripMenuItem.Text = "Export To Pdf";
            this.exportToPdfToolStripMenuItem.Click += new System.EventHandler(this.Export_To_Pdf);
            // 
            // Import_Menu
            // 
            this.Import_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromExcelToolStripMenuItem,
            this.importFromAccessToolStripMenuItem,
            this.importFromTextFileToolStripMenuItem});
            this.Import_Menu.Image = global::Npman.Properties.Resources.Imort;
            this.Import_Menu.Name = "Import_Menu";
            this.Import_Menu.Size = new System.Drawing.Size(92, 20);
            this.Import_Menu.Text = "Import List";
            // 
            // importFromExcelToolStripMenuItem
            // 
            this.importFromExcelToolStripMenuItem.Image = global::Npman.Properties.Resources.ExcelImage;
            this.importFromExcelToolStripMenuItem.Name = "importFromExcelToolStripMenuItem";
            this.importFromExcelToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.importFromExcelToolStripMenuItem.Text = "Import From Excel";
            this.importFromExcelToolStripMenuItem.Click += new System.EventHandler(this.Import_From_Excel);
            // 
            // importFromAccessToolStripMenuItem
            // 
            this.importFromAccessToolStripMenuItem.Image = global::Npman.Properties.Resources.Access;
            this.importFromAccessToolStripMenuItem.Name = "importFromAccessToolStripMenuItem";
            this.importFromAccessToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.importFromAccessToolStripMenuItem.Text = "Import From Access";
            this.importFromAccessToolStripMenuItem.Click += new System.EventHandler(this.Import_From_Access);
            // 
            // importFromTextFileToolStripMenuItem
            // 
            this.importFromTextFileToolStripMenuItem.Image = global::Npman.Properties.Resources.TextFile;
            this.importFromTextFileToolStripMenuItem.Name = "importFromTextFileToolStripMenuItem";
            this.importFromTextFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.importFromTextFileToolStripMenuItem.Text = "Import From Text File";
            this.importFromTextFileToolStripMenuItem.Click += new System.EventHandler(this.Import_From_Text);
            // 
            // Advanced_Search
            // 
            this.Advanced_Search.Image = ((System.Drawing.Image)(resources.GetObject("Advanced_Search.Image")));
            this.Advanced_Search.Name = "Advanced_Search";
            this.Advanced_Search.Size = new System.Drawing.Size(126, 20);
            this.Advanced_Search.Text = "Advanced Search";
            this.Advanced_Search.Click += new System.EventHandler(this.Advanced_Search_Clicked);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.About_Clicked);
            // 
            // Progressing
            // 
            this.Progressing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Progressing.Location = new System.Drawing.Point(1110, 568);
            this.Progressing.Name = "Progressing";
            this.Progressing.Size = new System.Drawing.Size(163, 20);
            this.Progressing.TabIndex = 6;
            this.Tool_Tip.SetToolTip(this.Progressing, "Loding/Saving");
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AllowUserToResizeRows = false;
            this.MainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.MainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.ContextMenuStrip = this.GridMenu;
            this.MainDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.MainDataGrid.Location = new System.Drawing.Point(-2, 27);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowHeadersWidth = 40;
            this.MainDataGrid.Size = new System.Drawing.Size(1275, 550);
            this.MainDataGrid.TabIndex = 0;
            this.MainDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Clicked);
            this.MainDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Doubled_Clicked);
            this.MainDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.MainDataGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserAddedRow);
            this.MainDataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.User_Deleting_Row);
            this.MainDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Pressed);
            this.MainDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // Status_Count
            // 
            this.Status_Count.Name = "Status_Count";
            this.Status_Count.Size = new System.Drawing.Size(91, 17);
            this.Status_Count.Text = "Search Results  : ";
            // 
            // Count
            // 
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(13, 17);
            this.Count.Text = "0";
            // 
            // Help
            // 
            this.Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(0, 17);
            // 
            // Note
            // 
            this.Note.ForeColor = System.Drawing.Color.Red;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(0, 17);
            // 
            // Tip
            // 
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(0, 17);
            // 
            // Error
            // 
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 17);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Count,
            this.Count,
            this.Help,
            this.Note,
            this.Tip,
            this.Error});
            this.Status.Location = new System.Drawing.Point(0, 566);
            this.Status.Name = "Status";
            this.Status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Status.Size = new System.Drawing.Size(1273, 22);
            this.Status.TabIndex = 5;
            this.Status.Text = "statusStrip1";
            // 
            // Loading
            // 
            this.Loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loading.AutoSize = true;
            this.Loading.Location = new System.Drawing.Point(1050, 580);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(0, 13);
            this.Loading.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1156, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Search_Clicked);
            // 
            // Search_Box
            // 
            this.Search_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Box.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Search_Box.Location = new System.Drawing.Point(1036, 3);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(114, 20);
            this.Search_Box.TabIndex = 9;
            this.Search_Box.Text = "Search";
            this.Search_Box.Enter += new System.EventHandler(this.Search_Box_Enter);
            this.Search_Box.Leave += new System.EventHandler(this.Search_Box_Leaved);
            // 
            // Search_Options
            // 
            this.Search_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Search_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Options.FormattingEnabled = true;
            this.Search_Options.Items.AddRange(new object[] {
            "By Name",
            "By Phone Number",
            "By Sector/Colony",
            "By Pocket/Block",
            "By House Number"});
            this.Search_Options.Location = new System.Drawing.Point(916, 3);
            this.Search_Options.Name = "Search_Options";
            this.Search_Options.Size = new System.Drawing.Size(114, 21);
            this.Search_Options.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 588);
            this.Controls.Add(this.Search_Options);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.Progressing);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1289, 627);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Npman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Clicked);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Pressed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            this.GridMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ContextMenuStrip GridMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.ToolStripMenuItem Save1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Export_Menu;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToAccessFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Import_Menu;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolTip Tool_Tip;
        private System.Windows.Forms.ToolStripMenuItem Advanced_Search;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar Progressing;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.ToolStripStatusLabel Status_Count;
        private System.Windows.Forms.ToolStripStatusLabel Count;
        private System.Windows.Forms.ToolStripStatusLabel Help;
        private System.Windows.Forms.ToolStripStatusLabel Note;
        private System.Windows.Forms.ToolStripStatusLabel Tip;
        private System.Windows.Forms.ToolStripStatusLabel Error;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.ToolStripMenuItem listByAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBillToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.ComboBox Search_Options;
        private System.Windows.Forms.ToolStripMenuItem listByPausedPapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listBySchemesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAddressToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToPdfToolStripMenuItem;
    }
}

