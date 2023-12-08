using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class StaffBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();
        public DataTable GetStaffs()
        {
            var query = from s in qlch.GetTable<staff>()
                        select new
                        {
                            s.id,
                            s.Name,
                            s.Sex,
                            s.Phone,
                            s.idAccount
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Sex", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("idAccount", typeof(int));
            foreach (var s in query)
            {
                dataTable.Rows.Add(s.id, s.Name, s.Sex, s.Phone, s.idAccount);
            }
            return dataTable;
        }
        public bool addStaffs(staff newStaff)
        {
            try
            {
                qlch.staffs.InsertOnSubmit(newStaff);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteStaffs(int idStaff)
        {
            try
            {
                var staffToDelete = qlch.staffs.SingleOrDefault(s => s.id == idStaff);

                if (staffToDelete != null)
                {
                    qlch.staffs.DeleteOnSubmit(staffToDelete);
                    qlch.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool updateStaffs(staff upStaff)
        {
            try
            {
                var existingStaff = qlch.staffs.SingleOrDefault(s => s.id == upStaff.id);

                if (existingStaff != null)
                {
                    existingStaff.Name = upStaff.Name;
                    existingStaff.Sex = upStaff.Sex;
                    existingStaff.Phone = upStaff.Phone;
                    existingStaff.idAccount = upStaff.idAccount;
                    qlch.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }

        }

        public DataTable cbbsex()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DisplayMember", typeof(string));



            dataTable.Rows.Add("Nam");


            dataTable.Rows.Add("Nữ");

            return dataTable;
        }
        public string GetType(int id)
        {
            var query = from acc in qlch.accounts
                        where acc.id == id
                        select acc.type.ToString();

            return query.SingleOrDefault();
        }
        public int CheckUserName(string username)
        {
            // Check if idAccount exists in staff
            var u = from acc in qlch.accounts                  
                    where acc.displayName == username
                           select acc.id;

            return u.SingleOrDefault();
        }
    }
}
