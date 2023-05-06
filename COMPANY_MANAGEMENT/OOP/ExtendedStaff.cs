using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class ExtendedStaff :Staff
    {
        public ExtendedStaff()
        {
        }
        public ExtendedStaff(string id, string ten, DateTime birthday, string id_card, string email, string add, string manager_id, int bSalary, string pass)
        {
            this.ID = id;
            this.Name = ten;
            this.Birth = birthday;
            this.ID_Card = id_card;
            this.Email = email;
            this.Address = add;
            this.Manager_ID = manager_id;
            this.Basic_salary = bSalary;
            this.Password = pass;
        }
        public ExtendedStaff(string name, DateTime birth, string id_card, string email, string address, string id)
        {
            this.Name = name;
            this.Birth = birth;
            this.ID_Card = id_card;
            this.Email = email;
            this.Address = address;
            this.ID = id;
        }
        public ExtendedStaff(string id, string pass)
        {
            this.ID = id;
            this.Password = pass;
        }
        ~ExtendedStaff()
        {
        }
    }
}
