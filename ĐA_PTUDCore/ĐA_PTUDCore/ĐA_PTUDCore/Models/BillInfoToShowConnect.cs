using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class BillInfoToShowConnect
    {
        private static BillInfoToShowConnect instance;
        public static BillInfoToShowConnect Instance
        {
            get { if (instance == null) instance = new BillInfoToShowConnect(); return BillInfoToShowConnect.instance; }
            set { BillInfoToShowConnect.Instance = value; }
        }

        public List<BillInfoToShow> getListBillInfos(string query)
        {
            List<BillInfoToShow> billInfos = new List<BillInfoToShow>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfoToShow billin = new BillInfoToShow(row);
                billInfos.Add(billin);
            }
            return billInfos;
        }

        public List<BillInfoToShow> getBillInfoByIdBill(int idBill)
        {
            string query = "select laptop.id, Name, Image,price, counts from billInfo, laptop";
            query += " where IdBill = "+idBill+" and billInfo.idLaptop = laptop.id";
            List<BillInfoToShow> billInfos = getListBillInfos(query);
            return billInfos;
        }
    }
}