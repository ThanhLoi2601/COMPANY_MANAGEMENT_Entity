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
    public partial class FCheck : Form
    {
        CheckDAO checkDao = new CheckDAO();
        public FCheck()
        {
            InitializeComponent();
        }

        private void FCheck_Load(object sender, EventArgs e)
        {
            dtCheckinout.DataSource = checkDao.LoadCheck();
        }
    }
}
