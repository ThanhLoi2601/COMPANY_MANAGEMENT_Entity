using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class DistributionLD : Form
    {
        string proid = "";
        ProjectDAO proDAO = new ProjectDAO();
        TaskDAO tksDAO = new TaskDAO();
        ManagerDAO manDAO = new ManagerDAO();
        DistributionDAO disDAO = new DistributionDAO();
        ProcessJobDAO procDAO = new ProcessJobDAO();
        public DistributionLD()
        {
            InitializeComponent();
        }

        private void DistributionLD_Load(object sender, EventArgs e)
        {
            Load_All_DGV();
        }

        private void Load_All_DGV()
        {
            dgvProject.DataSource = proDAO.LoadList();
            dgvListManager.DataSource = manDAO.LoadList();
            dgvTask.DataSource = disDAO.LoadListTask(proid);
            dgvDistribution.DataSource = disDAO.LoadListDisTask("All");
        }

        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvProject.CurrentCell.RowIndex;
            proid = dgvProject.Rows[r].Cells[0].Value.ToString();
            dgvTask.DataSource = disDAO.LoadListTask(proid);
            dgvDistribution.DataSource = disDAO.LoadListDisTask(proid);
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvTask.CurrentCell.RowIndex;
            txtIDTask.DataBindings.Clear();
            txtIDTask.Text = dgvTask.Rows[r].Cells[0].Value.ToString();
            txtTaskName.DataBindings.Clear();
            txtTaskName.Text = dgvTask.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvListManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListManager.CurrentCell.RowIndex;
            txtIDManager.DataBindings.Clear();
            txtIDManager.Text = dgvListManager.Rows[r].Cells[0].Value.ToString();
            txtManagerName.DataBindings.Clear();
            txtManagerName.Text = dgvListManager.Rows[r].Cells[1].Value.ToString();
        }

        private void btInsertLd_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxEmpty())
            {
                MessageBox.Show("Please fill in the assignment information !!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(disDAO.CheckAssigned(txtIDTask.Text))
            {
                MessageBox.Show("Task has been assigned, please choose another task to assign !!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                disDAO.Insert(txtIDTask.Text, txtIDManager.Text);
                dgvTask.DataSource = disDAO.LoadListTask(proid);
                if (procDAO.Search(txtIDTask.Text) == null)
                {
                    ExtendedTask t = tksDAO.SearchTask(txtIDTask.Text);
                    procDAO.Insert(t);
                }
                dgvDistribution.DataSource = disDAO.LoadListDisTask(proid);
            }    
        }

        private void dgvDistribution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvDistribution.CurrentCell.RowIndex;
            Task t = tksDAO.SearchTask(dgvDistribution.Rows[r].Cells[0].Value.ToString());
            txtIDTask.Clear();
            txtIDTask.Text = t.ID;
            txtTaskName.Clear();
            txtTaskName.Text = t.Task_Name;
            Manager man = manDAO.Search(dgvDistribution.Rows[r].Cells[1].Value.ToString());
            txtIDManager.Clear();
            txtIDManager.Text = man.ID;
            txtManagerName.Clear();
            txtManagerName.Text = man.Name;
        }

        private void btDeleteLd_Click(object sender, EventArgs e)
        {
            disDAO.Delete(txtIDTask.Text, txtIDManager.Text);
            Load_All_DGV();
        }
        
        private bool CheckTextBoxEmpty()
        {
            foreach (Control control in grbListDistribution.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    return true;
                } 
            }
            return false;
        }
    }
}
