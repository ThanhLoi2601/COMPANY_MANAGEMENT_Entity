using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace COMPANY_MANAGEMENT.OOP
{
    class ProjectDAO
    {
        DBConn dB = new DBConn();
        public void Insert(ExtendedProject pro)
        {
            string sqlStr = string.Format("INSERT INTO Projects(ID,Project_Name,StartDate,EndDate,Project_description,Project_status) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , pro.ID, pro.Project_Name, pro.StartDate.ToString(), pro.EndDate.ToString(), pro.Project_description, pro.Status);
            dB.Executive(sqlStr);
        }

        public void Delete(ExtendedProject pro)
        {
            string sqlStr = string.Format("DELETE FROM Projects WHERE ID = '{0}'", pro.ID);
            dB.Executive(sqlStr);
        }

        public void Update(ExtendedProject pro)
        {
            string sqlStr = string.Format("UPDATE Projects Set Project_Name = '{0}', Project_description = '{1}', StartDate = '{2}', EndDate = '{3}', Project_status = '{4}'  WHERE ID ='{5}'"
                , pro.Project_Name, pro.Project_description, pro.StartDate.ToString(), pro.EndDate.ToString(), pro.Status.ToString(), pro.ID);
            dB.Executive(sqlStr);
        }
        public void UpdateWithoutNotice(ExtendedProject pro)
        {
            string sqlStr = string.Format("UPDATE Projects Set Project_Name = '{0}', Project_description = '{1}', StartDate = '{2}', EndDate = '{3}', Project_status = '{4}'  WHERE ID ='{5}'"
                , pro.Project_Name, pro.Project_description, pro.StartDate.ToString(), pro.EndDate.ToString(), pro.Status.ToString(), pro.ID);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT * FROM Projects WHERE ID like 'PRO%'"));
        }
        public void AddTask(ExtendedProject pro)
        {
            pro.GetStatus();
        }
    }
}
