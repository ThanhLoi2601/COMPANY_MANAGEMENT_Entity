using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedJob:Job
    {
        public ExtendedJob(string ID, string NAME, string CONTENT, DateTime DATESTART, DateTime DATEEND, int BONUS, string IDTASK)
        {
            this.ID = ID;
            this.Name = NAME;
            this.Content = CONTENT;
            this.DateStart = DATESTART;
            this.DateEnd = DATEEND;
            this.Bonus = BONUS;
            this.IDTasks = IDTASK;
        }

        ~ExtendedJob()
        {
        }
    }
}
