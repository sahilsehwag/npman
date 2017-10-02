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
    public partial class Search : Form
    {
        private DataGridView grid;
        private string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;        
        private SQLiteDataAdapter adapter;
        private System.Data.DataTable table;
        private SQLiteCommandBuilder cmdBuilder;
        public Search(DataGridView grid)
        {
            InitializeComponent();
            this.grid = grid;
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
             using(connection = new SQLiteConnection(conn_str))
             {
                 connection.Open();
                 cmd = connection.CreateCommand();

                 cmd.CommandText = @"SELECT id AS Id,
                                        name AS Name,
                                        phone AS 'Phone Number',
                                        add1 AS 'Sector/Colony',
                                        add2 AS 'Pocket/Block',
                                        house AS 'House Number'
                                        FROM customers
                                        WHERE add1 LIKE '%" + Sec.Text + @"%'
                                        AND add2 LIKE '%" + Poc.Text + @"%'
                                        AND house LIKE '%" + hn.Text + @"%';";

                 MainForm form = new MainForm();
                 form.FillTable(cmd);
                 grid.DataSource = form.table;
             }
            this.Close();
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
