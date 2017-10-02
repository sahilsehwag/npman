using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
using Npman.Properties;

namespace Npman.Dialogs
{
    public partial class Splash : Form
    {
        //public static Splash splash;
        private String conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private SQLiteDataAdapter adapter;
        public System.Data.DataTable table;
        public Splash()
        {
            InitializeComponent();
            CreateTables();
        }

        private void CreateTables()
        {
            try
            {
                using (connection = new SQLiteConnection(conn_str))
                {
                    /*--Setting Up Connection With Database--*/
                    connection.Open();
                    cmd = connection.CreateCommand();

                    cmd.CommandText = @"CREATE TABLE customers(id INTEGER PRIMARY KEY, 
                                        name TEXT, 
                                        phone BIG INT, 
                                        add1 TEXT NOT NULL, 
                                        add2 TEXT NOT NULL, 
                                        house TEXT NOT NULL);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE login(username TEXT UNIQUE PRIMARY KEY, password TEXT);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE newspapers(id INTEGER PRIMARY KEY,
                                        name TEXT NOT NULL UNIQUE, 
                                        mon REAL NOT NULL,
                                        tue REAL NOT NULL, 
                                        wed REAL NOT NULL, 
                                        thu REAL NOT NULL, 
                                        fri REAL NOT NULL, 
                                        sat REAL NOT NULL, 
                                        sun REAL NOT NULL, 
                                        addCharges REAL NOT NULL);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE bills_cust(cust_id INTEGER UNIQUE PRIMARY KEY,
                                        bill INTEGER NOT NULL DEFAULT 0,
                                        FOREIGN KEY(cust_id) REFERENCES customers(id));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE magzines(id INTEGER PRIMARY KEY,
                                        name TEXT NOT NULL UNIQUE,
                                        rate REAL NOT NULL, 
                                        interval INTEGER NOT NULL);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE schemes(id INTEGER PRIMARY KEY,
                                        news_id INTEGER UNIQUE NOT NULL, 
                                        rate REAL NOT NULL, 
                                        interval INTEGER NOT NULL,
                                        del_charge REAL NOT NULL,
                                        FOREIGN KEY(news_id) REFERENCES newspapers(id));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE news_cust(cust_id INTEGER NOT NULL
                                        , news_id INTEGER NOT NULL
                                        , days INTEGER NOT NULL DEFAULT 7
                                        , FOREIGN KEY(cust_id) REFERENCES customers(id)
                                        , FOREIGN KEY(news_id) REFERENCES newspapers(id)
                                        , PRIMARY KEY(cust_id, news_id));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE mag_cust(cust_id INTEGER NOT NULL
                                        , mag_id INTEGER NOT NULL
                                        , FOREIGN KEY(cust_id) REFERENCES customers(id)
                                        , FOREIGN KEY(mag_id) REFERENCES magzines(id)
                                        , PRIMARY KEY(cust_id, mag_id));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE scheme_cust(cust_id INTEGER NOT NULL,
                                        scheme_id INTEGER NOT NULL,
                                        cheque_rec INTEGER DEFAULT 0,
                                        start_date DATE DEFAULT '',
                                        end_date DATE DEFAULT '',
                                        FOREIGN KEY(cust_id) REFERENCES customers(id),
                                        FOREIGN KEY(scheme_id) REFERENCES schemes(id),
                                        PRIMARY KEY(cust_id, scheme_id));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE inc_dec(cust_id INTEGER NOT NULL,
                                        news_id INTEGER NOT NULL,
                                        start_date DATE NOT NULL,
                                        end_date DATE NOT NULL,
                                        date_created DATETIME DEFAULT (datetime()),
                                        FOREIGN KEY(cust_id) REFERENCES customers(id),
                                        FOREIGN KEY(news_id) REFERENCES newspapers(id),
                                        PRIMARY KEY(cust_id, news_id, date_created));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE date_holder(id INTEGER PRIMARY KEY, last_date DATETIME);";
                    cmd.ExecuteNonQuery();



                    cmd.CommandText = @"INSERT INTO login(username, password) VALUES('root', 'toor');";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = @"INSERT INTO date_holder(last_date) VALUES(datetime());";
                    cmd.ExecuteNonQuery();


                    /*--Setting Up Connection With Database--*/
                }
            }
            catch (SQLiteException e) { }//{ MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }            
        }
        private int Total()
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT COUNT(*) FROM customers;";
                return Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
        }
        public void Loader()
        {
            MainForm form = new MainForm();
            try
            {
            //UPDATING BILL, PAUSED PAPERS AND SCHEMES
            #region

            form.PausedPaperUpdater();
            form.SchemeUpdater();

            if (form.BillUpdateChecker(true, Total(), loading)) { this.Close(); }
            else
            {                
                Timer2.Start();
            }
            #endregion
            }
            catch (Exception e) { MessageBox.Show(e.StackTrace); Thread.Sleep(20000); }
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Loader();
            this.Close();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
