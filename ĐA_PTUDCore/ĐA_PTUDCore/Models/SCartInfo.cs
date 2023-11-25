using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBanLaptop2.Models
{
    public class SCartInfo
    {
        public Laptop lap;
        public int soLuong { get; set; }
        public SCartInfo() { }
        public SCartInfo(Laptop _lap, int _quantity)
        {
            this.lap = _lap;
            this.soLuong = _quantity;
        }

    }
}