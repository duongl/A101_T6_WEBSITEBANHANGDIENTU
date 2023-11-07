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
        QLCuaHangDienTuDataContext qlch = new QLCuaHangDienTuDataContext();
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
