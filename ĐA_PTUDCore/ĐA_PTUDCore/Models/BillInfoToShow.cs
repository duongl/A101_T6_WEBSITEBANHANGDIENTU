using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class BillInfoToShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int count { get; set; }
        public BillInfoToShow() { }
        public BillInfoToShow(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Name = Convert.ToString(row["Name"]);
            this.Image = Convert.ToString(row["Image"]);
            this.Price = Convert.ToDouble(row["price"]);
            this.count = Convert.ToInt32(row["counts"]);
        }
    }
}