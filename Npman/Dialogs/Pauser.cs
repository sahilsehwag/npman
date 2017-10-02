using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Npman.Classes;

namespace Npman.Dialogs
{
    public partial class Pauser : Form
    {
        private string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private DataGridView grid;
        private int row;
        private string news_id;
        private string cust_id;
        public Pauser(DataGridView grid, int row)
        {            
            InitializeComponent();
            this.cust_id = grid.Rows[row].Cells[0].Value.ToString();
            FillCombobox();
            address.Text += Customer.AddressString(cust_id);

            this.grid = grid;
            this.row = row;
        }



        private void FillCombobox()
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT newspapers.name AS Name FROM newspapers,news_cust
                                    WHERE newspapers.id = news_cust.news_id AND news_cust.cust_id = " + cust_id + @";";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Paper_List.Items.Add(reader["Name"]);
                    }
                }
            }
        }        
        private string GetAddress(DataGridView grid, int row, int col)
        {            
            return (grid.Rows[row].Cells["Sector/Colony"].Value.ToString()
                    + " /"
                    + grid.Rows[row].Cells["Pocket/Block"].Value.ToString()
                    + " /"
                    + grid.Rows[row].Cells["House Number"].Value.ToString());                        
        }
        private void SetValues(string name)
        {
            using (connection = new SQLiteConnection(conn_str))
            {                
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id FROM newspapers WHERE name = '" + name + @"';";

                news_id = cmd.ExecuteScalar().ToString();
                cust_id = grid.Rows[row].Cells[0].Value.ToString();
            }
        }



        private void Entered(object sender, EventArgs e)
        {
            Status.Text = "";
        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            if (Paper_List.Text == String.Empty) Status.Text = @"Please Select From The List.";            
            else
            {                                 
                string start_date = start_picker.Value.ToString().Split(' ')[0];
                string end_date = end_picker.Value.ToString().Split(' ')[0];
                
                if (start_date == end_date) 
                { 
                    Status.Text = @"Both Dates Should be different.";
                    return;
                }

                string name = Paper_List.Text;
                SetValues(name);
                using (connection = new SQLiteConnection(conn_str))
                {

                    DateTime s = start_picker.Value;
                    DateTime end = end_picker.Value;
                    start_date = Customer.DateConverter(s.Day, s.Month, s.Year);
                    end_date = Customer.DateConverter(end.Day, end.Month, end.Year);

                    connection.Open();
                    cmd = connection.CreateCommand();

                    try
                    {
                        cmd.CommandText = @"INSERT INTO inc_dec(cust_id, news_id, start_date, end_date)
                                            VALUES(" + cust_id + @", " + news_id + @", '" + start_date + "', '" + end_date + @"');";
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {
                        cmd.CommandText = @"UPDATE inc_dec
                            SET start_date = '" + start_date + @"', 
                            end_date = '" + end_date + @"';";
                        cmd.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DatePickerEntered(object sender, EventArgs e)
        {
            Status.Text = "";
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            string news_name = Paper_List.Text;
            SetValues(news_name);
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT COUNT(news_id) AS count, start_date, end_date FROM inc_dec WHERE news_id = " + news_id + @" AND cust_id = " + cust_id + @";";                
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int count = Convert.ToInt16(reader["count"]);
                        if (count == 1)
                        {                            
                            string start_date = reader["start_date"].ToString().Split(' ')[0];
                            string end_date = reader["end_date"].ToString().Split(' ')[0];

                            int day, month, year;
                            string[] str = start_date.Split('-');
                            day = Convert.ToInt32(str[0]);
                            month = Convert.ToInt32(str[1]);
                            year = Convert.ToInt32(str[2]);
                            
                            start_picker.Value = new DateTime(year, month, day);

                            string[] str1 = end_date.Split('-');
                            day = Convert.ToInt32(str1[0]);
                            month = Convert.ToInt32(str1[1]);
                            year = Convert.ToInt32(str1[2]);

                            end_picker.Value = new DateTime(year, month, day);
                        }
                        else
                        {
                            start_picker.Value = DateTime.Today;
                            end_picker.Value = DateTime.Today;
                        }
                    }
                }                
            }
        }           
    }
}
