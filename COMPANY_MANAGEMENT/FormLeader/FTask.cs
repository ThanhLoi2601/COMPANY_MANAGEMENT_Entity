using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using COMPANY_MANAGEMENT.OOP;
using Status = COMPANY_MANAGEMENT.OOP.Status;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class FTask : Form
    {
        private string id_Project;
        TaskDAO tksDao = new TaskDAO();
        public FTask(string textBoxValue)
        {
            InitializeComponent();
            this.id_Project = textBoxValue;
        }
        public FTask()
        {
            InitializeComponent();
        }

        private void FTask_Load(object sender, EventArgs e)
        {
            cbbStatus.DataSource = Enum.GetValues(typeof(Status));
            gvTask.DataSource = tksDao.LoadList(id_Project);
            txtID_Project.Text = this.id_Project; 
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ExtendedTask tks = new ExtendedTask(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem, txtID_Project.Text);
            tksDao.Update(tks);
            gvTask.DataSource = tksDao.LoadList(id_Project);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID_Project.Text == "")
            {    
                MessageBox.Show("Please select the project to which you want to add the task!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ExtendedTask tks = new ExtendedTask(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem, txtID_Project.Text);
                tksDao.Insert(tks);
                gvTask.DataSource = tksDao.LoadList(id_Project);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExtendedTask tks = new ExtendedTask(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem, txtID_Project.Text);
                tksDao.Delete(tks);
                gvTask.DataSource = tksDao.LoadList(this.id_Project);
            }    
        }

        private void gvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.gvTask.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = gvTask.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = gvTask.Rows[r].Cells[1].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = gvTask.Rows[r].Cells[2].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = gvTask.Rows[r].Cells[3].Value.ToString();
            rtxtContent.DataBindings.Clear();
            rtxtContent.Text = gvTask.Rows[r].Cells[4].Value.ToString();
            cbbStatus.DataBindings.Clear();
            cbbStatus.Text = gvTask.Rows[r].Cells[5].Value.ToString();
        }
    }
}
