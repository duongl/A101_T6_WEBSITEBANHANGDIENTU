using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Threading;
using System.Xml.Linq;
using System.Collections;

namespace ShopBanLaptop2.Models
{
    public class AccountConnect
    {
        private static AccountConnect instance;
        public static AccountConnect Instance
        {
            get { if (instance == null) instance = new AccountConnect(); return AccountConnect.instance; }
            set { AccountConnect.Instance = value; }
        }
        //===================================================================================

        public List<Account> getData()
        {
            List<Account> accs = new List<Account>();
            string query = "select * from account";
            accs = getListAccount(query);
            return accs;
        }
        public int editAccount(int id, string displayName, string password)
        {
            int kq = -1;

            //=============== Kiem tra trung ten =======================
            string query = "select COUNT(*) from account where id = '" + id + "'";
            int kt = Convert.ToInt32(DataProvider.Instance.executeScaler(query));
            // ============== Nếu tồn tại tên trùng ====================
            if (kt > 0)
            {
                string query2 = "update account ";
                query2 += "set  displayName = N'"+ displayName +"', password = '"+password+"'";
                query2 += "where id = " + id;
                kq = DataProvider.Instance.ExecuteNonQuery(query2);
            }
            return kq;
        }

        public int addAccount(string userName, string password)
        {
            int kq = -1;
            //=============== Kiem tra trung ten =======================
            string query = "select COUNT(*) from account where userName = N'" + userName + "'";
            kq = Convert.ToInt32(DataProvider.Instance.executeScaler(query));
            // ============== Nếu không trùng tên ======================
            if (kq == 0)
            {
                string query2 = "insert into account (displayName,userName, password) ";
                query2 += "values(N'"+ userName +"',N'"+ userName +"','"+password+"')";

                kq = DataProvider.Instance.ExecuteNonQuery(query2);
                if (kq == 0)
                    kq = -1; // khong thanh cong
            }
            else
            {
                kq = -2; // ton tai
            }
            return kq;
        }

        public List<Account> login(string userName, string password)
        {
            //
            string sql = "select * from account where userName = '"+userName+"' and password = '"+password+"'";
            List<Account> Accounts = getListAccount(sql);
            return Accounts;
        }
        public List<Account> searchByUserName(string userName)
        {
            string sql = "select * from account where userName like '%"+userName+"%'";
            List<Account> Accounts = getListAccount(sql);
            return Accounts;
        }

        //===================================================================================
        public List<Account> getListAccount(string query)
        {
            List<Account> Accounts = new List<Account>();
            DataTable table = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in table.Rows)
            {
                Account acc = new Account(row);
                Accounts.Add(acc);
            }
            return Accounts;
        }
        //===================================================================================


    }
}