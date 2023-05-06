using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    public partial class FSalary : Form
    {
        string IDReceive;
        const int bonus = 100000;
        CompleteJobDAO cmpDAO = new CompleteJobDAO();
        Manager man;
        ManagerDAO manDAO= new ManagerDAO();
        public FSalary()
        {
            InitializeComponent();
        }
        public FSalary(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
            man = manDAO.Search(IDReceive);
        }

        private void FSalary_Load(object sender, EventArgs e)
        {
            dtGVCmpTask.DataSource = cmpDAO.LoadListTask(IDReceive,"Now");
            txtLuongCB.Text = man.Basic_salary.ToString();
            txtCmpTask.Text = cmpDAO.SumTaskCmp(IDReceive, "Now");
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGVCmpTask.DataSource = cmpDAO.LoadListTask(IDReceive, cbMonth.Text);
            txtCmpTask.Text = cmpDAO.SumTaskCmp(IDReceive, cbMonth.Text);
        }

        private void txtThuong_TextChanged(object sender, EventArgs e)
        {
            txtTongLuong.Text = (int.Parse(txtLuongCB.Text) + int.Parse(txtThuong.Text)).ToString();
        }

        private void txtCmpTask_TextChanged(object sender, EventArgs e)
        {
            int taskBonus = int.Parse(txtCmpTask.Text) - 10;
            if (taskBonus > 0)
                txtThuong.Text = (taskBonus * bonus).ToString();
            else
                txtThuong.Text = "0";
        }
    }
}
