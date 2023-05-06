using COMPANY_MANAGEMENT.OOP;
using System;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class FLeader : Form
    {
        string IDReceive;
        string NameReceive;
        ManagerDAO manDAO = new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        LeaderDAO ledDAO = new LeaderDAO();
        public FLeader(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FLeader()
        {
            InitializeComponent();
        }

        private void btContract_Click(object sender, EventArgs e)
        {
            FContact cont = new FContact(IDReceive, NameReceive);
            cont.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProject project = new FProject();
            project.ShowDialog();
        }

        private void btUpdateLd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
            {
                ExtendedManager man = new ExtendedManager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                manDAO.Update(man);
            }
            else
            {
                ExtendedStaff sta = new ExtendedStaff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                staDAO.Update(sta);
            }
            dgvLoad();
        }

        private void btInsertLd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
            {
                if (txtIDManager.Text != "")
                {
                    MessageBox.Show("If you add a manager, please do not fill in the text ID  !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ExtendedManager man = new ExtendedManager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Insert(man);
                }
            }
            else if(txtID.Text.Contains("EMP"))
            {
                ExtendedStaff sta = new ExtendedStaff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                staDAO.Insert(sta);
            }
            else
            {
                foreach (Control ctrl in grbInformationLd.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txtBox = (TextBox)ctrl;
                        if (string.IsNullOrEmpty(txtBox.Text))
                        {
                            MessageBox.Show("Please enter full information !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (!txtID.Text.Contains("MAN") || !txtID.Text.Contains("EMP"))
                {
                    MessageBox.Show("You must enter the correct employee ID !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvLoad();
        }

        private void btDeleteLd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    ExtendedManager man = new ExtendedManager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Delete(man);
                }
                else
                {
                    ExtendedStaff sta = new ExtendedStaff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    staDAO.Delete(sta);
                }
                dgvLoad();
            }
        }

        private void dgvListManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListManager.CurrentCell.RowIndex;
            txtIDManager.Clear();
            txtID.DataBindings.Clear();
            txtID.Text = dgvListManager.Rows[r].Cells[0].Value.ToString();
            txtNameLd.DataBindings.Clear();
            txtNameLd.Text = dgvListManager.Rows[r].Cells[1].Value.ToString();
            dtpkDateOfBirthLd.DataBindings.Clear();
            dtpkDateOfBirthLd.Text = dgvListManager.Rows[r].Cells[2].Value.ToString();
            txtIDCardLd.DataBindings.Clear();
            txtIDCardLd.Text = dgvListManager.Rows[r].Cells[3].Value.ToString();
            txtEmailLd.DataBindings.Clear();
            txtEmailLd.Text = dgvListManager.Rows[r].Cells[4].Value.ToString();
            txtAddressLd.DataBindings.Clear();
            txtAddressLd.Text = dgvListManager.Rows[r].Cells[5].Value.ToString();
            txtBasicSalaryLd.DataBindings.Clear();
            txtBasicSalaryLd.Text = dgvListManager.Rows[r].Cells[6].Value.ToString();
            txtPasswordLd.DataBindings.Clear();
            txtPasswordLd.Text = dgvListManager.Rows[r].Cells[7].Value.ToString();
            dgvListStaff.DataSource = staDAO.LoadList(txtID.Text);
        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListStaff.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dgvListStaff.Rows[r].Cells[0].Value.ToString();
            txtNameLd.DataBindings.Clear();
            txtNameLd.Text = dgvListStaff.Rows[r].Cells[1].Value.ToString();
            dtpkDateOfBirthLd.DataBindings.Clear();
            dtpkDateOfBirthLd.Text = dgvListStaff.Rows[r].Cells[2].Value.ToString();
            txtIDCardLd.DataBindings.Clear();
            txtIDCardLd.Text = dgvListStaff.Rows[r].Cells[3].Value.ToString();
            txtEmailLd.DataBindings.Clear();
            txtEmailLd.Text = dgvListStaff.Rows[r].Cells[4].Value.ToString();
            txtAddressLd.DataBindings.Clear();
            txtAddressLd.Text = dgvListStaff.Rows[r].Cells[5].Value.ToString();
            txtIDManager.DataBindings.Clear();
            txtIDManager.Text = dgvListStaff.Rows[r].Cells[6].Value.ToString();
            txtBasicSalaryLd.DataBindings.Clear();
            txtBasicSalaryLd.Text = dgvListStaff.Rows[r].Cells[7].Value.ToString();
            txtPasswordLd.DataBindings.Clear();
            txtPasswordLd.Text = dgvListStaff.Rows[r].Cells[8].Value.ToString();
            //IDReceive = dgvListStaff.Rows[r].Cells[0].Value.ToString();
        }

        private void FLeader_Load(object sender, EventArgs e)
        {
            dgvLoad();
            NameReceive = txtNameLd.Text;
        }
        private void dgvLoad()
        { 
            dgvListManager.DataSource = manDAO.LoadList();
            dgvListStaff.DataSource = staDAO.LoadList();
            LoadMyInfo();
        }
        private void LoadMyInfo()
        {
            Leader led = ledDAO.Search(IDReceive);
            txtID.Text = led.ID;
            txtNameLd.Text = led.Name;
            dtpkDateOfBirthLd.Value = (DateTime)led.Birth;
            txtIDCardLd.Text = led.ID_Card;
            txtEmailLd.Text = led.Email;
            txtAddressLd.Text = led.Address;    
            txtBasicSalaryLd.Text = led.Basic_salary.ToString();
            txtPasswordLd.Text = led.Password;
        }

        private void btMyInfor_MouseEnter(object sender, EventArgs e)
        {
            btMyInfor.BackColor = Color.Blue;
        }

        private void btMyInfor_MouseLeave(object sender, EventArgs e)
        {
            btMyInfor.BackColor = SystemColors.Control;
        }

        private void btAbsenceLetterLd_Click(object sender, EventArgs e)
        {
            FShowLetter man = new FShowLetter(IDReceive);
            man.ShowDialog();
        }

        private void btDistributionLd_Click(object sender, EventArgs e)
        {
            DistributionLD dis = new DistributionLD();
            dis.ShowDialog();
        }

        private void btMyInfor_Click(object sender, EventArgs e)
        {
            LoadMyInfo();
        }
    }
}