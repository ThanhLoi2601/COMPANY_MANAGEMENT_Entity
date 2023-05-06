using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace COMPANY_MANAGEMENT.OOP
{
    class DBConn
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);

        public DataTable LoadList(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void Executive(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("SUCCESSFUL EXECUTION !!", "ANNOUNCEMENT", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Search(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if ((Int32)cmd.ExecuteScalar() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("FAILED EXECUTION", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public ExtendedStaff FindStaff(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    string id_man = reader.GetString(6);
                    int bSalary = reader.GetInt32(7);
                    string pass = reader.GetString(8);
                    return new ExtendedStaff(id, name, birth, id_card, email, address, id_man, bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public ExtendedManager FindManager(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    int bSalary = reader.GetInt32(6);
                    string pass = reader.GetString(7);
                    return new ExtendedManager(id, name, birth, id_card, email, address, bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public ExtendedLeader FindLeader(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    int bSalary = reader.GetInt32(6);
                    string pass = reader.GetString(7);
                    return new ExtendedLeader(id, name, birth, id_card, email, address, bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public ExtendedJob FindJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    string content = reader.GetString(2);
                    DateTime datestart = reader.GetDateTime(3);
                    DateTime dateend = reader.GetDateTime(4);
                    int bonus = reader.GetInt32(5);
                    string idtask = reader.GetString(6);
                    return new ExtendedJob(id, name, content, datestart, dateend, bonus, idtask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public string FindNameTask(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    return name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public ExtendedProcJob FindProcessJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string content = reader.GetString(1);
                    double proc = reader.GetDouble(2);
                    return new ExtendedProcJob(id, content, proc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public int Merge(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                Int32 num = (Int32)cmd.ExecuteScalar();
                conn.Close();
                return (int)num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void LoadCbJobTask(string sqlStr, ComboBox cb, string column)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader[column].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExecutiveWithoutNotice(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ExtendedTask FindTask(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ExtendedTask task = new ExtendedTask();
                    task.ID = reader.GetString(0);
                    task.Task_Name = reader.GetString(1);
                    task.StartDate = reader.GetDateTime(2);
                    task.EndDate = reader.GetDateTime(3);
                    task.Task_description = reader.GetString(4);
                    task.Status = (Status)Enum.Parse(typeof(Status), reader.GetString(5));
                    task.GetStatus();
                    task.Project_ID = reader.GetString(6);
                    return task;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public string FindIDJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    return name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public double FindProJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    double pro = reader.GetInt32(2);
                    return pro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public void CalMoneyFine(string sqlStr, TextBox a)
        {
            int fine = 0;
            int moneyfine = 0;
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bonusValue = reader.IsDBNull(reader.GetOrdinal("Fine")) ? 0 : Convert.ToInt32(reader["Fine"]);
                            fine = fine + bonusValue;
                            moneyfine = 500 * fine;
                            a.Text = moneyfine.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Cal_Salary(string query, int basicSalary, TextBox txtfine, TextBox txtbonus, Label c)
        {
            try
            {
                int bonus = 0;
                int salary = 0;
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bonus = bonus + (int)reader["Bonus"];
                            }
                            salary = basicSalary + bonus - int.Parse(txtfine.Text);
                            txtbonus.Text = bonus.ToString();
                        }
                        else
                        {
                            txtbonus.Text = "0";
                            salary = basicSalary - int.Parse(txtfine.Text);
                        }
                        c.Text = salary.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public int CalculateBonus(string jobId)
        {
            int bonus = 0;
            string query = "SELECT Bonus FROM Job WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ID", jobId);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int jobBonus = reader.GetInt32(0);
                    bonus = jobBonus;
                }
                reader.Close();
            }
            return bonus;
        }

        public void LoadCheck(string query, CheckBox checkIN, CheckBox checkOUT)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bool bitValue1 = reader.GetBoolean(0);
                bool bitValue2 = reader.GetBoolean(1);
                checkIN.Checked = bitValue1;
                checkOUT.Checked = bitValue2;
            }
            conn.Close();
        }

    }
}
