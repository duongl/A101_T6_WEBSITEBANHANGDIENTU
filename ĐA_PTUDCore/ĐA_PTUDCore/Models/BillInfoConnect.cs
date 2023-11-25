using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class BillInfoConnect
    {

        private static BillInfoConnect instance;
        public static BillInfoConnect Instance
        {
            get { if (instance == null) instance = new BillInfoConnect(); return BillInfoConnect.instance; }
            set { BillInfoConnect.Instance = value; }
        }

        //============================================================================================================
        public int createBillInfo(int _idBill, int _idLaptop, int _count)
        {
            int kq = -1;
            string query = "insert into billInfo(idBill, idLaptop, counts)";
            query += "values("+_idBill+", "+_idLaptop+", "+_count+")";
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq;
        }

        public List<BillInfo> getBillInfoByIdBill(int idBill)
        {
            string query = "select * from billInfo where IdBill = "+idBill;
            List<BillInfo> billInfos = getListBillInfos(query);
            return billInfos;
        }

        //===================================================================================
        public List<BillInfo> getListBillInfos(string query)
        {
            List<BillInfo> billInfos = new List<BillInfo>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfo billin = new BillInfo(row);

                billInfos.Add(billin);
            }

            return billInfos;
        }
    }
}