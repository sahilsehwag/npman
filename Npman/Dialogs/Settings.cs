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
using Npman.Properties;
using Npman.Classes;


namespace Npman
{
    public partial class Settings : Form
    {

        //PUBLIC FIELDS
        public SQLiteConnection connection = new SQLiteConnection("Data Source = Npman.db; Version = 3;");
        public SQLiteCommand cmd;
        public SQLiteDataReader reader;
        public SQLiteDataAdapter adapter;
        public DataTable table;
        public SQLiteCommandBuilder cmdBuilder;


        //CONSTRUCTORS
        public Settings()
        {
            InitializeComponent();
            NewPapers.DrawItem += new DrawItemEventHandler(Custom_Tab);
            this.Icon = Resources.MainIcon;
        }



        //PRIVATE METHODS
        private void Custom_Tab(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = NewPapers.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = NewPapers.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.SkyBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular, GraphicsUnit.Point);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        private void Refresh(TabControl tab)
        {            
            Refresh(tab.SelectedIndex);
        }
        private void Refresh(int index)
        {
            //TabControl tab = (TabControl)sender;
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                
                string newsp = @"SELECT id AS Id,
                                name AS Name, 
                                mon AS Monday, 
                                tue AS Tuesday,
                                wed AS Wednesday, 
                                thu AS Thursday, 
                                fri AS Friday,
                                sat AS Saturday,
                                sun AS Sunday,
                                addCharges AS AdditionalCharges
                                FROM newspapers;";
                string mag = @"SELECT id AS Id,
                                name AS Name, 
                                rate as Rate,
                                interval as Time
                                FROM magzines;";
                string sch = @"SELECT id AS Id,
                                news_id AS 'Newspaper Id',
                                rate AS Rate,
                                interval AS Interval,
                                del_charge AS 'Delievery Charge'
                                FROM schemes;";

                table = new DataTable();                

                if (index == 0)
                {
                    cmd.CommandText = newsp;                    
                    adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(table);                    
                    Newspapers_Grid.DataSource = table;
                }
                else if (index == 1)
                {
                    cmd.CommandText = mag;
                    adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(table);
                    Magzines_Grid.DataSource = table;
                }
                else if (index == 3)
                {
                    cmd.CommandText = sch;
                    adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(table);
                    
                    //CREATING COMBO BOX AND ADDING NEWSPAPER NAME
                    #region
                    DataGridViewComboBoxColumn news_names_list = new DataGridViewComboBoxColumn();
                    news_names_list.HeaderText = "Newspaper";

                    cmd.CommandText = @"SELECT name FROM newspapers;";
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            news_names_list.Items.Add(reader["name"].ToString());
                        }
                    }

                    #endregion                    

                    //ADDING NEWSPAPER COLUMN AND REMOVING ID COLUMN
                    #region
                    Dictionary<string, string> news = Customer.NewspaperIdNameDictionary();
                    
                    Schemes_Grid.DataSource = table;
                    Schemes_Grid.Columns.Add(news_names_list);
                    foreach (DataGridViewRow row in Schemes_Grid.Rows)
                    {
                        if (row.Cells[1].Value != null)
                            row.Cells[5].Value = news[row.Cells[1].Value.ToString()];
                    }

                    Schemes_Grid.Columns[5].DisplayIndex = 2;
                    Schemes_Grid.Columns.RemoveAt(1);
                    #endregion
                }
                else { }


            }
            catch (SQLiteException e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
            finally { connection.Close(); }
        }
        private new void Update()
        {
            try
            {
                cmdBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(table);
            }
            catch (Exception e) { MessageBox.Show(e.Message);  }            
        }






        //TAB EVENTS
        private void Tabs_Selected(object sender, EventArgs e)
        {
            var tab = (TabControl) sender;
            Refresh(tab.SelectedIndex);
            //if (tab.SelectedIndex == 2) { }            
        }


        




        //CONTEXTSTRIP EVENTS        
        private void Np_Save(object sender, EventArgs e)
        {
            Update();
        }
        private void Np_Refreshed(object sender, EventArgs e)
        {
            Update();
            Refresh(0);
        }

        private void Mag_Refreshed(object sender, EventArgs e)
        {
            Update();
            Refresh(1);
        }
        private void Mag_Save(object sender, EventArgs e)
        {
            Update();
        }

        private void Sch_Refreshed(object sender, EventArgs e)
        {
            Update();
            Refresh(3);
        }
        private void Sch_Save(object sender, EventArgs e)
        {
            Update();
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {

        }
        private void Key_Pressed(object sender, KeyEventArgs e)
        {
           
        }        
    }
}
