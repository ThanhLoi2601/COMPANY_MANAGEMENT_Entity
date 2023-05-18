using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    class StaffDAO
    {
        DBConn dB = new DBConn();
        public bool Login(Staff sta)
        {
            string sqlStr = string.Format("SELECT COUNT(*) SoUser FROM Staff WHERE ID = '{0}' and Password = '{1}'", sta.ID, sta.Password);
            return dB.Search(sqlStr);
        }

        public void Insert(Staff sta)
        {
            string sqlStr = string.Format("INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');"
                , sta.ID, sta.Name, sta.Birth.Value.ToString("yyyy-MM-dd"), sta.ID_Card, sta.Email, sta.Address, sta.Manager_ID, sta.Basic_salary, sta.Password);
            dB.Executive(sqlStr);
        }

        public void Delete(Staff sta)
        {
            string sqlStr = string.Format("DELETE FROM Staff WHERE ID = '{0}'", sta.ID);
            dB.Executive(sqlStr);
        }

        public void Update(Staff sta)
        {
            string sqlStr = string.Format("UPDATE Staff SET Name= '{0}', Birth= '{1}', ID_Card= '{2}', Email= '{3}', Address= '{4}', Basic_salary= {5}, Password= '{6}' WHERE ID = '{7}'"
                , sta.Name, sta.Birth.Value.ToString("yyyy-MM-dd"), sta.ID_Card, sta.Email, sta.Address, sta.Basic_salary.ToString(), sta.Password, sta.ID);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string IDMan)
        {
            return dB.LoadList(string.Format("SELECT *FROM Staff WHERE Manager_ID = '{0}'", IDMan));
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM Staff"));
        }

        public Staff Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Staff WHERE ID = '{0}';", id);
            return dB.FindStaff(sqlStr);
        }
        public void UpdatePass(Staff sta)
        {
            string sqlStr = string.Format("UPDATE Staff SET Password = '{0}' Where ID ='{1}'", sta.Password, sta.ID);
            dB.Executive(sqlStr);
        }

        public void loadImage(string id, PictureBox ava)
        {
            string sqlStr = string.Format("Select Image From Staff where ID='{0}'", id);
            dB.loadImage(sqlStr, ava);
        }

        public void saveImage(string id, string url)
        {
            string sqlStr = string.Format("Update Staff SET Image= @image where ID ='{0}'", id);
            dB.saveImage(sqlStr, url);
        }
    }
}
