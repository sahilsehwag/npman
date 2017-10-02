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
using Npman.Properties;

namespace Npman.Dialogs
{
    public partial class ManualBillUpdater : Form
    {
        private string cust_id;
        private string cust_add = "Customer Address : ";
        private string cur_bill = "Current Bill : ";
        private String conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        
        public ManualBillUpdater(string cust_id)
        {
            InitializeComponent();
            this.cust_id = cust_id;
            Cust_Add.Text = cust_add + Customer.AddressString(cust_id);
            Cur_Bill.Text = cur_bill + Customer.BillString(cust_id);
            Cust_Add1.Text = Cust_Add.Text;
            Cur_Bill1.Text = Cur_Bill.Text;

            Icon = Resources.MainIcon;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            int bill;
            if (Int32.TryParse(New_Bill.Text, out bill)) { }
            else
            {
                Error.SetError(New_Bill, "Please insert a valid value.");
                return;
            }
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                if (Customer.CustomerExists(cust_id))
                {
                    cmd.CommandText = @"UPDATE bills_cust SET bill = " + bill + @" WHERE cust_id = " + cust_id + @";";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = @"INSERT INTO bills_cust(cust_id, bill) VALUES(" + cust_id + @", " + bill + @");";
                    cmd.ExecuteNonQuery();
                }
            }
            this.Close();
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void New_Bill_Entered(object sender, EventArgs e)
        {
            Error.Clear();
        }
        private void Save_Clicked1()
        {
            int bill_temp, bill;
            if (Int32.TryParse(New_Bill1.Text, out bill_temp))
            { 
                bill = Convert.ToInt32(Customer.BillString(cust_id)); 
                bill -= bill_temp;
            }
            else
            {
                Error.SetError(New_Bill1, "Please insert a valid value.");
                return;
            }
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"UPDATE bills_cust SET bill = " + bill + @" WHERE cust_id = " + cust_id + @";";
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }

    }
}
