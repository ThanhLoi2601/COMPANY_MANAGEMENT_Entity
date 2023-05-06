using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    public class ExtendedLeader : Leader
    {
        public ExtendedLeader() {}

        public ExtendedLeader(string ID, string pass)
        {
            this.ID = ID;
            this.Password = pass;
        }

        public ExtendedLeader(string _id, string _name, DateTime _dateofbirth, string _idcard, string _email, string _address, int _basicsalary, string _password)
        {
            this.ID = _id;
            this.Name = _name;
            this.Birth = _dateofbirth;
            this.ID_Card = _idcard;
            this.Email = _email;
            this.Address = _address;
            this.Basic_salary = _basicsalary; 
            this.Password = _password;
        }
        ~ExtendedLeader() { }

        public string toStringLd()
        {
            return string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", ID, Name, Birth, ID_Card, Email, Address, Basic_salary, Password);
        }
        public string toStringInfo()
        {
            return string.Format("ID= '{0}', Name= '{1}', Birth= '{2}', ID_Card= '{3}', Email= '{4}', Address= '{5}', Basic_salary= '{6}', Password= '{7}' "
                , ID, Name, Birth, ID_Card, Email, Address, Basic_salary, Password);
        }
    }
}
