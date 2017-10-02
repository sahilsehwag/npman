using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npman.Properties;

namespace Npman.Dialogs
{
    public partial class Loading : Form
    {
        string title = "Upading Bill Please Wait ";
        public Loading()
        {
            InitializeComponent();
            this.Icon = Resources.MainIcon;            
        }

        public void SetTitle(string num)
        {
            this.Text = title + num + "%...";
        }
    }
}
