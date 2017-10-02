using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Caching;
using System.Windows.Forms;
using System.Data.SQLite;
using Npman.Dialogs;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using Microsoft.Office.Interop.Access;
using System.Diagnostics;
using System.Net;
using Npman.Properties;
using Npman.Classes;
using System.Drawing.Printing;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Npman
{    
    public partial class MainForm : System.Windows.Forms.Form
    {

        //PRIVATE FIELDS
        private String conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection = new SQLiteConnection("Data Source = Npman.db; Version = 3;");
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private SQLiteDataAdapter adapter;
        public System.Data.DataTable table;
        private SQLiteCommandBuilder cmdBuilder;
        private DataSet dataset = new DataSet();
        private Loading loading;
      




        //CONSTRUCTORS
        public MainForm()
        {            
            InitializeComponent();
                        
            SettingToolTipText();
            Search_Options.SelectedIndex = 0;

            
        }
        
        //CONSTRUCTORS




        //PRIVATE AND PUBLIC METHODS
        #region
//      public void CreateTables()
//        {
//            try
//            {
//                /*--Setting Up Connection With Database--*/
//                connection.Open();
//                cmd = connection.CreateCommand();

//                cmd.CommandText = @"CREATE TABLE customers(id INTEGER PRIMARY KEY, 
//                                    name TEXT, 
//                                    phone BIG INT NOT NULL, 
//                                    add1 TEXT NOT NULL, 
//                                    add2 TEXT NOT NULL, 
//                                    house TEXT NOT NULL);";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE login(username TEXT UNIQUE PRIMARY KEY, password TEXT);";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE newspapers(id INTEGER PRIMARY KEY,
//                                    name TEXT NOT NULL UNIQUE, 
//                                    mon REAL NOT NULL,
//                                    tue REAL NOT NULL, 
//                                    wed REAL NOT NULL, 
//                                    thu REAL NOT NULL, 
//                                    fri REAL NOT NULL, 
//                                    sat REAL NOT NULL, 
//                                    sun REAL NOT NULL, 
//                                    addCharges REAL NOT NULL);";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE bills(cust_id INTEGER UNIQUE,
//                                    bill INTEGER NOT NULL DEFAULT 0,
//                                    FOREIGN KEY(cust_id) REFERENCES customers(id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE magzines(id INTEGER PRIMARY KEY,
//                                    name TEXT NOT NULL UNIQUE,
//                                    rate REAL NOT NULL, 
//                                    interval INTEGER NOT NULL);";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE schemes(id INTEGER PRIMARY KEY,
//                                    news_id INTEGER UNIQUE NOT NULL, 
//                                    rate REAL NOT NULL, 
//                                    interval INTEGER NOT NULL,
//                                    FOREIGN KEY(news_id) REFERENCES newspapers(id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE news_cust(cust_id INTEGER NOT NULL
//                                    , news_id INTEGER NOT NULL
//                                    , days INTEGER NOT NULL DEFAULT 7
//                                    , FOREIGN KEY(cust_id) REFERENCES customers(id)
//                                    , FOREIGN KEY(news_id) REFERENCES newspapers(id)
//                                    , PRIMARY KEY(cust_id, news_id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE mag_cust(cust_id INTEGER NOT NULL
//                                    , mag_id INTEGER NOT NULL
//                                    , FOREIGN KEY(cust_id) REFERENCES customers(id)
//                                    , FOREIGN KEY(mag_id) REFERENCES magzines(id)
//                                    , PRIMARY KEY(cust_id, mag_id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE scheme_cust(cust_id INTEGER NOT NULL,
//                                    scheme_id INTEGER NOT NULL,
//                                    FOREIGN KEY(cust_id) REFERENCES customers(id),
//                                    FOREIGN KEY(scheme_id) REFERENCES schemes(id),
//                                    PRIMARY KEY(cust_id, scheme_id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"CREATE TABLE inc_dec(cust_id INTEGER NOT NULL,
//                                    news_id INTEGER NOT NULL,
//                                    start_date DATE NOT NULL,
//                                    end_date DATE NOT NULL,
//                                    FOREIGN KEY(cust_id) REFERENCES customers(id),
//                                    FOREIGN KEY(news_id) REFERENCES newspapers(id),
//                                    PRIMARY KEY(cust_id, news_id));";
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = @"INSERT INTO login(username, password) VALUES('root', 'toor');";
//                cmd.ExecuteNonQuery();

//                /*--Setting Up Connection With Database--*/
//            }
//            catch (SQLiteException e) {}
//            finally { connection.Close(); }
//        }
        #endregion
        private void Reload()
        {
            Progressing.Value = 0;
            Cursor = Cursors.WaitCursor;

            if(connection.State == ConnectionState.Closed) connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT id AS Id,
                                name AS Name, 
                                phone AS 'Phone Number', 
                                add1 AS 'Sector/Colony', 
                                add2 AS 'Pocket/Block', 
                                house AS 'House Number/FloorNo.' 
                                FROM customers;";


            FillTable(cmd);
            MainDataGrid.DataSource = table;

            Progressing.Value = 100;
            Cursor = Cursors.Default;

            //UPGRADING STATUS STRIP
            Count.Text = (MainDataGrid.RowCount - 1).ToString();
            Help.Text = "";
            Error.Text = "";
            Tip.Text = "";
            

            //COMMENTED OUT SECTION
            #region
//            try
//            {
//                connection.Open();                
//                cmd.CommandText = @"SELECT id AS Id, name AS Name, phone AS Phone, add1 AS 'Sector/Colony', add2 AS 'Pocket/Block', house AS 'House Number' FROM customers;";
//                reader = cmd.ExecuteReader();
                       
//                table = new DataTable();                

//                table.Columns.Add("Id");
//                table.Columns.Add("Name");
//                table.Columns.Add("Phone");
//                table.Columns.Add("Sector/Colony");
//                table.Columns.Add("Pocket/Block");
//                table.Columns.Add("House Number");
//                table.Columns.Add("Newspapers");
//                table.Columns.Add("Magzines");

//                table.Columns[6].ReadOnly = true;
//                table.Columns[7].ReadOnly = true;                

//                int i = 0;
//                while (reader.Read())
//                {
//                    DataRow row = table.NewRow();

//                    //CREATING AND INSERTING NEWSPAPER STRNIG
//                    #region

//                    string str = "";
//                    SQLiteCommand cmd1 = connection.CreateCommand();
//                    cmd1.CommandText = @"SELECT newspapers.name AS name
//                                        FROM news_cust,newspapers,customers 
//                                        WHERE news_cust.cust_id = " + reader["Id"] + @" AND news_cust.news_id = newspapers.id;";
//                    SQLiteDataReader r1 = cmd1.ExecuteReader();

//                    while (r1.Read())
//                    {
//                        if (!str.Contains(r1["name"].ToString()))
//                        {
//                            str += r1["name"].ToString();
//                            str += "+";
//                        }
//                    }
//                    if(str.Length >= 1) str = str.Remove(str.Length-1, 1);

//                    #endregion 

//                    //CREATING AND INSERTING MAGZINE STRNIG
//                    #region

//                    string mag = "";
//                    SQLiteCommand cmd2 = connection.CreateCommand();
//                    cmd2.CommandText = @"SELECT magzines.name AS name
//                                        FROM mag_cust,magzines,customers 
//                                        WHERE mag_cust.cust_id = " + reader["Id"] + @" AND mag_cust.mag_id = magzines.id;";
//                    SQLiteDataReader r2 = cmd2.ExecuteReader();

//                    while (r2.Read())
//                    {
//                        if (!mag.Contains(r1["name"].ToString()))
//                        {
//                            mag += r1["name"].ToString();
//                            mag += "+";
//                        }
//                    }
//                    if (mag.Length >= 1) mag = mag.Remove(mag.Length - 1, 1);

//                    #endregion

//                    row["Id"] = reader["Id"].ToString();
//                    row["Name"] = reader["Name"].ToString();
//                    row["Phone"] = reader["Phone"].ToString();
//                    row["Sector/Colony"] = reader["Sector/Colony"].ToString();
//                    row["Pocket/Block"] = reader["Pocket/Block"].ToString();
//                    row["House Number"] = reader["House Number"].ToString();
//                    row["Newspapers"] = str;
//                    row["Magzines"] = mag;
//                    table.Rows.Add(row);                    
//                    i++;
//                }

//                MainDataGrid.DataSource = table;
//                i++;
//            }
//            catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
//            finally { connection.Close(); }

#endregion
        }
        private new void Update()
        {
            Progressing.Value = 0;
            Cursor = Cursors.WaitCursor;

            try
            {
                adapter.SelectCommand.CommandText = @"SELECT id As Id, name AS Name,  phone AS 'Phone Number', add1 AS 'Sector/Colony', add2 AS 'Pocket/Block', house AS 'House Number/FloorNo.' FROM customers;";      
                cmdBuilder = new SQLiteCommandBuilder(adapter);                
                adapter.Update(table);
                connection.Close();
            }
            catch (NullReferenceException) { Help.Text = "Help : Please Load The List First.";  }
            catch (SQLiteException e) { Error.Text = "Error : Address Fields Cannot Be Empty."; }
            finally { Progressing.Value = 100; Cursor = Cursors.Default; }
        }       
        private void SettingToolTipText()
        {
            Save.ToolTipText = "Saves The Data(Ctrl+S)";
            Save1.ToolTipText = "Saves The Data(Ctrl+S)";
            Settings.ToolTipText = "Settings For Changing Or Updating Newspapers,Magzines,\n Schemes, Collection Date Related Settings.\n\nShortcut Key : Ctrl+Alt+S";
            Exit.ToolTipText = "Exit Application(Esc)";
            Load.ToolTipText = "Loads Or Reloads updated data";

            printToolStripMenuItem.ToolTipText = "Print data in table(Ctrl+Shift+P)";
            exportToTextFileToolStripMenuItem.ToolTipText = "Export to text file";
            exportToExcelFileToolStripMenuItem.ToolTipText = "Export to excel file";
            exportToAccessFileToolStripMenuItem.ToolTipText = "Export to access file";
            importFromAccessToolStripMenuItem.ToolTipText = "Import from access file";
            importFromExcelToolStripMenuItem.ToolTipText = "Import from excel file";
            importFromTextFileToolStripMenuItem.ToolTipText = "Import from text file";

            Advanced_Search.ToolTipText = "Advance search options";
            aboutToolStripMenuItem1.ToolTipText = "About us";

        }                     
        public void FillTable(SQLiteCommand cmd)
        {
            adapter = new SQLiteDataAdapter(cmd);
            table = new System.Data.DataTable();
            adapter.Fill(table);

            Progressing.Value = 25;
            //ADDING COLUMNS TO TABLE
            #region
            table.Columns.Add("Newspapers");
            table.Columns.Add("Magzines");
            table.Columns.Add("Paused Papers");
            table.Columns.Add("Scheme");
            table.Columns.Add("Bill");
            #endregion

            Progressing.Value = 50;                              
            //FILLING NEWSPAPERS, MAGZINES, PAUSED PAPERS, SCHEME, BILL
            #region
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if(connection.State == ConnectionState.Closed) connection.Open();
                string cust_id = table.Rows[i][0].ToString();                                                         

                table.Rows[i][6] = Customer.NewspaperString(cust_id);
                table.Rows[i][7] = Customer.MagzineString(cust_id);
                table.Rows[i][8] = Customer.PausedPaperString(cust_id);
                table.Rows[i][9] = Customer.SchemeString(cust_id);
                table.Rows[i][10] = Customer.BillString(cust_id); ;                    
            }
            #endregion            

            Progressing.Value = 75;
            //MAKING TABLE COLUMNS READ ONLY
            #region
            table.Columns[0].ReadOnly = true;
            table.Columns[6].ReadOnly = true;
            table.Columns[7].ReadOnly = true;
            table.Columns[8].ReadOnly = true;
            table.Columns[9].ReadOnly = true;
            table.Columns[10].ReadOnly = true;
            #endregion
            Progressing.Value = 100;
        }
        public bool BillUpdateChecker(bool flag, int total, ProgressBar bar)
        {
            bool news = false,
                 scheme = false,
                 mag1 = false,
                 mag2 = false,
                 mag3 = false,
                 mag4 = false,
                 news_end = false;

            int days = 1;

            //CHECKING MAGZINE BILL
            #region
                        switch (DateTime.Today.Day)
                        {
                            case 7:
                                mag1 = true;
                                break;
                            case 15:
                                mag2 = true;
                                break;
                            case 23:
                                mag3 = true;
                                break;
                            case 30:
                                mag4 = true;
                                break;
                        }
                        #endregion

            //CHECKING SCHEME BILL AND DELIEVERY BILL
            #region 
            if (DateTime.Today.Day == 1)
            {
                news_end = true;
                scheme = true;
            }
            #endregion

            //CHECKING NEWSPAPER BILL
            #region
            try
            {
                if(connection.State == ConnectionState.Closed) connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT last_date FROM date_holder";
                                    
                //GETTING REQUIRED DATES
                #region
                string[] last_date = cmd.ExecuteScalar().ToString().Split(" -:".ToCharArray());                        
                int last_day = Convert.ToInt32(last_date[0].ToString());
                int last_month = Convert.ToInt32(last_date[1].ToString());
                #endregion

                if (last_day < DateTime.Now.Day)
                {
                    news = true;
                    days = DateTime.Now.Day - last_day;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
            finally { connection.Close(); }
            #endregion

            //UPDATING STUFF
            #region
            if (news)
            {
                bar.Visible = true;
                //UPDATING CUSTOMER BILLS
                #region
                try
                {
                    connection.Open();
                    SQLiteCommand cmd1 = connection.CreateCommand();
                    SQLiteDataReader reader1;
                    cmd1.CommandText = @"SELECT id FROM customers;";
                    using (reader1 = cmd1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            string cust_id = reader1["id"].ToString();
                            Customer.BillCalculator(cust_id, news, mag1, mag2, mag3, mag4, scheme, news_end, days);
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
                finally { connection.Close(); }
                #endregion

                //UPDATING BILL AND DATES
                #region
                Customer.UpdateBill(total, bar);
                Customer.DateUpdater(news);
                return true;
                #endregion
            }
            else if (!flag) Tip.Text = "Update Successfull";
            return false;
            #endregion
        }
        private void Search() 
        {
            Progressing.Value = 10;
            try
            {
                string str = Search_Box.Text, key = "";

                //CREATING COMMAND
                #region
                //GETTING SEARCH OPTIONS TEXT
                #region
                switch (Search_Options.SelectedIndex)
                {
                    case 0:
                        key = "name";
                        break;
                    case 1:
                        key = "phone";
                        break;
                    case 2:
                        key = "add1";
                        break;
                    case 3:
                        key = "add2";
                        break;
                    case 4:
                        key = "house";
                        break;
                }
                #endregion

                cmd.CommandText = @"SELECT id AS Id,
                                    name AS Name, 
                                    phone AS 'Phone Number', 
                                    add1 AS 'Sector/Colony', 
                                    add2 AS 'Pocket/Block', 
                                    house AS 'House Number' 
                                    FROM customers WHERE " + key + " LIKE '%" + str + @"%'
                                    ORDER BY add1, add2, house;";
                //                if (Order_By.SelectedIndex == 5) cmd.CommandText = @"SELECT id AS Id,
                //                                    name AS Name, 
                //                                    phone AS 'Phone Number', 
                //                                    add1 AS 'Sector/Colony', 
                //                                    add2 AS 'Pocket/Block', 
                //                                    house AS 'House Number' 
                //                                    FROM customers, inc_dec WHERE " + key + " LIKE '%" + str + @"%'
                //                                    AND inc_dec.cust_id = customers.id
                //                                    ORDER BY add1, add2, house;";
                #endregion

                FillTable(cmd);
                MainDataGrid.DataSource = table;

                //UPGRADING STATUS STRIP
                Count.Text = (MainDataGrid.RowCount - 1).ToString();
            }
            catch (SQLiteException s) { MessageBox.Show(s.Message); Help.Text = "Help : Please Load The List First Before Searching."; }
        }
        public void SchemeUpdater()
        {            
            DateTime today = DateTime.Today.Date;
            Dictionary<string, string> schemes = new Dictionary<string, string>();
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT end_date, scheme_id, cust_id FROM scheme_cust;";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (today.ToString() == reader["end_date"].ToString())
                        {
                            schemes[reader["cust_id"].ToString()] = reader["scheme_id"].ToString();
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally { connection.Close(); }
            Customer.SchemeDeleter(schemes);
        }        
        public void PausedPaperUpdater()
        {
            DateTime today = DateTime.Today.Date;
            Dictionary<string, string> paused = new Dictionary<string, string>();

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT end_date, news_id, cust_id FROM inc_dec;";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (today.ToString() == reader["end_date"].ToString())
                        {
                            paused[reader["cust_id"].ToString()] = reader["news_id"].ToString();
                        }
                    }
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
            finally { connection.Close(); }

            Customer.PausedPaperDeleter(paused);
        }
        private void CurrentyNotAvalaible()
        {
            TipDialog tip = new TipDialog();
            tip.Text = "UnderDevelopment";
            tip.Show();
        }
        
        //PRIAVATE AND PUBLIC METHODS




                




        /*------------------------------------
         ---DataGrid Events And Methods-------
         ------------------------------------*/
        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            /*try
            {
                connection.Open();
                string id = MainDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                cmd = connection.CreateCommand();
                if (id == "")
                {
                    cmd.CommandText = @"INSERT INTO customers(name,phone,add1,add2,house) VALUES('" + MainDataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString() + @"','
                                                                            " + MainDataGrid.Rows[e.RowIndex].Cells["Phone"].Value.ToString() + @"','
                                                                            " + MainDataGrid.Rows[e.RowIndex].Cells["Sector/Colony"].Value.ToString() + @"','
                                                                            " + MainDataGrid.Rows[e.RowIndex].Cells["Pocket/Block"].Value.ToString() + @"','
                                                                            " + MainDataGrid.Rows[e.RowIndex].Cells["House Number"].Value.ToString() + @"');";
                }
                else
                {                    
                    MessageBox.Show("Are You Sure You Want to make the changes?", 
                                    "Confirm Change", 
                                    MessageBoxButtons.OKCancel, 
                                    MessageBoxIcon.Question);

                    int id1 = Convert.ToInt32(id);
                    cmd.CommandText = @"UPDATE customers SET name='" + MainDataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString() + @"',
                                                         phone='" + MainDataGrid.Rows[e.RowIndex].Cells["Phone"].Value.ToString() + @"',
                                                         add1='" + MainDataGrid.Rows[e.RowIndex].Cells["Sector/Colony"].Value.ToString() + @"',
                                                         add2='" + MainDataGrid.Rows[e.RowIndex].Cells["Pocket/Block"].Value.ToString() + @"',
                                                         house='" + MainDataGrid.Rows[e.RowIndex].Cells["House Number"].Value.ToString() + @"'
                                                         WHERE id = " + id1 + @";";
                }
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException) { }
            finally { Reload(); connection.Close(); } */
        }        
        private void UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //string cust_id = e.Row.Cells[0].ToString();
            //try
            //{
            //    connection.Open();
            //    cmd = connection.CreateCommand();
            //    cmd.CommandText = @"INSERT INTO bills_cust(cust_id) VALUES('" + cust_id + @"');";
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            //finally { connection.Close(); }
        }        
        private void User_Deleting_Row(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want to delete this record ? \n Data won't be restored once deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = e.Row;
                string cust_id = row.Cells[0].Value.ToString();
                try
                {
                    //DELETING ROWs FROM NEWS_CUST TABLE
                    #region
                    if(connection.State == ConnectionState.Closed) connection.Open();
                    try
                    {
                        cmd.CommandText = @"DELETE FROM news_cust WHERE cust_id = " + cust_id + @";";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    #endregion

                    //DELETING ROWs FROM MAG_CUST TABLE
                    #region
                    try
                    {
                        cmd.CommandText = @"DELETE FROM mag_cust WHERE cust_id = " + cust_id + @";";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    #endregion

                    //DELETING ROWs FROM SCHEME_CUST TABLE
                    #region
                    try
                    {
                        cmd.CommandText = @"DELETE FROM scheme_cust WHERE cust_id = " + cust_id + @";";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    #endregion

                    //DELETING ROWS FROM BILLS_CUST TABLE
                    #region
                    try
                    {
                        cmd.CommandText = @"DELETE FROM bills_cust WHERE cust_id = " + cust_id + @";";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    #endregion

                    //DELETING ROWS FROM INC_DEC TABLE
                    #region
                    try
                    {
                        cmd.CommandText = @"DELETE FROM inc_dec WHERE cust_id = " + cust_id + @";";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    #endregion
                }
                catch (Exception s) { MessageBox.Show(s.Message); MessageBox.Show(s.StackTrace); }
                finally { connection.Close(); }
            }
            else
            {
                //CANCELLING DELETION OPERATION
                e.Cancel = true;
            }
        }
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Key_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) this.Close();
        }
        private void Cell_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            Help.Text = "";
            if (e.ColumnIndex == 0) ;
            else if (e.ColumnIndex == 8)
            {
                Tip.Text = "Tip  : Double-Click to to pause the paper.";
            }
        }
        private void Cell_Doubled_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex < MainDataGrid.Rows.Count - 1)
                {                    
                    try
                    {
                        string cust_id = table.Rows[e.RowIndex][0].ToString();
                        int col = e.ColumnIndex;

                        if (col == 6)
                        {
                            Selector selector = new Selector("Newspapers", cust_id);
                            selector.Show();
                        }
                        else if (col == 7)
                        {
                            Selector selector = new Selector("Magzines", cust_id);
                            selector.Show();
                        }
                        else if (col == 8)
                        {
                            Pauser pauser = new Pauser(MainDataGrid, e.RowIndex);
                            pauser.Show();
                        }
                        else if (col == 9)
                        {
                            SchemeSelector selector = new SchemeSelector(cust_id);
                            selector.Show();
                        }
                        else if (col == 10)
                        {
                            ManualBillUpdater updater = new ManualBillUpdater(cust_id);
                            updater.Show();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }


        /*------------------------------------
         ---DataGrid Events And Methods-------
         ------------------------------------*/
        




        /*------------------------------------
         ---MainMenu Events And Methods-------
         ------------------------------------*/
        private void Copy_Clicked(object sender, EventArgs e)
        {
        
        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            Update();
        }
        private void Search_Clicked(object sender, EventArgs e)
        {
            Search();
        }
        private void Advanced_Search_Clicked(object sender, EventArgs e)
        {
            if (MainDataGrid.RowCount >= 1)
            {
                Search search = new Search(MainDataGrid);
                search.Show();
            }
            else Help.Text = "Help : Load The List First.";
        }
        private void Sort_Add(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT id AS Id,
                                name AS Name, 
                                phone AS 'Phone Number', 
                                add1 AS 'Sector/Colony', 
                                add2 AS 'Pocket/Block', 
                                house AS 'House Number/FloorNo.' 
                                FROM customers
                                ORDER BY add1, add2, house;";


            FillTable(cmd);
            MainDataGrid.DataSource = table;
        }
        private void Reload_Clicked(object sender, EventArgs e)
        {
            Reload();
            //Progressing.Value = 0;
        }        
        private void Import_From_Excel(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();
        }
        private void Export_To_Excel(object sender, EventArgs e)
        {
            #region
            //try
            //{
            //    Microsoft.Office.Interop.Excel.Application file = new Microsoft.Office.Interop.Excel.Application();
            //    Workbook book = file.Workbooks.Add(XlSheetType.xlWorksheet);
            //    Worksheet sheet = (Worksheet)file.ActiveSheet();
            //    file.Visible = true;

            //    //SETTING HEADERS TEXT
            //    for (int i = 0; i < MainDataGrid.Columns.Count; i++)
            //    {
            //        sheet.Cells[1, i + 1] = MainDataGrid.Columns[i].HeaderText.ToString();
            //    }

            //    //FILLING DATA
            //    for (int i = 0; i < MainDataGrid.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < MainDataGrid.Columns.Count; j++)
            //        {
            //            sheet.Cells[i + 2, j + 1] = MainDataGrid.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //}
            //catch (System.Runtime.InteropServices.COMException s) { MessageBox.Show(s.Message); MessageBox.Show("Excel Is Installed On Your Computer.", "Excel Not Insalled.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            #endregion
            CurrentyNotAvalaible();
        }
        private void UpdateBill_Clicked(object sender, EventArgs e)
        {
            loading = new Loading();
            loading.Show();
            BillUpdateChecker(false, MainDataGrid.RowCount, loading.progress_bar);
            loading.Close();
        }
        private void Settings_Clicked(object sender, EventArgs e)
        {            
            Settings settings = new Settings();
            settings.Show();
        }
        private void Exit_Clicked(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void About_Clicked(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void Import_From_Access(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();
        }
        private void Import_From_Text(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();
        }
        private void Export_To_Text(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();
        }
        private void Export_To_Pdf(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();
            return;


        }
        private void Print_Clicked(object sender, EventArgs e)
        {
            CurrentyNotAvalaible();           
        }
        private void Search_Box_Leaved(object sender, EventArgs e)
        {
            if (Search_Box.Text == "")
            {
                Search_Box.Text = "Search";
                Search_Box.ForeColor = SystemColors.ScrollBar;
            }
        }        
        private void Settings_Hover(object sender, EventArgs e)
        {

        }
        private void Search_Box_Enter(object sender, EventArgs e)
        {
            Search_Box.Text = String.Empty;
            Search_Box.ForeColor = Color.Black;
        }
        private void List_By_Paused_Papers(object sender, EventArgs e) { CurrentyNotAvalaible(); }
        private void List_By_Schemes(object sender, EventArgs e) { CurrentyNotAvalaible(); }
        private void List_By_Address(object sender, EventArgs e) { CurrentyNotAvalaible(); }


        /*------------------------------------
         ---MainMenu Events And Methods-------
         ------------------------------------*/






        /*-----------------------------------------
         ---GridContext Menu Events And Methods----
         -----------------------------------------*/
        
        




        /*-----------------------------------------
         ---GridContext Menu Events And Methods----
         -----------------------------------------*/
        
        
        
        
        //MAIN WINDOW EVENTS      
        private void FormClosing_Clicked(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void On_Form_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id AS Id,
                                name AS Name, 
                                phone AS 'Phone Number', 
                                add1 AS 'Sector/Colony', 
                                add2 AS 'Pocket/Block', 
                                house AS 'House Number' 
                                FROM customers;";
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataset);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void MainForm_Click(object sender, EventArgs e)
        {
            Tip.Text = "";
        }
    }
}
