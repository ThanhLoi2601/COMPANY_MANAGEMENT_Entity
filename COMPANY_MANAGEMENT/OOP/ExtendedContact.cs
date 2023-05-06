using System;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedContact : Contact
    {
        public ExtendedContact() { }
        public ExtendedContact(string idS, string NSent, string sub, string cont, string idRe,DateTime date)
        {
            IDSent = idS;
            NameSent = NSent;
            Subject = sub;
            Content = cont;
            IDReceive = idRe;
            InfoDate = date;
        }

        ~ExtendedContact() { }
    }
}
