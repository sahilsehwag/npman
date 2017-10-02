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

namespace Npman.Dialogs
{
    public partial class Login : Form
    {
        string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        public Login()
        {
            InitializeComponent();           

            User_Image.Visible = false;
            Pass_Image.Visible = false;
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                string username = Username.Text;
                string passwd = Password.Text;
                cmd.CommandText = "SELECT password FROM login WHERE username = '" + username + @"';";
                string password = null;
                if (cmd.ExecuteScalar() != null) password = cmd.ExecuteScalar().ToString();
                if (password != null && passwd.Equals(password))
                {                    
                    MainForm form = new MainForm();
                    form.Show();
                    this.Hide();
                }
                else
                {                    
                    err.SetError(Password, "Wrong Password");
                    err.SetIconPadding(Password, 5);
                }
            }
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SignUp_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp(this);
            signup.Show();
        }
        private void Text_Changed(object sender, EventArgs e)
        {
            
        }        
        private void Validating_username(object sender, CancelEventArgs e)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT username FROM login;";
                string username = Username.Text;
                using (reader = cmd.ExecuteReader())
                {
                    bool flag = false;
                    while (reader.Read())
                    {
                        if (reader["username"].Equals(username))
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        err.SetError(Username, "Username does not exists");
                        err.SetIconPadding(Username, 5);                        
                    }
                    else if(flag == true)
                    {
                        User_Image.Visible = true;
                    }
                }
            }

        }
        private void Username_entered(object sender, EventArgs e)
        {            
            err.Clear();
            User_Image.Visible = false;
        }
        private void Password_Entered(object sender, EventArgs e)
        {                   
            Pass_Image.Visible = false;
        }        
    }
}
