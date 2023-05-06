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
    public partial class FManager : Form
    {
        string IDReceive;
        ManagerDAO manDAO =new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        public FManager(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FManager()
        {
            InitializeComponent();
        }
 
        private void btSalary_Click(object sender, EventArgs e)
        {
            FSalary f = new FSalary(IDReceive);
            f.ShowDialog();
        }

        private void btDistribution_Click(object sender, EventArgs e)
        {
            FDistribution f = new FDistribution(IDReceive);
            f.ShowDialog();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            Manager man = manDAO.Search(IDReceive);
            FLetterMain f = new FLetterMain(IDReceive,man.Name);
            f.ShowDialog();
        }

        private void btJob_Click(object sender, EventArgs e)
        {
            FJob f = new FJob(IDReceive);
            f.ShowDialog();
        }
        private void FManager_Load(object sender, EventArgs e)
        {
            this.LoadMyInfo();
            dGVBasic.DataSource = staDAO.LoadList(IDReceive);   
        }

        private void btMyInfo_Click(object sender, EventArgs e)
        {
            this.LoadMyInfo();
        }

        private void LoadMyInfo()
        {
            Manager man = manDAO.Search(IDReceive);
            txtID.Text = man.ID;
            txtName.Text = man.Name;
            dtBirth.Value = (DateTime)man.Birth;
            txtIDCard.Text = man.ID_Card;
            txtEmail.Text = man.Email;
            txtAddress.Text = man.Address;
            txtBasicSalary.Text = man.Basic_salary.ToString();
            txtPass.Text = man.Password;
        }

        private void ChangeInfo(Action<ExtendedStaff> methodChange)
        {
            ExtendedStaff sta = new ExtendedStaff(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, IDReceive, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(sta);
            dGVBasic.DataSource = staDAO.LoadList(IDReceive);
        }

        private void ChangeInfo(Action<ExtendedManager> methodChange)
        {
            ExtendedManager man = new ExtendedManager(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(man);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                ChangeInfo(manDAO.Update);
            else
                ChangeInfo(staDAO.Update);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                MessageBox.Show("You're not allowed to add management !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ChangeInfo(staDAO.Insert);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure to delete?", "REMIND",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    ChangeInfo(manDAO.Delete);
                    this.Close();
                }else
                    ChangeInfo(staDAO.Delete);
            }
        }

        private void dGVStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVBasic.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dGVBasic.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dGVBasic.Rows[r].Cells[1].Value.ToString();
            dtBirth.DataBindings.Clear();
            dtBirth.Text = dGVBasic.Rows[r].Cells[2].Value.ToString();
            txtIDCard.DataBindings.Clear();
            txtIDCard.Text = dGVBasic.Rows[r].Cells[3].Value.ToString();
            txtEmail.DataBindings.Clear();
            txtEmail.Text = dGVBasic.Rows[r].Cells[4].Value.ToString();
            txtAddress.DataBindings.Clear();
            txtAddress.Text = dGVBasic.Rows[r].Cells[5].Value.ToString();
            txtBasicSalary.DataBindings.Clear();
            txtBasicSalary.Text = dGVBasic.Rows[r].Cells[7].Value.ToString();
            txtPass.DataBindings.Clear();
            txtPass.Text = dGVBasic.Rows[r].Cells[8].Value.ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btContact_Click(object sender, EventArgs e)
        {
            ExtendedManager man = manDAO.Search(IDReceive);
            FContact f = new FContact(man.ID,man.Name);
            f.ShowDialog();
        }
    }
}
