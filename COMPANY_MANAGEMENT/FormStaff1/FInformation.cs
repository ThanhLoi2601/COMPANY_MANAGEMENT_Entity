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
using System.IO;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FInformation : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        DBConn dB = new DBConn();
        StaffDAO sta = new StaffDAO();
        string ID;
        string imgurl = "";
        public FInformation(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.LoadMyInfo();
            this.loadImage();
        }

        private void LoadMyInfo()
        {
            Staff man = sta.Search(ID);
            textID.Text = man.ID;
            textName.Text = man.Name;
            dateOfBirth.Value = man.Birth.Value;
            textIDcard.Text = man.ID_Card;
            textMail.Text = man.Email;
            textPlace.Text = man.Address;
            textManID.Text = man.Manager_ID;
            textSalary.Text = man.Basic_salary.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ExtendedStaff a = new ExtendedStaff(textName.Text, dateOfBirth.Value, textIDcard.Text, textMail.Text, textPlace.Text, ID);
            sta.Update(a);
        }

        private void btBrow_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgurl = dialog.FileName.ToString();
                picAvatar.ImageLocation = imgurl;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            sta.saveImage(ID, imgurl);
        }

        void loadImage()
        {
            sta.loadImage(ID, picAvatar);
        }
    }
}
