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
    public partial class FAbsenceLetter : Form
    {
        AbsenceLetterDAO ab = new AbsenceLetterDAO();
        StaffDAO s = new StaffDAO();
        string ID;
        string Name;
        int count = 0;
        int day = 0;

        public FAbsenceLetter(string id, string name)
        {
            InitializeComponent();
            this.ID = id;
            this.Name = name;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";

            if (rbRea1.Checked)
            {
                reason = rbRea1.Text;
            }
            else if (rbRea2.Checked)
            {
                reason = rbRea2.Text;
            }
            else if (rbRea3.Checked)
            {
                reason = rbRea3.Text;
            }
            else
            {
                reason = textReason.Text;
            }

            AbsenceLetter lt = new AbsenceLetter(textID.Text,textName.Text, reason, dateStart.Value, dateEnd.Value);
            DateTime d1 = dateStart.Value;
            int day1 = d1.Day;
            DateTime d2 = dateEnd.Value;
            int day2 = d2.Day;
            TimeSpan span = d2.Subtract(d1);
            int d = day2 - day1 + 1; 

            if (textID.Text != ID)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
            }
            else if (d<0)
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }
            else if (d > 3)
            {
                MessageBox.Show("Không được nghỉ phép quá 3 ngày");
            }
            else if (int.Parse(textNghi.Text) > 2)
            {
                MessageBox.Show("Bạn đã nghỉ quá số lần cho phép");
            }
            else
            {
                ab.UpdateAbsen(lt);
                day += d;
                count++;
                MessageBox.Show("Gửi đơn xin nghỉ thành công");
                textNghi.Text = count.ToString();
                textNgayNghi.Text = day.ToString();
            }
            textNgayNghi.Tag = day.ToString();
        }

        private void rbRea4_CheckedChanged(object sender, EventArgs e)
        {
            textReason.Visible = rbRea4.Checked;
        }

        private void FAbsenceLetter_Load(object sender, EventArgs e)
        {
            if(ID.Contains("EMP"))
                this.FormBorderStyle = FormBorderStyle.None;
            textName.Text = Name;
            textID.Text = ID;
        }
    }
}
