using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class DistributionDAO
    {
        DBConn dB = new DBConn();
        JobDAO jbDAO = new JobDAO();
        public void Insert(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("INSERT INTO Distribution(IDJob,IDStaff) values ('{0}','{1}')", IDjob,IDstaff);
            dB.Executive(sqlStr);
        }

        public void Delete(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("DELETE FROM Distribution WHERE IDJob = '{0}' and IDStaff = '{1}' ", IDjob, IDstaff);
            dB.Executive(sqlStr);
        }

        public DataTable LoadListJob(string IDEmp)
        {
            return dB.LoadList(string.Format("SELECT j.ID,j.Name,j.Content,j.DateStart,j.DateEnd,j.Bonus,j.IDTasks,t.Task_Name " +
                " FROM Job j, Tasks t, Distribution d WHERE j.ID NOT IN (SELECT IDJob FROM Distribution) " +
                "AND j.IDTasks = t.ID AND t.ID = d.IDJob AND d.IDStaff = '{0}'", IDEmp));
        }

        public DataTable LoadListJob(string IDTask, string IDEmp)
        {
            if (IDTask == "All tasks")
                return LoadListJob(IDEmp);
            return dB.LoadList(string.Format("SELECT j.ID,j.Name,j.Content,j.DateStart,j.DateEnd,j.Bonus,j.IDTasks,t.Task_Name " +
                " FROM Job j, Tasks t, Distribution d WHERE j.ID NOT IN (SELECT IDJob FROM Distribution) " +
                "AND j.IDTasks = t.ID AND t.ID = d.IDJob AND d.IDStaff = '{0}' AND t.ID = '{1}'", IDEmp, IDTask));
        }

        public DataTable LoadListStaff(Job jb, string IDMan)
        {
            string str = string.Format("SELECT IDStaff FROM Distribution INNER JOIN Job ON IDJob = ID " +
                 "WHERE (DateStart BETWEEN '{0}' AND '{1}')" +
                 " OR (DateEnd BETWEEN '{0}' AND '{1}')" +
                 " OR ('{0}' BETWEEN DateStart AND DateEnd)" +
                 " OR ('{1}' BETWEEN DateStart AND DateEnd)", jb.DateStart?.ToString("yyyy-MM-dd"), jb.DateEnd?.ToString("yyyy-MM-dd"));
            return dB.LoadList(string.Format("SELECT * FROM Staff WHERE (ID NOT IN (SELECT IDStaff FROM Distribution) " +
                 "OR ID NOT IN ({0}) ) AND Manager_ID = '{1}'", str, IDMan));
        }

        public DataTable LoadListDis(string IDMan)
        {
            return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.DateStart, j.DateEnd, pj.Process, j.IDTasks, t.Task_Name" +
                " FROM Distribution d, Job j, ProcessJob pj, Tasks t WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.IDTasks = t.ID and d.IDStaff IN (SELECT ID FROM Staff WHERE Manager_ID = '{0}');",IDMan));
        }

        public DataTable LoadListDisCB(string IDTask, string IDMan)
        {
            if (IDTask == "All tasks")
                return LoadListDis(IDMan);
            return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.DateStart, j.DateEnd, pj.Process, j.IDTasks" +
                " FROM Distribution d, Job j, ProcessJob pj WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.IDTasks = '{0}' and d.IDStaff IN (SELECT ID FROM Staff WHERE Manager_ID = '{1}');", IDTask,IDMan));
        }

        public DataTable LoadListDisTask(string id)
        {
            if(id == "All")
                return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.StartDate, j.EndDate, pj.Process  FROM Distribution d, Tasks j, ProcessJob pj WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob; "));
            else
                return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.StartDate, j.EndDate, pj.Process  FROM Distribution d, Tasks j, ProcessJob pj WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.Project_ID = '{0}';", id));

        }

        public DataTable LoadListTask(string id)
        {
            return dB.LoadList(string.Format("SELECT *FROM Tasks WHERE ID NOT IN (SELECT IDJob FROM Distribution) AND ID like 'TKS%' AND Project_ID = '{0}'", id));
        }
        public bool CheckAssigned(string id)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            string sql = string.Format("SELECT COUNT(*) FROM Distribution WHERE IDJob = '{0}'", id);
            SqlCommand command = new SqlCommand(sql, conn);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
                return true;
            else
                return false;
        }
    }
}
