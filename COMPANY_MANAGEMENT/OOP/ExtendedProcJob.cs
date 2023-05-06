using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedProcJob : ProcessJob
    {
        public ExtendedProcJob() { }

        public ExtendedProcJob(string idJb, string cont, double proc)
        {
            IDJob = idJb;
            Content = cont;
            Process = proc;
        }
        public ExtendedProcJob(string content, int process)
        {
            this.Content = content;
            this.Process = process;
        }

        ~ExtendedProcJob() { }

    }
}
