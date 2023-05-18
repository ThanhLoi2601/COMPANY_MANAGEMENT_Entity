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
    public partial class FChangePassWord : Form
    {
        StaffDAO s = new StaffDAO();
        string ID;

        public FChangePassWord(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void ChangePass()
        {
            Staff man = s.Search(ID);
            ExtendedStaff a = new ExtendedStaff(textMaDN.Text, textNewPass.Text);
            string currentPass = textOldPass.Text;
            string newPass = textNewPass.Text;
            string newPassConfirm = textNewPassConfirm.Text;
            string ID_DN = textMaDN.Text;

            if (textMaDN.Text != man.ID)
            {
                MessageBox.Show("Mã đăng nhập không chính xác");
            }
            else if (textOldPass.Text != man.Password)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng?");
            }
            else if (newPass != newPassConfirm)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu confirm không chính xác");
                return;
            }
            else if (newPass == currentPass)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu hiện tại");
            }
            else
            {
                s.UpdatePass(a);
                MessageBox.Show("Đối mật khẩu thành công");
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to change password?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.ChangePass();
            }
        }

        private void FChangePassWord_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Staff man = s.Search(ID);
            textMaDN.Text = man.ID;
        }
    }
}