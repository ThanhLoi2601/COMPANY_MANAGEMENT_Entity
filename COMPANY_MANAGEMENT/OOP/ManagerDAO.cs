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
    class ManagerDAO
    {
        DBConn dB = new DBConn();
        public void Insert(ExtendedManager man)
        {
            string sqlStr = string.Format("INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ({0});"
                , man.toStringMan());
            dB.Executive(sqlStr);
        }

        public void Delete(ExtendedManager man)
        {
            string sqlStr = string.Format("DELETE FROM Manager WHERE ID = '{0}'", man.ID);
            dB.Executive(sqlStr);
        }

        public void Update(ExtendedManager man)
        {
            string sqlStr = string.Format("UPDATE Manager SET {1} WHERE ID = '{0}'", man.ID, man.toStringInfo());
            dB.Executive(sqlStr);
        }

        public bool Login(ExtendedManager Man)
        {
            string sqlStr = string.Format("SELECT COUNT(*) SoUser FROM Manager WHERE ID = '{0}' and Password = '{1}';", Man.ID, Man.Password);
            return dB.Search(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM Manager"));
        }

        public ExtendedManager Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Manager WHERE ID = '{0}';", id);
            return dB.FindManager(sqlStr);
        }
    }
}
