using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class LeaderDAO
    {
        DBConn dB = new DBConn();
        public void Insert(ExtendedLeader ld)
        {
            string sqlStr = string.Format("INSERT Leader(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ({0});"
                , ld.toStringLd());
            dB.Executive(sqlStr);
        }

        public void Delete(ExtendedLeader ld)
        {
            string sqlStr = string.Format("DELETE FROM Leader WHERE ID = '{0}'", ld.ID);
            dB.Executive(sqlStr);
        }

        public void Update(ExtendedLeader ld)
        {
            string sqlStr = string.Format("UPDATE Leader SET {1} WHERE ID = '{0}'", ld.ID, ld.toStringInfo());
            dB.Executive(sqlStr);
        }

        public bool Login(ExtendedLeader ld)
        {
            string sqlStr = string.Format("SELECT COUNT(*) SoUser FROM Leader WHERE ID = '{0}' and Password = '{1}';", ld.ID, ld.Password);
            return dB.Search(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM Leader"));
        }

        public ExtendedLeader Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Leader WHERE ID = '{0}';", id);
            return dB.FindLeader(sqlStr);
        }
    }
}
