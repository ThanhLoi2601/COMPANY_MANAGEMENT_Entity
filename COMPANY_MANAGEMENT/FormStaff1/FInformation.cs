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
    public partial class FInformation : Form
    {
        StaffDAO s = new StaffDAO();
        string ID;
        public FInformation(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.LoadMyInfo();
        }

        private void LoadMyInfo()
        {
            ExtendedStaff man = s.Search(ID);
            textID.Text = man.ID;
            textName.Text = man.Name;
            dateOfBirth.Value = (DateTime)man.Birth;
            textIDcard.Text = man.ID_Card;
            textMail.Text = man.Email;
            textPlace.Text = man.Address;
            textManID.Text = man.Manager_ID;
            textSalary.Text = man.Basic_salary.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ExtendedStaff a = new ExtendedStaff(textName.Text, dateOfBirth.Value, textIDcard.Text, textMail.Text, textPlace.Text, ID);
            s.Update(a);
        }
    }
}

