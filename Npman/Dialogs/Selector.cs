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
using System.Windows;
using Npman.Properties;


namespace Npman.Dialogs
{
    public partial class Selector : Form
    {
        private string conn_str = "Data Source = Npman.db; Version = 3;";
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;        
        private bool news_flag;
        private string cust_id;
        public Selector(String str, string id)
        {
            InitializeComponent();
            if (str.Equals("Newspapers")) news_flag = true;
            else if(str.Equals("Magzines")) news_flag = false;
            else MessageBox.Show("Wrong Argument Value Passed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.cust_id = id;
            this.Intialize();
            if (news_flag) this.CheckBox_Selector_Newspapers();
            else CheckBox_Selector_Magzines();

            Icon = Resources.MainIcon;
        }



        private void Intialize()
        {
            using(connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                //CREATING SQLITE COMMAND
                #region
                if (news_flag) cmd.CommandText = @"SELECT id , name FROM newspapers;";
                else cmd.CommandText = @"SELECT id , name FROM magzines;";
                #endregion

                //SETTING UP CHECKBOXES AND NUMERICUPDOWN
                #region
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CheckBox box = new CheckBox();
                        box.Text = reader["name"].ToString();                        


                        if (news_flag)
                        {
                            FlowLayoutPanel f = new FlowLayoutPanel();
                            f.FlowDirection = FlowDirection.LeftToRight;


                            NumericUpDown num = new NumericUpDown();
                            num.Minimum = 1;
                            num.Maximum = 7;
                            
                            f.AutoSize = true;
                            f.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

                            f.Controls.Add(box);
                            f.Controls.Add(num);

                            flow.Controls.Add(f);
                        }
                        else
                        {
                            flow.Controls.Add(box);
                        }
                    }
                }
                #endregion

                //SETTING UP BUTTONS
                #region
                //CREATING FLOWLAYOUTPANEL
                FlowLayoutPanel flow0 = new FlowLayoutPanel();
                flow0.FlowDirection = FlowDirection.LeftToRight;
                flow0.AutoSize = true;
                flow0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                flow0.Margin = new Padding(0, 30, 0, 0);
                
                //CREATING SAVE BUTTON
                Button save = new Button();
                save.Text = "Save";
                save.Click += save_Click;
                save.Margin = new Padding(0, 0, 10, 0);

                //CREATING CANCEL BUTTON
                Button cancel = new Button();
                cancel.Text = "Cancel";
                cancel.Click += cancel_Click;
                cancel.Margin = new Padding(10, 0, 0, 0);

                //ADDING CONTROLS TO BOTH FLOWLAYOUTPANEL
                flow0.Controls.Add(save);
                flow0.Controls.Add(cancel);                
                flow.Controls.Add(flow0);
                #endregion
            }
        }
        private void CheckBox_Selector_Magzines()
        {
            using(connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                //CREATING COMMAND AND EXECUTING READER
                #region
                //CREATING COMMAND FOR GETTING SELECTED MAGZINES                                    
                cmd.CommandText = @"SELECT magzines.name AS Name
                                    FROM magzines, mag_cust, customers
                                    WHERE magzines.id = mag_cust.mag_id AND mag_cust.cust_id = customers.id 
                                    AND customers.id = " + cust_id + @";";

                //EXECUTING READER AND CHECKING THE CHECKBOXES
                using (reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        
                        foreach (Control control in flow.Controls)
                        {
                            if (control is CheckBox && control.Text.Equals(reader["Name"].ToString()))
                            {                            
                                var c = control as CheckBox;
                                c.Checked = true;
                            }
                        }
                    }
                }
                #endregion
            }            
        }
        private void CheckBox_Selector_Newspapers()
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                //CREATING COMMAND AND EXECUTING READER
                #region
                //CREATING COMMAND FOR GETTING SELECTED NEWSPAPERS              
                cmd.CommandText = @"SELECT newspapers.name AS Name,
                                    news_cust.days AS Days
                                    FROM newspapers, news_cust, customers
                                    WHERE newspapers.id = news_cust.news_id AND news_cust.cust_id = customers.id 
                                    AND customers.id = " + cust_id + @";";
                
                //EXECUTING READER AND CHECKING THE CHECKBOXES
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foreach (Control layout in flow.Controls)
                        {
                            if (layout is FlowLayoutPanel)
                            {
                                for (int i = 0; i < layout.Controls.Count; i++)
                                {
                                    var box = layout.Controls[0];
                                    var n = layout.Controls[1];
                                    if (box is CheckBox && box.Text.Equals(reader["Name"].ToString()))
                                    {
                                        var c = box as CheckBox;
                                        c.Checked = true;
                                        var nup = n as NumericUpDown;
                                        nup.Value = Convert.ToInt32(reader["Days"].ToString());
                                    }                                    
                                }
                            }                            
                        }
                    }
                }
                #endregion
            }
        }
        private void Update_Newspapers()
        {            
            foreach (Control layout in flow.Controls)
            {
                if (layout is FlowLayoutPanel)
                {
                    using(connection = new SQLiteConnection(conn_str))
                    {
                        connection.Open();
                        SQLiteCommand c = connection.CreateCommand();

                        string days = "7";
                        for (int i = layout.Controls.Count - 1; i >= 0; i--)                            
                        {
                            var control = layout.Controls[i];
                            
                            if (control is NumericUpDown)                            
                            {
                                var nup = control as NumericUpDown;
                                days = nup.Value.ToString();
                            }                            
                            else if (control is CheckBox)
                            {
                                //GETTING (newspaper id) FROM (newspapers) TABLE AND GETTING COUNT TO DETERMINE IF ITS PRESENT OR NOT.
                                #region

                                var box = control as CheckBox;
                                c.CommandText = "SELECT id FROM newspapers WHERE name = '" + box.Text + @"';";
                                string news_id = c.ExecuteScalar().ToString();

                                c.CommandText = @"SELECT COUNT(news_id) FROM news_cust WHERE cust_id = " + cust_id + @" AND news_id = " + news_id + @";";
                                int count = Convert.ToInt32(c.ExecuteScalar().ToString());

                                #endregion

                                //IF BOX IS CHECKED && COUNT == 0 THEN INSERTING INTO TABLE
                                #region
                                if (box.Checked)
                                {
                                    if (count == 0)
                                    {
                                        c.CommandText = @"INSERT INTO news_cust(cust_id, news_id, days) VALUES('" + cust_id + @"', '" + news_id + @"'," + days + @");";
                                    }
                                    else if (count == 1)
                                    {
                                        c.CommandText = @"UPDATE news_cust SET days = " + days + @" 
                                                            WHERE cust_id = " + cust_id + @" 
                                                            AND news_id = " + news_id + @";";
                                    }
                                    else if (count > 1) { MessageBox.Show("Duplications."); }
                                }
                                #endregion

                                //ELSE DELETING FROM TABLE IF COUNT == 1
                                #region
                                else
                                {
                                    if (count == 1)
                                    {
                                        c.CommandText = @"DELETE FROM news_cust WHERE cust_id = " + cust_id + @" AND news_id = " + news_id + @";";
                                    }
                                    else if (count > 1) { MessageBox.Show("Duplications."); }
                                }
                                #endregion
                                c.ExecuteNonQuery();                                                          
                            }
                        }
                    }
                }
            }
        }
        private void Update_Magzines()
        {
            foreach (Control control in flow.Controls)
            {
                if (control is CheckBox)
                {
                    using(connection = new SQLiteConnection(conn_str))
                    {
                        connection.Open();
                        SQLiteCommand c = connection.CreateCommand();

                        //GETTING (magzine id) FROM (magzines) TABLE AND GETTING COUNT TO DETERMINE IF ITS PRESENT OR NOT.
                        #region

                        var box = control as CheckBox;

                        c.CommandText = "SELECT id FROM magzines WHERE name = '" + box.Text + @"';";
                        string mag_id = c.ExecuteScalar().ToString();

                        c.CommandText = @"SELECT COUNT(mag_id) FROM mag_cust WHERE cust_id = " + cust_id + @" AND mag_id = " + mag_id + @";";
                        int count = Convert.ToInt32(c.ExecuteScalar().ToString());

                        #endregion
                        //IF BOX IS CHECKED && COUNT == 0 THEN INSERTING INTO TABLE
                        #region
                        if (box.Checked)
                        {
                            if (count == 0)
                            {
                                c.CommandText = @"INSERT INTO mag_cust(cust_id, mag_id) VALUES('" + cust_id + @"', '" + mag_id + @"');";
                            }
                            else if (count > 1) { MessageBox.Show("Duplications."); }
                        }
                        #endregion
                        //ELSE DELETING FROM TABLE IF COUNT == 1
                        #region
                        else
                        {
                            if (count == 1)
                            {
                                c.CommandText = @"DELETE FROM mag_cust WHERE cust_id = " + cust_id + @" AND mag_id = " + mag_id + @";";
                            }
                            else if (count > 1) { MessageBox.Show("Duplications."); }
                        }
                        #endregion
                        c.ExecuteNonQuery();
                    }
                }                
            }
        }


        void save_Click(object sender, EventArgs e)
        {
            if (news_flag) this.Update_Newspapers();
            else this.Update_Magzines();
            this.Close();
        }
        void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
