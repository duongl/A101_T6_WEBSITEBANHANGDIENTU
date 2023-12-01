using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class BillConnect
    {
        private static BillConnect instance;
        public static BillConnect Instance
        {
            get { if (instance == null) instance = new BillConnect(); return BillConnect.instance; }
            set { BillConnect.Instance = value; }
        }

        //============================================================================================================
        public List<Bill> getBillsByAccount(int _idAccount)
        {
            string query = "select * from bill where idAccount = "+_idAccount;
            List<Bill> bills = getListBills(query);
            return bills;
        }
        public Bill getBillById(int id)
        {
            string query = "select * from bill where id = " + id;
            List<Bill> bills = getListBills(query);
            return bills[0];
        }
        public int createBill(int _idAccount, int _status)
        {
            int kq = -1;
            string query = "insert into bill(idAccount, status)";
            query += "values("+_idAccount+", "+_status +")";
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq;
        }
        
        public int getIdNoPay(int _idAccount)
        {
            int kq = -1;
            string query = "select * from bill where idAccount = "+_idAccount+" and status = 0";
            List<Bill> bills = getListBills(query);
            if (bills.Count > 0)
                kq = bills.FirstOrDefault().id;
            return kq;
        }

        public int setIsPay(int _idAccount)
        {
            string query = "UPDATE bill SET status = 1 WHERE status = 0 and idAccount = "+_idAccount+"; ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        //===================================================================================
        public List<Bill> getListBills(string query)
        {
            List<Bill> bills = new List<Bill>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Bill bil = new Bill(row);
                bills.Add(bil);
            }
            return bills;
        }
    }
}