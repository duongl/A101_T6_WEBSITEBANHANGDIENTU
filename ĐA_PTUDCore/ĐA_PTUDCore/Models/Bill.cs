using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class Bill
    {
        public int id;
        public int idAccount;
        public string datebuy;
        public int status;

        public Bill()
        { }
        public Bill(int _id, int _idAccount, int _status)
        {
            id = _id;
            idAccount = _idAccount;
            status = _status;
        }

        public Bill(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.idAccount = Convert.ToInt32(row["idAccount"]);
            this.status = Convert.ToInt32(row["status"]);
            string temp = row["datepay"].ToString();
            this.datebuy = temp.Length >= 10 ? temp.Substring(0, 10) : "";
        }
    }
}