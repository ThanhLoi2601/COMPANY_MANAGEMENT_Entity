using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class AbsenceLetter : Absence
    {
        public AbsenceLetter()
        { 
        }

        public AbsenceLetter(string staffID, string staffName, string reason, DateTime startDate, DateTime endDate)
        {
            this.Name = staffName ;
            this.ID = staffID;
            this.Reason = reason;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string toStringAbs()
        {
            return string.Format("'{0}','{1}','{2}','{3}','{4}'", ID,Name,Reason,StartDate,EndDate);
        }

        ~AbsenceLetter()
        {
        }
    }
}
