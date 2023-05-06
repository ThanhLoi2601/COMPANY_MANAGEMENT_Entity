using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class AbsenceLetterDAO
    {
        DBConn dB = new DBConn();
        public void UpdateAbsen(AbsenceLetter a)
        {
            string sqlStr = string.Format("INSERT Absence(ID,Name,Reason,StartDate,EndDate) values ('{0}','{1}','{2}','{3}','{4}')", a.ID, a.Name, a.Reason, a.StartDate.ToString("yyyy-MM-dd"), a.EndDate?.ToString("yyyy-MM-dd"));
            dB.Executive(sqlStr);
        }

        public DataTable LoadAbsenStaff(string IDMan)
        {
            return dB.LoadList(string.Format("SELECT * FROM Absence WHERE  ID IN (SELECT ID FROM Staff WHERE Manager_ID = '{0}' )", IDMan));
        }

        public DataTable LoadAbsenManager()
        {
            return dB.LoadList(string.Format("SELECT * FROM Absence WHERE  ID LIKE 'MAN%'"));
        }
    }
}
