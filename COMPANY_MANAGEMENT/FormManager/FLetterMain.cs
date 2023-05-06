using COMPANY_MANAGEMENT.FormStaff1;
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
    public partial class FLetterMain : Form
    {
        string IDReceive;
        string NameReceive;
        public FLetterMain(string ID, string Name)
        {
            InitializeComponent();
            IDReceive = ID;
            NameReceive = Name;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(rbCreate.Checked == true )
            {
                FAbsenceLetter f = new FAbsenceLetter(IDReceive, NameReceive);
                f.ShowDialog();
            }
            else
            {
                FShowLetter f = new FShowLetter(IDReceive);
                f.ShowDialog();
            }
        }
    }
}
