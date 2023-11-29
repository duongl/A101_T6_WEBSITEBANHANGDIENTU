using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections;

namespace ShopBanLaptop2.Models
{
    public class LaptopConnect
    {
        private static LaptopConnect instance;
        public static LaptopConnect Instance
        {
            get { if (instance == null) instance = new LaptopConnect(); return LaptopConnect.instance; }
            set { LaptopConnect.Instance = value; }

        }

        // ====================================================================================================


        public List<Laptop> getListLaptops(string query)
        {
            List<Laptop> Laptops = new List<Laptop>();
            DataTable data = DataProvider.Instance.executeQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Laptop lap = new Laptop(row);
                Laptops.Add(lap);
            }
            return Laptops;
        }
        // ====================================================================================================
        public List<Laptop> getData()
        {
            List<Laptop> Laptops = new List<Laptop>();
            string query = "select * from Laptop";
            Laptops = getListLaptops(query);
            return Laptops;
        }

        public List<Laptop> search(string txt_search)
        {
            List<Laptop> laptops = new List<Laptop>();
            string query = "select * from Laptop where Name like '%"+txt_search+"%'";
            laptops = getListLaptops(query);
            return laptops;
        }
        public List<Laptop> searchByPC(string pcname)
        {
            List<Laptop> laptops = new List<Laptop>();
            string query = "select * from laptop where productCompany = '"+pcname+"'";
            laptops = getListLaptops(query);
            return laptops;
        }   public List<Laptop> searchByPrice(int type)
        {
            List<Laptop> laptops = new List<Laptop>();
            string query;
            switch (type)
            {
                case 1:
                    query = "select * from laptop where price < 10000000";
                    break;
                case 2:
                    query = "select * from laptop where price >= 10000000 and price < 15000000";
                    break;
                case 3:
                    query = "select * from laptop where price >= 15000000 and price < 20000000";
                    break;
                case 4:
                    query = "select * from laptop where price >= 20000000 and price < 25000000";
                    break;
                case 5:
                    query = "select * from laptop where price >= 25000000";
                    break;
                default:
                    query = "select * from laptop";
                    break;
            }
            laptops = getListLaptops(query);
            return laptops;
        }
        public List<Laptop> searchById(int id)
        {
            List<Laptop> laptops = new List<Laptop>();
            string query = "select * from laptop where id = " +id;
            laptops = getListLaptops(query);
            return laptops;
        }
        // ====================================================================================================
        public int addLaptop(string Name, int idCategory, double price, string productCompany, double monitor, string CPU, string RAM, string Image, string GPU, string HardDisk)
        {
            int kq = -1;

            //=============== Kiem tra trung ten =======================
            string query = "select COUNT(*) from Laptop where Name = N'" + Name + "'";

            kq = Convert.ToInt32(DataProvider.Instance.executeScaler(query));
            // ============== Nếu không trùng tên ======================
            if (kq == 0)
            {
                string query2 = "insert into laptop (Name, idCategory, price, productCompany, monitor, CPU, RAM, Image, GPU, HardDisk) ";
                query2 += "values(N'"+ Name +"',	" + idCategory + ",	"+ price + ",	N'"+productCompany+"',		"+ monitor+", N'"+CPU+"' ,N'"+RAM+"', N'"+Image+"', N'"+GPU+"', N'"+HardDisk+"')";
                kq = DataProvider.Instance.ExecuteNonQuery(query2);
                if (kq == 0)
                    kq = -1;
            }
            else
            {
                kq = -2;
            }
            return kq;
        }

        public int Deletelaptop(int id)
        {
            int kq = -1;

            //=============== Kiem tra trung ten =======================
            string query = "select COUNT(*) from laptop where id = '" + id + "'";
            int kt = Convert.ToInt32(DataProvider.Instance.executeScaler(query));
            // ============== Nếu tồn tại tên trùng ====================
            if (kt > 0)
            {
                string query2 = "delete from Laptop ";
                query2 += "where id = '" + id + "'";
                kq = DataProvider.Instance.ExecuteNonQuery(query2);
            }
            return kq;
        }


        public int EditLaptop(int id,string Name, int idCategory, double price, string productCompany, double monitor, string CPU, string RAM, string Image, string GPU, string HardDisk)
        {
            int kq = -1;
            //=============== Kiem tra trung ten =======================
            string query = "select COUNT(*) from Laptop where id = '" + id + "'";
            int kt = Convert.ToInt32(DataProvider.Instance.executeScaler(query));
            // ============== Nếu tồn tại tên trùng ====================
            if (kt > 0)
            {
                string query2 = "update Laptop ";
                query2 += "set  Name = N'"+ Name +"', idCategory = "+ idCategory + ", price="+ price + ",productCompany = N'"+productCompany+"', monitor="+ monitor+", CPU = N'"+CPU+"' ,RAM = N'"+RAM+"', Image = N'"+Image+"', GPU = N'"+GPU+"', HardDisk = N'"+HardDisk+"'";
                query2 += "where id = " + id;
                kq = DataProvider.Instance.ExecuteNonQuery(query2);
            }
            return kq;
        }
    }
}