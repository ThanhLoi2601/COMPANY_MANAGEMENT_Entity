using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class CompleteJobDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM CompleteJob"));
        }

        public void Insert(ExtendedCompJob job)
        {
            string sqlStr = string.Format("Insert INTO CompleteJob VALUES ('{0}','{1}','{2}','{3}')"
                                                                            , job.IDJob, job.Content, job.CompleDate?.ToString("yyyy-MM-dd"), job.Bonus);
            dB.Executive(sqlStr);
        }
        public DataTable LoadList(string IDEmp, string month)
        {
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate, j.IDTasks, t.Task_Name, j.Bonus  FROM CompleteJob cj, Distribution d, Job j, Tasks t " +
                    "WHERE j.IDTasks = t.ID and cj.IDJob = d.IDJob and cj.IDJob = j.ID and d.IDStaff = '{0}'", IDEmp));
            else
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate, j.IDTasks, t.Task_Name, j.Bonus  FROM CompleteJob cj, Distribution d, Job j, Tasks t " +
                    "WHERE j.IDTasks = t.ID and cj.IDJob = d.IDJob and cj.IDJob = j.ID and d.IDStaff = '{0}' and MONTH(CompleDate) = {1}", IDEmp, month));
        }
        public DataTable LoadListTask(string IDEmp, string month)
        {
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate  FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}'", IDEmp));
            else
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate  FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}' and MONTH(CompleDate) = {1}", IDEmp, month));
        }
        public string SumTaskCmp(string IDEmp, string month)
        {
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                return dB.Merge(string.Format("SELECT COUNT(*) FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}'", IDEmp)).ToString();
            else
                return dB.Merge(string.Format("SELECT COUNT(*) FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}' and MONTH(CompleDate) = {1}", IDEmp, month)).ToString();
        }
        public void CalSalary(string query, int salary, TextBox a, TextBox b, Label c)
        {
            dB.Cal_Salary(query, salary, a, b, c);
        }
    }
}
