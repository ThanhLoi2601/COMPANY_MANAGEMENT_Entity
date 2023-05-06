using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = COMPANY_MANAGEMENT.OOP.ExtendedTask;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class FProject : Form
    {
        ProjectDAO proDao = new ProjectDAO();
        TaskDAO taskDao = new TaskDAO();
        DBConn dB = new DBConn();
        private string proID = "";
        public FProject()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            string sql = "SELECT * FROM Projects WHERE ID like 'PRO%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ExtendedProject project = new ExtendedProject();
                project.ID = reader.GetString(0);
                project.Project_Name = reader.GetString(1);
                project.StartDate = reader.GetDateTime(2);
                project.EndDate = reader.GetDateTime(3);
                project.Project_description = reader.GetString(4);
                project.Status = (Status)Enum.Parse(typeof(Status), reader.GetString(5));
                project.Tasks = (ICollection<Task>)project.GetListTasks(project.ID);
                project.Status = project.GetStatus();
                proDao.UpdateWithoutNotice(project);
            }

        }
        private void FProject_Load(object sender, EventArgs e)
        {
            cbbStatus.DataSource = Enum.GetValues(typeof(Status));
            ExtendedProject pro = new ExtendedProject(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem);
            dgvLoad(pro.ID);
        }
        private void btUpdateProject_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Contains("PRO"))
            {
                ExtendedProject pro = new ExtendedProject(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem);
                proDao.Update(pro);
            }
            else
            {
                string sqlStr = string.Format("UPDATE Tasks SET Task_Name = '{0}',StartDate = '{1}',EndDate = '{2}',Task_description = '{3}',Task_status = '{4}' WHERE ID = '{5}'", txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem, txtID.Text);
                dB.Executive(sqlStr);
            }
            dgvLoad(proID);
        }

        private void btInsertProject_Click(object sender, EventArgs e)
        {
            ExtendedProject pro = new ExtendedProject(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem);
            proDao.Insert(pro);
            dgvLoad(pro.ID);
        }

        private void btDeleteProject_Click(object sender, EventArgs e)
        {
            ExtendedProject pro = new ExtendedProject(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Status)cbbStatus.SelectedItem);
            proDao.Delete(pro);
            dgvLoad(pro.ID);
        }
        private void btTask_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("TKS"))
            {
                MessageBox.Show("Select the project you want to add the task  !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FTask ftask = new FTask(txtID.Text);
                ftask.ShowDialog();
            }
        }

        private void dgvProject_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvProject.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dgvProject.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dgvProject.Rows[r].Cells[1].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = dgvProject.Rows[r].Cells[2].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = dgvProject.Rows[r].Cells[3].Value.ToString();
            rtxtContent.DataBindings.Clear();
            rtxtContent.Text = dgvProject.Rows[r].Cells[4].Value.ToString();
            cbbStatus.DataBindings.Clear();
            cbbStatus.Text = dgvProject.Rows[r].Cells[5].Value.ToString();
            this.proID = dgvProject.Rows[r].Cells[0].Value.ToString();
            dgvTask.DataSource = taskDao.LoadList(this.proID);
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvTask.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dgvTask.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dgvTask.Rows[r].Cells[1].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = dgvTask.Rows[r].Cells[2].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = dgvTask.Rows[r].Cells[3].Value.ToString();
            rtxtContent.DataBindings.Clear();
            rtxtContent.Text = dgvTask.Rows[r].Cells[4].Value.ToString();
            cbbStatus.DataBindings.Clear();
            cbbStatus.Text = dgvTask.Rows[r].Cells[5].Value.ToString();
        }
        private void dgvLoad(string proid)
        {
            dgvProject.DataSource = proDao.LoadList();
            dgvTask.DataSource = taskDao.LoadList(proid);
        }
    }
}
