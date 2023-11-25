using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class AccountBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();


        public AccountBLL()
        {

        }
        public DataTable GetAccounts()
        {
            var query = from acc in qlch.GetTable<account>()
                        select new
                        {
                            acc.id,
                            acc.displayName,
                            acc.userName,
                            acc.password,
                            acc.type
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("displayName", typeof(string));
            dataTable.Columns.Add("userName", typeof(string));
            dataTable.Columns.Add("password", typeof(string));
            dataTable.Columns.Add("type", typeof(int));
            foreach(var acc in query)
            {
                dataTable.Rows.Add(acc.id, acc.displayName, acc.userName, acc.password, acc.type);
            }
            return dataTable;
        }
        public bool addAccounts(account newAccounts)
        {
            try
            {
                qlch.accounts.InsertOnSubmit(newAccounts);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteAccounts(int idAccount)
        {
            try
            {
                var accountToDelete = qlch.accounts.SingleOrDefault(acc => acc.id == idAccount);

                if (accountToDelete != null)
                {
                    qlch.accounts.DeleteOnSubmit(accountToDelete);
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
        public bool updateAccounts(account upAccounts)
        {
            try
            {
                var existingAccount = qlch.accounts.SingleOrDefault(acc => acc.id == upAccounts.id);

                if (existingAccount != null)
                {
                    existingAccount.displayName = upAccounts.displayName;
                    existingAccount.userName = upAccounts.userName;
                    existingAccount.password = upAccounts.password;
                    existingAccount.type = upAccounts.type;
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
        public bool doiMatKhau(int id,string mkmoi)
        {
            try
            {
                var existingAccount = qlch.accounts.SingleOrDefault(acc => acc.id == id);
                if (existingAccount != null)
                {                   
                    existingAccount.password = mkmoi;                 
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
        public int KTDMK(string useName,string MKCu,string MKMoi)
        {
            int id;
            if(GetMK(useName)!= null)
            {
                if(GetMK(useName)==MKCu)
                {
                    id =Convert.ToInt32( GetID(useName));
                    doiMatKhau(id, MKMoi);
                    return 1;
                }
                else
                    return 0;
            }
            return 0;
        }

        public string GetType(string userName)
        {
            var query = from acc in qlch.accounts
                        where acc.userName == userName
                        select acc.type.ToString(); 

            return query.SingleOrDefault();
        }
        public string GetID(string userName)
        {
            var query = from acc in qlch.accounts
                        where acc.userName == userName
                        select acc.id.ToString();

            return query.SingleOrDefault();
        }
        public string GetMK(string userName)
        {
            var query = from acc in qlch.accounts
                        where acc.userName == userName
                        select acc.password.ToString();

            return query.SingleOrDefault();
        }

        public DataTable searchAccounts(string keyword)
        {
            var query = from acc in qlch.GetTable<account>()
                        where acc.displayName.Contains(keyword) ||
                              acc.userName.Contains(keyword)
                        select new
                        {
                            acc.id,
                            acc.displayName,
                            acc.userName,
                            acc.password,
                            acc.type
                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("displayName", typeof(string));
            dataTable.Columns.Add("userName", typeof(string));
            dataTable.Columns.Add("password", typeof(string));
            dataTable.Columns.Add("type", typeof(int));

            foreach (var acc in query)
            {
                dataTable.Rows.Add(acc.id, acc.displayName, acc.userName, acc.password, acc.type);
            }

            return dataTable;
        }

    }
}
