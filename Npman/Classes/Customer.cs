using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Npman.Dialogs;

namespace Npman.Classes
{
    static class Customer
    {
        static object _lock = new object();
        public static string cust_id = "";
        private static Dictionary<string, double> bills = new Dictionary<string, double>();
        private static Dictionary<string, bool> cust_exists = new Dictionary<string, bool>();
        private static string conn_str = "Data Source = Npman.db; Version = 3;";
        private static SQLiteConnection connection;
        private static SQLiteCommand cmd;
        private static SQLiteDataReader reader;

        /*
            using (connection = new SQLiteConnection(conn_str)) 
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @";";
            }
         */


        public static string BillString(string cust_id)
        {            
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT bill FROM bills_cust WHERE cust_id = " + cust_id + @";";                
                if(cmd.ExecuteScalar() != null) return cmd.ExecuteScalar().ToString();
            }
            return "";
        }
        public static string AddressString(string cust_id)
        {
            using (connection = new SQLiteConnection(conn_str)) 
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT add1, add2, house FROM customers WHERE id = " + cust_id + @";";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader["add1"] + "\\" + reader["add2"] + "\\" + reader["house"];
                    }
                }
            }
            return "";
        }
        public static string NewspaperString(string cust_id)
        {
            string news = "";
            lock(_lock)
            {
                using (connection = new SQLiteConnection(conn_str))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT name AS Name,
                                        days as Days
                                        FROM newspapers, news_cust
                                        WHERE newspapers.id = news_cust.news_id
                                        AND news_cust.cust_id = " + cust_id + @";";
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            news += reader["Name"];
                            news += "+";
                        }
                    }
                    if (news.Length > 0) news = news.Remove(news.Length - 1);
                }
                return news;
            }
        }
        public static string MagzineString(string cust_id)
        {
            string mag = "";
            using(connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT name AS Name
                                    FROM magzines, mag_cust
                                    WHERE magzines.id = mag_cust.mag_id
                                    AND mag_cust.cust_id = " + cust_id + @";";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mag += reader["Name"];
                        mag += "+";
                    }
                }
                if (mag.Length > 0) mag = mag.Remove(mag.Length - 1);
            }            

            return mag;
        }
        public static string SchemeString(string cust_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                string news_str = "";
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT newspapers.name AS Name,
                                    schemes.news_id
                                    FROM scheme_cust, schemes, newspapers
                                    WHERE scheme_cust.cust_id = " + cust_id + @"
                                    AND scheme_cust.scheme_id = schemes.id
                                    AND schemes.news_id = newspapers.id;";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        news_str += reader["Name"];
                        news_str += "+";
                    }
                    if (news_str.Length > 0) news_str = news_str.Remove(news_str.Length - 1);
                }
                return news_str;
            }           
        }
        public static string PausedPaperString(string cust_id)
        {
            string paper_str = "";

            using(connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT name AS Name
                                    FROM newspapers, inc_dec
                                    WHERE newspapers.id = inc_dec.news_id
                                    AND inc_dec.cust_id = " + cust_id + @";";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paper_str += reader["Name"];
                        paper_str += "+";
                    }
                }
                if (paper_str.Length > 0) paper_str = paper_str.Remove(paper_str.Length - 1);
            }            

            return paper_str;
        }
        public static string NewspaperName(string news_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT name FROM newspapers WHERE news_id = " + news_id + @";";
                return cmd.ExecuteScalar().ToString();
            }
        }
        public static string MagzineName(string mag_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT name FROM magzines WHERE mag_id = " + mag_id + @";";
                return cmd.ExecuteScalar().ToString();
            }
        }


                
        //ID NAME DICTIONARY
        public static Dictionary<string, string> NewspaperIdNameDictionary()
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id, name FROM newspapers;";
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list[reader["id"].ToString()] = reader["name"].ToString();
                    }
                }
            }
            return list;
        }



        //ID FINDER METHODS
        public static string NewspaperId(string name)
        {            
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id FROM newspapers WHERE name = '" + name + @"';";
                return cmd.ExecuteScalar().ToString();
            }            
        }
        public static string MagzinesId(string name)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id FROM magzines WHERE name = '" + name + @"';";
                return cmd.ExecuteScalar().ToString();
            }
        }
        public static string SchemeId(string news_id)
        {            
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT id FROM schemes
                                    WHERE news_id = " + news_id + @";";
                if (cmd.ExecuteScalar() != null) return cmd.ExecuteScalar().ToString();
                return "";
            }            
        }


        //MISCELLANOUS METHODS
        public static bool ChequeRecieved(string cust_id, string scheme_id)
        {            
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT cheque_rec 
                                    FROM scheme_cust 
                                    WHERE cust_id = " + cust_id + @"
                                    AND scheme_id = " + scheme_id + @";";
                if (cmd.ExecuteScalar() != null)
                {
                    return true;
                }
                return false;
            }            
        }
        public static string DateConverter(int day, int month, int year)
        {
            return year + "-" + month + "-" + day;
        }
        public static bool SchemeStarted(string cust_id, string scheme_id)
        {            
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT start_date FROM scheme_cust
                                    WHERE cust_id = " + cust_id + @"
                                    AND scheme_id = " + scheme_id + @";";
                if (cmd.ExecuteScalar() != null)
                {
                    string s_date = cmd.ExecuteScalar().ToString();
                    if (s_date == "") return false;
                    else return true;
                }
                return false;
            }            
        }
        public static int SchemeMonths(string scheme_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT interval FROM schemes WHERE id = " + scheme_id + @";";
                return Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
        }
        public static bool CustomerExists(string cust_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT COUNT(*) FROM bills_cust WHERE cust_id = " + cust_id + @";";
                string count = cmd.ExecuteScalar().ToString();
                if (count == "1") return true;
                else return false;
            }
        }
        public static void SetProgressBar(ProgressBar bar, int value)
        {
            for (int i = bar.Value; i <= value; i++)
            {
                bar.Value = i;
            }
        }
        public static int CustomerPercentage(int value, int total)
        {
            return (int)((value * 100) / total);            
        }
        private static bool IsPaused(string cust_id, string news_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT COUNT(*) FROM inc_dec WHERE news_id = " + news_id + @" AND cust_id = " + cust_id + @";";
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (count == 0) return false;
                else if (count == 1) return true;
            }
            return false;
        }
        private static bool OnScheme(string cust_id, string news_id) 
        {
            string scheme_id = Customer.SchemeId(news_id);
            if (scheme_id != "")
            {
                using (connection = new SQLiteConnection(conn_str))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT COUNT(*) FROM scheme_cust WHERE cust_id = " + cust_id + @" AND scheme_id = " + scheme_id + @";";
                    int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (count == 1) return true;
                    return false;
                }
            }
            return false;
        }
        public static void SchemeDeleter(Dictionary<string, string> schemes)
        {
            using(connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                foreach (var scheme in schemes)
                {
                    cmd.CommandText = @"DELETE FROM scheme_cust 
                                                WHERE cust_id = " + scheme.Key + @" 
                                                AND scheme_id = " + scheme.Value + @";";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void PausedPaperDeleter(Dictionary<string, string> paused_papers)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                foreach (var paper in paused_papers)
                {
                    cmd.CommandText = @"DELETE FROM inc_dec 
                                                WHERE cust_id = " + paper.Key + @" 
                                                AND news_id = " + paper.Value + @";";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        

        
        //BILLING RELATED METHODS
        public static double NewspaperBill(string cust_id, int days)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT news_id FROM news_cust WHERE cust_id = " + cust_id + ";";
                double bill = 0;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string news_id = reader["news_id"].ToString();
                        if (!(IsPaused(cust_id, news_id) || OnScheme(cust_id, news_id))) bill += (NewspaperCharge(news_id) * days);
                    }
                }
                return bill;
            }
        }
        public static double NewspaperMonthCharge(string news_id)
        {
            double bill = 0;
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = @"SELECT addCharges FROM newspapers WHERE id = " + news_id + @";";
                    bill = Convert.ToDouble(cmd.ExecuteScalar().ToString());
                }
                catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
                return bill;
            }
        }
        public static double MagzineBill(string cust_id, string interval)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT mag_id, magzines.interval FROM mag_cust, magzines
                                    WHERE mag_cust.cust_id = " + cust_id + @"
                                    AND magzines.id = mag_id
                                    AND magzines.interval = " + interval + ";";
                double bill = 0;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string mag_id = reader["mag_id"].ToString();
                        bill += MagzineCharge(mag_id);
                    }
                }
                return bill;
            }
        }
        public static double SchemeBill(string cust_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT scheme_id FROM scheme_cust WHERE cust_id = " + cust_id + ";";
                double bill = 0;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string scheme_id = reader["scheme_id"].ToString();
                        bill += SchemeCharge(scheme_id);
                    }
                }
                return bill;
            }
        }
        public static double NewspaperCharge(string news_id)
        {
            Dictionary<string, string> days = new Dictionary<string,string>();
            days["Monday"] = "mon";
            days["Tuesday"] = "tue";
            days["Wednesday"] = "wed";
            days["Thursday"] = "thu";
            days["Friday"] = "fri";
            days["Saturday"] = "sat";
            days["Sunday"] = "sun";

            string day = days[DateTime.Today.DayOfWeek.ToString()];
            double bill = 0;
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = @"SELECT " + day + @" FROM newspapers WHERE id = " + news_id + @";";
                    bill = Convert.ToDouble(cmd.ExecuteScalar().ToString());
                }
                catch (Exception e) { MessageBox.Show(e.Message); MessageBox.Show(e.StackTrace); }
                return bill;
            }
        }
        public static double MagzineCharge(string mag_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT rate FROM mag_cust WHERE mag_id = " + mag_id + @";";
                return Convert.ToDouble(cmd.ExecuteScalar().ToString());
            }
        }
        public static double SchemeCharge(string scheme_id)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT del_charge FROM schemes WHERE id = " + scheme_id + @";";
                return Convert.ToDouble(cmd.ExecuteScalar().ToString());
            }
        }
        public static void BillCalculator(string cust_id, 
                                            bool news, bool mag1,
                                            bool mag2, bool mag3, 
                                            bool mag4, bool scheme, bool news_end, int days)
        {
            double bill = 0;
            bool flag = false;
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                
                //GETTING OLD BILL FROM BILL_CUST TABLE IF PRESENT ELSE INSERTING INTO TABLE
                #region
                cmd.CommandText = @"SELECT COUNT(*) FROM bills_cust WHERE cust_id = " + cust_id + @";";
                double count = Convert.ToDouble(cmd.ExecuteScalar().ToString());

                if (count == 1)
                {
                    cmd.CommandText = "SELECT bill FROM bills_cust WHERE cust_id = " + cust_id + @";";
                    bill += Convert.ToDouble(cmd.ExecuteScalar().ToString());
                    flag = true;
                }
                else flag = false;
                #endregion

                //UPDATING BILL
                #region
                if (news) bill += Customer.NewspaperBill(cust_id, days);
                if (mag1) bill += Customer.MagzineBill(cust_id, "1");
                if (mag2) bill += Customer.MagzineBill(cust_id, "2");
                if (mag3) bill += Customer.MagzineBill(cust_id, "3");
                if (mag4) bill += Customer.MagzineBill(cust_id, "4");
                if (scheme) bill += Customer.SchemeBill(cust_id);
                if (news_end) bill += Customer.NewspaperMonthCharge(cust_id);
                #endregion

                //UPDTING BILL IN TABLE
                #region
                cmd.CommandText = @"UPDATE bills_cust 
                                    SET bill = " + bill + @" 
                                    WHERE cust_id = " + cust_id + @"";
                //cmd.ExecuteNonQuery();
                #endregion               

                //INSERTING INTO BILLS DICTIONARY
                #region
                bills[cust_id] = bill;
                cust_exists[cust_id] = flag;
                #endregion
            }
        }
        public static void UpdateBill(int total, ProgressBar bar)
        {
            int counter = 0;         

            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                foreach (var bill in bills)
                {
                    //loading.SetTitle(Customer.CustomerPercentage(counter, total).ToString());
                    bar.Value = Customer.CustomerPercentage(++counter, total);

                    if (cust_exists[bill.Key])
                    {
                        cmd.CommandText = @"UPDATE bills_cust SET bill = " + bill.Value + @" WHERE cust_id = " + bill.Key + @";";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = @"INSERT INTO bills_cust(cust_id, bill) VALUES(" + bill.Key + @", " + bill.Value + @");";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            bills.Clear();
        }
        public static void DateUpdater(bool news)
        {
            using (connection = new SQLiteConnection(conn_str))
            {
                connection.Open();
                cmd = connection.CreateCommand();

                if (news) 
                {
                    cmd.CommandText = @"UPDATE date_holder SET last_date = datetime('now', 'localtime') WHERE id = 1;";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
