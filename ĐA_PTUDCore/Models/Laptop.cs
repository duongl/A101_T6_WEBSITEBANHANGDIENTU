using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ShopBanLaptop2.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "UserName no more than 100 characters")]
        [Display(Name = "Ten Laptop")]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public string ProductCompany { get; set; }
        public double monitor { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
        public string HardDisk { get; set; }

        public Laptop() { }
        public Laptop(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Name = Convert.ToString(row["Name"]);
            this.Image = Convert.ToString(row["Image"]);
            this.IdCategory = Convert.ToInt32(row["idCategory"]);
            this.Price = Convert.ToDouble(row["price"]);
            this.ProductCompany = Convert.ToString(row["productCompany"]);
            this.monitor = Convert.ToDouble(row["monitor"]);
            this.CPU = Convert.ToString(row["CPU"]);
            this.RAM = Convert.ToString(row["RAM"]);
            this.GPU = Convert.ToString(row["GPU"]);
            this.HardDisk = Convert.ToString(row["HardDisk"]);
        }
    }
}