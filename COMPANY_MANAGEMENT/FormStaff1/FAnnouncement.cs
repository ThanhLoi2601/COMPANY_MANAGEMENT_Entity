using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPANY_MANAGEMENT.OOP;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FAnnouncement : Form
    {
        string ID;
        ContactDAO ct = new ContactDAO();
        public FAnnouncement(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void FAnnouncement_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dtGVAnnou.DataSource = ct.LoadListReceive(ID);
        }
        private void HighLight(DataGridView dtGV)
        {
            DateTime currentDate = DateTime.Now.Date;

            foreach (DataGridViewRow row in dtGV.Rows)
            {
                if (row.Cells["InfoDate"].Value != null && Convert.ToDateTime(row.Cells["InfoDate"].Value).Date == currentDate)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            HighLight(dtGVAnnou);
        }
    }
}