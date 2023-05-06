using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedManager : Manager
    {
        public ExtendedManager()
        {
        }
        public ExtendedManager(string ID, string Ten, DateTime birthday, string id_Card, string EMAIL, string add, int bSalary, string pass)
        {
            this.ID = ID;
            this.Name = Ten;
            this.Birth = birthday;
            this.ID_Card = id_Card;
            this.Email = EMAIL;
            this.Address = add;
            this.Basic_salary = bSalary;
            this.Password = pass;
        }

        public ExtendedManager(string ID, string pass)
        {
            this.ID = ID;
            this.Password = pass;
        }
        ~ExtendedManager()
        {
        }

        public string toStringMan()
        {
            return string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", ID, Name, Birth?.ToString("yyyy-MM-dd"), ID_Card, Email, Address, Basic_salary, Password); 
        }
        public string toStringInfo()
        {
            return string.Format("ID= '{0}', Name= '{1}', Birth= '{2}', ID_Card= '{3}', Email= '{4}', Address= '{5}', Basic_salary= '{6}', Password= '{7}' "
                , ID, Name, Birth?.ToString("yyyy-MM-dd"), ID_Card, Email, Address, Basic_salary, Password);
        }
    }
}
