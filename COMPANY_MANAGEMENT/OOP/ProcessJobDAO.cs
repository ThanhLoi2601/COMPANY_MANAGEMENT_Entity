using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ProcessJobDAO
    {
        DBConn dB = new DBConn();

        public ExtendedProcJob Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM ProcessJob WHERE IDJob = '{0}';", id);
            return dB.FindProcessJob(sqlStr);
        }

        public void Insert(Job job)
        {
            string sqlStr = string.Format("INSERT INTO ProcessJob(IDJob,Content,Process) values ('{0}','{1}',{2})"
                , job.ID, job.Content, 0);
            dB.Executive(sqlStr);
        }

        public void Insert(ExtendedTask t)
        {
            string sqlStr = string.Format("INSERT INTO ProcessJob(IDJob,Content,Process) values ('{0}','{1}',{2})"
                , t.ID, t.Task_description, 0);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public void Update(ExtendedProcJob a)
        {
            string sqlStr = string.Format("UPDATE ProcessJob SET Process = {0} Where Content ='{1}'", a.Process, a.Content);
            dB.Executive(sqlStr);
        }

        public void Detele(ExtendedProcJob a)
        {
            string sqlStr = string.Format("Delete FROM ProcessJob Where Content = '{0}'", a.Content);
            dB.Executive(sqlStr);
        }
    }
}
