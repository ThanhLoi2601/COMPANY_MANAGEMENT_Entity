using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedCompJob : CompleteJob
    {
        public ExtendedCompJob(string id, string content, DateTime comDate, int bonus)
        {
            this.IDJob = id;
            this.Content = content;
            this.CompleDate = comDate;
            this.Bonus = bonus;
        }
    }
}
