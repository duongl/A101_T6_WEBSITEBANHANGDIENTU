using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ShopBanLaptop2.Models
{
    public class Account
    {
        public int id { get; set; }
        public string displayName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "UserName no more than 50 characters")]
        [Display(Name = "User Name")]
        public string userName {get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(255, ErrorMessage = "password no less than 255 characters")]
        [MinLength(5, ErrorMessage = "password no more than 5 characters")]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Confim password and password do not match")]
        [Display(Name = "ReType Password")]
        public string rePassword { get; set; }
        public int type { get; set; }



        public Account() { }
        public Account(int id, string displayName, string userName, string password, string rePassword, int type)
        {
            this.id=id;
            this.displayName=displayName;
            this.userName=userName;
            this.password=password;
            this.type=type;
        }

        public Account (DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.displayName = Convert.ToString(row["displayName"]);
            this.userName = Convert.ToString(row["userName"]);
            this.password = Convert.ToString(row["password"]);
            this.type = Convert.ToInt32(row["type"]);
        }
    }
}