using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class Check : SQLCheck
    {
        public Check(string Id, string Name, DateTime checkDate, bool checkIn, bool checkOut, int Timeslate, DateTime timein, DateTime timeout)
        {
            this.ID = Id;
            this.Name = Name;
            this.DateCheck = checkDate;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.TimesLate = Timeslate;
            this.TimeCheckIn = timein;
            this.TimeCheckOut = timeout;
        }
    }
}
