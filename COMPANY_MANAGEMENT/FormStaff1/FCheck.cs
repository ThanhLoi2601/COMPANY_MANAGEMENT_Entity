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
    public partial class FCheck : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        DBConn dB = new DBConn();
        string ID;
        CheckDAO c = new CheckDAO();
        StaffDAO s = new StaffDAO();
        ProcessJobDAO j = new ProcessJobDAO();
        JobDAO job = new JobDAO();
        public FCheck(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void FCheck_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
            LoadCongViec();
            LoadCheckState();
        }

        private void FCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int timeslate = 0;
            Staff man = s.Search(ID);
            if (checkIN.CheckState == CheckState.Checked && checkOUT.CheckState == CheckState.Unchecked)
            {
                if (CanCheckIn())
                {
                    Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, timeslate, DateTime.Now, DateTime.Now);
                    c.InsertCheck(a);
                    MessageBox.Show("Đã cập nhật bảng chấm công thành công");
                }
                else
                {
                    timeslate++;
                    Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, timeslate, DateTime.Now, DateTime.Now);
                    c.InsertCheck(a);
                    MessageBox.Show("Đã cập nhật bảng chấm công thành công,bạn đã trễ một ngày");
                }
            }
            if (checkOUT.CheckState == CheckState.Checked && CanCheckOut())
            {
                Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, timeslate, DateTime.Now, DateTime.Now);
                c.Updatecheck(a);
                MessageBox.Show("Đã cập nhật bảng chấm công thành công");
            }
        }

        public void LoadCongViec()
        {
            job.LoadCbJob(cbDsCV, ID);
        }

        void LoadCheckState()
        {
            c.CheckLoad(ID, checkIN, checkOUT);
        }

        private void cbDsCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            textID.Text = j.SearchID(cbDsCV.Text);
            textTienDo.Text = j.SearchPro(cbDsCV.Text).ToString();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            int Process = int.Parse(textTienDo.Text);
            if (Process < 0 || Process > 100)
            {
                MessageBox.Show("Lỗi cập nhật tiến độ!!");
            }
            else if (Process == 100)
            {
                ExtendedProcJob jb = new ExtendedProcJob(textID.Text, cbDsCV.Text, int.Parse(textTienDo.Text));
                j.Detele(jb);
                UpdateCom(jb);
            }
            else
            {
                ExtendedProcJob jb = new ExtendedProcJob(cbDsCV.Text, int.Parse(textTienDo.Text));
                j.Update(jb);
                MessageBox.Show("Cập nhật tiến độ thành công");
            }
        }

        private void checkOUT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOUT.Checked && !CanCheckOut())
            {
                MessageBox.Show("Chưa tới giờ check out, vui lòng check đúng giờ");
                checkOUT.CheckState = CheckState.Unchecked;
            }
        }

        private void checkIN_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkIN.Checked)
            {
                MessageBox.Show("Bạn đã check rồi");
                checkIN.CheckState = CheckState.Checked;
            }
        }

        public bool CanCheckIn()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 0, 0);
            if (currentTime < checkoutTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanCheckOut()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 9, 0, 0);
            if (currentTime < checkoutTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void UpdateCom(ProcessJob job)
        {
            int bonus = dB.CalculateBonus(textID.Text);
            ExtendedCompJob completeJob = new ExtendedCompJob(job.IDJob, job.Content, DateTime.Today, bonus);
            CompleteJobDAO completeJobDAO = new CompleteJobDAO();
            completeJobDAO.Insert(completeJob);
            ProcessJobDAO processJobDAO = new ProcessJobDAO();
            processJobDAO.Detele(job);
            MessageBox.Show("Đã cập nhật công việc hoàn thành");
        }

        private void textTienDo_TextChanged(object sender, EventArgs e)
        {
            if (textTienDo.Text == "") return;
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("Complete", int.Parse(textTienDo.Text));
            data.Add("Unfinished", 100 - int.Parse(textTienDo.Text));

            chProc.Series.Clear();
            chProc.Series.Add("Complete");
            chProc.Series["Complete"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in data)
            {
                if (item.Value == 0) continue;
                chProc.Series["Complete"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}