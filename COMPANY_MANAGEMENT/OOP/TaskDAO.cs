using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class TaskDAO
    {
        DBConn dB = new DBConn();
        public void Insert(ExtendedTask tks)
        {
            string sqlStr = string.Format("INSERT INTO Tasks(ID,Task_Name,StartDate,EndDate,Task_description,Task_status,Project_ID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , tks.ID, tks.Task_Name, tks.StartDate.ToString(), tks.EndDate.ToString(), tks.Task_description, tks.Status.ToString(), tks.Project_ID);
            dB.Executive(sqlStr);
        }

        public void Delete(ExtendedTask tks)
        {
            string sqlStr = string.Format("DELETE FROM Tasks WHERE ID = '{0}'", tks.ID);
            dB.Executive(sqlStr);
        }

        public void Update(ExtendedTask tks)
        {
            string sqlStr = string.Format("UPDATE Tasks Set Task_Name = '{0}', Task_description = '{1}', StartDate = '{2}', EndDate = '{3}', Task_status = '{4}'  WHERE ID ='{5}'"
                , tks.Task_Name, tks.Task_description, tks.StartDate.ToString(), tks.EndDate.ToString(), tks.Status.ToString(), tks.ID);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public DataTable LoadList(string id)
        {
            if (id != "")
                return dB.LoadList(string.Format("SELECT ID, Task_Name, StartDate, EndDate, Task_description, Task_status FROM Tasks WHERE ID like 'TKS%' and Project_ID = '{0}'", id));
            else
                return dB.LoadList(string.Format("SELECT ID, Task_Name, StartDate, EndDate, Task_description, Task_status FROM Tasks WHERE ID like 'TKS%'"));
        }

        public DataTable LoadListTaskMan(string idMan)
        {
            return dB.LoadList(string.Format("SELECT t.ID, t.Task_Name, t.Task_description, t.StartDate, t.EndDate, t.Task_status,t.Project_ID, p.Project_Name FROM Tasks t, Distribution d, Projects p WHERE t.ID = d.IDJob and t.Project_ID = p.ID and d.IDStaff = '{0}'",idMan));
        }

        public string Search(string id)
        {
            if (id == "All tasks")
                return null;
            string sqlStr = string.Format("SELECT * FROM Tasks WHERE ID = '{0}';", id);
            return dB.FindNameTask(sqlStr);
        }

        public ExtendedTask SearchTask(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Tasks WHERE ID = '{0}';", id);
            return dB.FindTask(sqlStr);
        }
    }
}
