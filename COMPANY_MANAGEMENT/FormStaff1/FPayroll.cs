using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMPANY_MANAGEMENT.OOP;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FPayroll : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        CompleteJobDAO cj = new CompleteJobDAO();
        StaffDAO sta = new StaffDAO();
        DBConn dB = new DBConn();
        CheckDAO cd = new CheckDAO();
        string ID;
        public FPayroll(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void FPayroll_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Staff man = sta.Search(ID);
            lbKPI.Text = man.Basic_salary.ToString();
            string[] months = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "All month" };

            foreach (string month in months)
            {
                cbMonth.Items.Add(month);
            }
            cbMonth.Text = DateTime.Now.Month.ToString();
            dataCVHT.DataSource = cj.LoadList(ID, "Now");
            dtGVLate.DataSource = LoadLate(ID, cbMonth.Text);
            LoadSalary();
        }

        void LoadSalary31(string month, string IDEmp)
        {
            if (month == "All month") return;
            string query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-31'", month, IDEmp);
            Cal_Salary(query);
        }

        void LoadSalary30(string month, string IDEmp)
        {
            if (month == "All month") return;
            string query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-30'", month, IDEmp);
            Cal_Salary(query);
        }

        void LoadSalary28(string month, string IDEmp)
        {
            if (month == "All month") return;
            string query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-28'", month, IDEmp);
            Cal_Salary(query);
        }

        private DataTable LoadLate(string IDEmp, string month)
        {
            string query;
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                query = string.Format("SELECT DateCheck,TimeCheckIn FROM SQLCheck WHERE ID = '{0}' AND TimesLate = 1 ", IDEmp);
            else
                query = string.Format("SELECT DateCheck,TimeCheckIn FROM SQLCheck WHERE ID = '{0}' and MONTH(TimeCheckIn) = {1} AND MONTH(TimeCheckOut) = {1} AND TimesLate = 1", IDEmp, month);
            return dB.LoadList(query);
        }

        private void Cal_Salary(string query)
        {
            Staff man = sta.Search(ID);
            cj.CalSalary(query, man.Basic_salary.Value, txtFine, textBonus, lbSalary);
        }

        void LoadLate(string month)
        {
            if (month == "All month") return;
            cd.CalFine(month, txtFine, ID);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            textMonth.Text = cbMonth.SelectedItem.ToString();
            LoadSalary();
            dtGVLate.DataSource = LoadLate(ID, cbMonth.Text);
        }

        private void LoadSalary()
        {
            dataCVHT.DataSource = cj.LoadList(ID, cbMonth.Text);
            string selected = cbMonth.Text;
            LoadLate(selected);
            if (selected == "01" || selected == "03" || selected == "05" || selected == "07" || selected == "08"
            || selected == "10" || selected == "12")
            {
                LoadSalary31(selected, ID);
            }
            else if (selected == "04" || selected == "06" || selected == "09" || selected == "11")
            {
                LoadSalary30(selected, ID);
            }
            else
            {
                LoadSalary28(selected, ID);
            }
        }
    }
}