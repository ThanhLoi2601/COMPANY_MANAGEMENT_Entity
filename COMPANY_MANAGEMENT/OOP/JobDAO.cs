using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class JobDAO
    {
        DBConn dB = new DBConn();

        public void Insert(Job job)
        {
            string sqlStr = string.Format("INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , job.ID, job.Name, job.Content, job.DateStart.Value.ToString("yyyy-MM-dd"), job.DateEnd.Value.ToString("yyyy-MM-dd"), job.Bonus.ToString(), job.IDTasks);
            dB.Executive(sqlStr);
        }

        public void Delete(Job job)
        {
            string sqlStr = string.Format("DELETE FROM Job WHERE ID = '{0}'", job.ID);
            dB.Executive(sqlStr);
        }

        public void Update(Job job)
        {
            string sqlStr = string.Format("UPDATE Job Set Name = '{0}', Content = '{1}', DateStart = '{2}', DateEnd = '{3}', Bonus = {4}, IDTasks= '{5}' WHERE ID ='{6}'"
                , job.Name, job.Content, job.DateStart.Value.ToString("yyyy-MM-dd"), job.DateEnd.Value.ToString("yyyy-MM-dd"), job.Bonus, job.IDTasks, job.ID);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string ID)
        {
            return dB.LoadList(string.Format("SELECT *FROM Job WHERE IDTasks IN (SELECT IDJob FROM Distribution WHERE IDStaff = '{0}')", ID));
        }

        public Job Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Job WHERE ID = '{0}';", id);
            return dB.FindJob(sqlStr);
        }

        public void LoadCbTaskJob(ComboBox cb, string IDEmp)// SELECT DISTINCT j.IDTasks FROM Job j INNER JOIN Distribution d ON j.IDTask = d.IDJob
        {
            string sqlStr = string.Format("SELECT DISTINCT IDTasks FROM Job j, Tasks t, Distribution d WHERE j.ID NOT IN (SELECT IDJob FROM Distribution) " +
                "AND j.IDTasks = t.ID AND t.ID = d.IDJob AND d.IDStaff = '{0}'", IDEmp);
            dB.LoadCbJobTask(sqlStr, cb, "IDTasks");
        }
        public void LoadCbJob(ComboBox cb, string IDEmp)
        {
            string sqlStr = string.Format("SELECT ProcessJob.Content FROM ProcessJob INNER JOIN Distribution ON ProcessJob.IDJob = Distribution.IDJob" +
                                        " WHERE Distribution.IDStaff = '{0}'", IDEmp);
            dB.LoadCbJobTask(sqlStr, cb, "Content");
        }
        public void LoadCbTaskDis(ComboBox cb, string IDEmp)
        {
            string sqlStr = string.Format("SELECT DISTINCT IDTasks " +
                "FROM Distribution d, Job j, ProcessJob pj, Tasks t " +
                "WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.IDTasks = t.ID and d.IDStaff IN (SELECT ID FROM Staff WHERE Manager_ID = '{0}');", IDEmp);
            dB.LoadCbJobTask(sqlStr, cb, "IDTasks");
        }

    }
}