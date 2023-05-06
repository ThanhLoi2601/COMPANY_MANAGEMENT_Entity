using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ContactDAO
    {
        DBConn dB = new DBConn();
        public void Insert(ExtendedContact cont)
        {
            string sqlStr = string.Format("INSERT INTO Contact(IDSent,NameSent,Subject,Content,IDReceive,InfoDate) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , cont.IDSent, cont.NameSent, cont.Subject, cont.Content, cont.IDReceive, cont.InfoDate.ToString("yyyy-MM-dd"));
            dB.Executive(sqlStr);
        }

        public DataTable LoadListSent(string ID)
        {
            return dB.LoadList(string.Format("SELECT * FROM Contact WHERE IDSent= '{0}'", ID));
        }
        public DataTable LoadListReceive(string ID)
        {
            DataTable dt = null;
            if (ID.Contains("MAN") == true)
                dt= dB.LoadList(string.Format("SELECT * FROM Contact WHERE IDReceive= 'All' or  IDReceive= 'All Manager' or IDReceive= '{0}'",ID));
            else if (ID.Contains("EMP") == true)
                dt = dB.LoadList(string.Format("SELECT * FROM Contact WHERE IDReceive= 'All' or  IDReceive= 'All Staff' or IDReceive= '{0}'", ID));
            return dt;
        }

    }
}
