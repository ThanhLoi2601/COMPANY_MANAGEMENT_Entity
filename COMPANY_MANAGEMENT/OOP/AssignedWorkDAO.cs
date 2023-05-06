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
    class AssignedWorkDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList(string ID)
        {
            return dB.LoadList(string.Format("SELECT d.IDJob,j.Name,j.Content FROM Job j,  Distribution d " +
                    "WHERE j.ID = d.IDJob AND d.IDStaff = '{0}' AND d.IDJob NOT IN (SELECT IDJob FROM CompleteJob)", ID));
        }
    }
}
