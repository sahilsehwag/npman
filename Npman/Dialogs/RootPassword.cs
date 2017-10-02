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

namespace Npman.Dialogs
{
    public partial class RootPassword : Form
    {
        SignUp sign;
        public RootPassword(SignUp sign)
        {
            InitializeComponent();
            WrongPassword.Visible = false;
            this.sign = sign;            
        }

        private void Create_Account_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Npman.db; Version = 3;"))
            {
                connection.Open();
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT password FROM login WHERE username = 'root';";
                string pass = cmd.ExecuteScalar().ToString();

                if (pass == password.Text)
                {
                    sign.SignUp_Success();
                    this.Close();
                }
                else
                {                    
                    WrongPassword.Visible = true;
                }
            }
        }

        private void Password_Entered(object sender, MouseEventArgs e)
        {
            WrongPassword.Visible = false;
        }
    }
}
