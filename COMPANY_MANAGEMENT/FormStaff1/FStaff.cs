using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using COMPANY_MANAGEMENT.OOP;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FStaff : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        DBConn dB = new DBConn();
        AssignedWorkDAO a = new AssignedWorkDAO();
        StaffDAO staDao = new StaffDAO();
        string ID;
        Thread th;
        int count = 0, Overdue = 0, Warning = 0, NotStarted = 0, Inprocess = 0;


        public FStaff(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btCheckInOut_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FCheck f = new FCheck(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void FStaff_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            LoadDtStaff_HightLight();
            loadImage();
        }

        private void btLetter_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            Staff sta = staDao.Search(ID);
            FAbsenceLetter f = new FAbsenceLetter(ID, sta.Name);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btPayroll_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FPayroll f = new FPayroll(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btInform_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FInformation f = new FInformation(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btChangePass_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FChangePassWord f = new FChangePassWord(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewHome()
        {
            Application.Run(new FStaff(ID));
        }

        private void btAnnounce_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FAnnouncement f = new FAnnouncement(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        void loadImage()
        {
            staDao.loadImage(ID, picAvatar);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAvatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imgurl = dialog.FileName.ToString();
                picAvatar.ImageLocation = imgurl;
            }
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            LoadDtStaff_HightLight();
        }

        private void LoadDtStaff_HightLight()
        {
            dataStaff.DataSource = a.LoadList(ID);
            count = 0; Overdue = 0; Warning = 0; NotStarted = 0; Inprocess = 0;
            foreach (DataGridViewRow row in dataStaff.Rows)
            {
                if (row.Cells["DateStart"].Value == null) break;
                DateTime rowDateStart = Convert.ToDateTime(row.Cells["DateStart"].Value).Date;
                DateTime rowDateEnd = Convert.ToDateTime(row.Cells["DateEnd"].Value).Date;
                DateTime dtNow = DateTime.Now.Date;
                if (dtNow > rowDateEnd)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    Overdue++;
                }
                else if ((rowDateEnd - dtNow).Days <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    Warning++;
                }
                else if (dtNow < rowDateStart)
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                    NotStarted++;
                }
                else Inprocess++;
                row.DefaultCellStyle.ForeColor = Color.Black;
                count++;
            }
            LoadChart();
        }
        private void LoadChart()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("Overdue", Overdue * 100 / count);
            data.Add("Warning", Warning * 100 / count);
            data.Add("NotStarted", NotStarted * 100 / count);
            data.Add("Inprocess", Inprocess * 100 / count);

            chJob.Series.Clear();
            chJob.Series.Add("Overdue");
            chJob.Series["Overdue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in data)
            {
                if (item.Value == 0) continue;
                chJob.Series["Overdue"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}