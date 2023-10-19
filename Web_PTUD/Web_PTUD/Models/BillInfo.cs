using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class BillInfo
    {
        public int id;
        public int idBill;
        public int idLaptop;
        public int counts;

        public BillInfo() { }
        public BillInfo(int id, int idBill, int idLaptop, int counts)
        {
            this.id=id;
            this.idBill=idBill;
            this.idLaptop=idLaptop;
            this.counts=counts;
        }
        public BillInfo(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.idBill = Convert.ToInt32(row["idBill"]);
            this.idLaptop = Convert.ToInt32(row["idLaptop"]);
            this.counts = Convert.ToInt32(row["counts"]);
        }
    }
}