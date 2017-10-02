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
    public partial class SchemeSelector : Form
    {
        private string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private string cust_id;
        private string news_id;
        private string scheme_id;
        public SchemeSelector(string id)
        {
            InitializeComponent();
            this.cust_id = id;
            Customer.cust_id = cust_id;
            cust_add.Text = "Customer Address : " + Customer.AddressString(cust_id);
            FillingComboBox();
        }


        private void FillingComboBox()
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT newspapers.name AS Name FROM newspapers, news_cust, schemes
                                    WHERE news_cust.cust_id = " + cust_id + @" AND news_cust.news_id = newspapers.id AND schemes.news_id = newspapers.id;";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {                        
                        Newspaper_Chooser.Items.Add(reader["Name"].ToString());
                    }
                }
            }
        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                //CHECKING CONDITIONS
                #region
                if (cheque.Checked == false)
                {
                    Error.SetError(cheque, "Please Confirm that check has been recieved.");
                    return;
                }
                else if (Start.Enabled == true)
                {
                    Error.SetError(Start, "Please start the scheme.");
                    return;
                }
                else if (Stop.Enabled == false)
                {
                    cmd.CommandText = @"DELETE FROM scheme_cust WHERE scheme_id = " + scheme_id + @"
                                        AND cust_id = " + cust_id + @";";
                    cmd.ExecuteNonQuery();
                    return;
                }
                #endregion

                //GETTING SCHEME INTERVAL AND CALCULATING STARTING AND ENDING DATE
                #region

                cmd.CommandText = @"SELECT interval FROM schemes WHERE id = " + scheme_id + @";";
                int months = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                string[] dates = GetDate(months);

                #endregion

                //INSERTING INTO SCHEME_CUST
                #region
                try
                {
                    cmd.CommandText = @"INSERT INTO scheme_cust
                            (scheme_id, cust_id, cheque_rec, start_date, end_date)
                            VALUES(" + scheme_id + @", 
                            " + cust_id + @", 1,
                            '" + dates[0] + @"', '" + dates[1] + @"');";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                #endregion
                this.Close();
            }
        }


        private void Selected_News_Changed(object sender, EventArgs e)
        {            
            news_id = Customer.NewspaperId(Newspaper_Chooser.Text);
            scheme_id = Customer.SchemeId(news_id);            
            cheque.Enabled = true;

            if (Customer.ChequeRecieved(cust_id, scheme_id))
            {
                cheque.Checked = true;
                cheque.Enabled = false;
                Start_Date.Enabled = true;
                if (Customer.SchemeStarted(cust_id, scheme_id))
                {
                    Details.Enabled = true;
                    Start.Enabled = false;
                    Stop.Enabled = true;
                    Save.Enabled = false;
                    Start_Date.Enabled = false;
                }
            }
            else
            {
                cheque.Checked = false;
                Start.Enabled = false;
                Stop.Enabled = false;
                Details.Enabled = false;
                Save.Enabled = false;
                Start_Date.Enabled = false;
            }
        }
        private void Check_Changed(object sender, EventArgs e)
        {
            if (cheque.Checked == true)
            {
                Save.Enabled = true;
                cheque.Enabled = false;
                Start.Enabled = true;
                Start_Date.Enabled = true;
            }
            else
            {
                
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (Stop.Enabled == true)
            {
                Stop.Enabled = false;
                Save.Enabled = true;
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Stop.Enabled = true;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                if (Customer.ChequeRecieved(cust_id, scheme_id) && Customer.SchemeStarted(cust_id, scheme_id))
                {
                    cmd.CommandText = @"SELECT start_date, end_date FROM scheme_cust WHERE cust_id = " + cust_id + @" AND scheme_id = " + scheme_id + @";";                   
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            s_date.Text = "Starting Date : " + reader["start_date"].ToString();
                            e_date.Text = "Ending Date : " + reader["end_date"].ToString();
                        }
                    }
                }
            }
        }
        private bool Checker()
        {
            return false;
        }
        private string[] GetDate(int months)
        {
            DateTime start_date = Start_Date.Value;
            DateTime end_date = start_date.AddMonths(months);
            string starting_date = Customer.DateConverter(start_date.Day, start_date.Month, start_date.Year);
            string ending_date = Customer.DateConverter(end_date.Day, end_date.Month, end_date.Year);
            string[] dates = new string[2];
            dates[0] = starting_date;
            dates[1] = ending_date;
            return dates;
        }
    }
}
