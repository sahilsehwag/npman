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
using System.Text.RegularExpressions;

namespace Npman.Dialogs
{
    public partial class SignUp : Form
    {        
        Login login_form;
        private string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        bool uflag = false;
        bool pflag = false;
        bool cpflag = false;        
        public SignUp(Login log)
        {
            InitializeComponent();
            this.login_form = log;            
        }
        

        public void SignUp_Success()
        {
            string UserName = username.Text;
            string passwd = pass.Text;
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO login(username, password) VALUES('" + UserName + @"', '" + passwd + @"');";
                cmd.ExecuteNonQuery();
            }            
            this.Close();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void Sign_Up_Clicked(object sender, EventArgs e)
        {            
            if (uflag && pflag && cpflag)
            {                
                RootPassword pass = new RootPassword(this);
                pass.Show();                      
            }
        }



        private void Username_Validating(object sender, CancelEventArgs e)
        {
            if (username.Text == "")
            {
                username_exists.ForeColor = Color.Red;
                username_exists.Text = "Please Enter Username";
                uflag = false;
            }
            else
            {
                using (connection = new SQLiteConnection(conn_str))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT COUNT(username) FROM login WHERE username = '" + username.Text + @"';";
                    string count = cmd.ExecuteScalar().ToString();

                    if (count == "1")
                    {
                        username_exists.ForeColor = Color.Red;
                        username_exists.Text = "Username already exists please select another username";
                        uflag = false;
                    }
                    else
                    {
                        username_exists.ForeColor = Color.Green;
                        username_exists.Text = "Username available";
                        uflag = true;
                    }
                }
            }
        }
        private void Password_Validating(object sender, CancelEventArgs e)
        {
            if (pass.Text == "")
            {
                pass_strength.ForeColor = Color.Red;
                pass_strength.Text = "Please Enter Password";
                pflag = false;
            }
            else
            {
                Regex strong = new Regex(@"^[a-zA-Z0-9~!@#$%^&*()_+|\.]+$");
                Regex medium = new Regex("^[a-zA-Z0-9]+$");
                Regex weak1 = new Regex("^[a-zA-Z]+$");
                Regex weak2 = new Regex("^[a-z0-9]+$");
                Regex weak3 = new Regex("^[0-9A-Z]+$");
                string password = pass.Text;
                
                if (weak1.IsMatch(password))
                {
                    pass_strength.ForeColor = Color.Red;
                    pass_strength.Text = "Password Strength : Weak";
                    pflag = true;
                }
                else if (weak2.IsMatch(password))
                {
                    pass_strength.ForeColor = Color.Red;
                    pass_strength.Text = "Password Strength : Weak";
                    pflag = true;
                }
                else if (weak3.IsMatch(password))
                {
                    pass_strength.ForeColor = Color.Red;
                    pass_strength.Text = "Password Strength : Weak";
                    pflag = true;
                }
                else if (medium.IsMatch(password))
                {
                    pass_strength.ForeColor = Color.Orange;
                    pass_strength.Text = "Password Strength : Medium";
                    pflag = true;
                }
                else if (strong.IsMatch(password))
                {
                    pass_strength.ForeColor = Color.Green;
                    pass_strength.Text = "Password Strength : Strong";
                    pflag = true;
                }
            }
        }
        private void Confirm_Password_Validating(object sender, CancelEventArgs e)
        {
            if (con_pass.Text == "")
            {
                pass_match.ForeColor = Color.Red;
                pass_match.Text = "Please Confirm Password";
                cpflag = false;
            }
            else if (con_pass.Text == pass.Text)
            {
                pass_match.ForeColor = Color.Green;
                pass_match.Text = "Password Matches";
                cpflag = true;
            }
            else
            {
                pass_match.ForeColor = Color.Red;
                pass_match.Text = "Password not matched";
                cpflag = false;
            }
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            login_form.Show();
        }


        private void Username_Entered(object sender, EventArgs e)
        {
            username_exists.Text = "";            
        }
        private void Password_Entered(object sender, EventArgs e)
        {
            pass_strength.Text = "";            
        }
        private void Confirm_Password_Entered(object sender, EventArgs e)
        {
            con_pass.Text = "";            
        }
    }
}
