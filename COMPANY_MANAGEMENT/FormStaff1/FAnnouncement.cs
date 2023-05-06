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
            dataGridView1.DataSource = ct.LoadListReceive(ID);
        }
    }
}
