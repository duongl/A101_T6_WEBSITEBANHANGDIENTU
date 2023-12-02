using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LaptopBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();
        public LaptopBLL()
        {

        }
        public DataTable GetLaptops()
        {
            var query = from lt in qlch.GetTable<laptop>()
                        select new
                        {
                            lt.id,
                            lt.Name,
                            lt.idCategory,
                            lt.price,
                            lt.productCompany,
                            lt.monitor,
                            lt.CPU,
                            lt.RAM,
                            lt.Image,
                            lt.GPU,
                            lt.HardDisk,
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("idCategory", typeof(int));
            dataTable.Columns.Add("price", typeof(double));
            dataTable.Columns.Add("productCompany", typeof(string));
            dataTable.Columns.Add("monitor", typeof(double));
            dataTable.Columns.Add("CPU", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("Image", typeof(string));
            dataTable.Columns.Add("GPU", typeof(string));
            dataTable.Columns.Add("HardDisk", typeof(string));


            foreach (var lt in query)
            {
                dataTable.Rows.Add(lt.id, lt.Name,lt.idCategory,lt.price,lt.productCompany,lt.monitor,lt.CPU,lt.RAM,lt.Image,lt.GPU,lt.HardDisk);
            }
            return dataTable;
        }
        public bool addLaptops(laptop newlaptop)
        {
            try
            {
                qlch.laptops.InsertOnSubmit(newlaptop);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteLaptops(int idLT)
        {
            try
            {
                var LaptopToDelete = qlch.laptops.SingleOrDefault(lt => lt.id == idLT);

                if (LaptopToDelete != null)
                {
                    qlch.laptops.DeleteOnSubmit(LaptopToDelete);
                    qlch.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool updateLaptops(laptop upLaptops)
        {
            try
            {
                var existingLaptop = qlch.laptops.SingleOrDefault(lt => lt.id == upLaptops.id);

                if (existingLaptop != null)
                {
                    existingLaptop.id = upLaptops.id;
                    existingLaptop.Name = upLaptops.Name;
                    existingLaptop.idCategory = upLaptops.idCategory;
                    existingLaptop.price = upLaptops.price;
                    existingLaptop.productCompany = upLaptops.productCompany;
                    existingLaptop.monitor = upLaptops.monitor;
                    existingLaptop.CPU = upLaptops.CPU;
                    existingLaptop.RAM = upLaptops.RAM;
                    existingLaptop.Image  = upLaptops.Image;
                    existingLaptop.GPU = upLaptops.GPU;
                    existingLaptop.HardDisk = upLaptops.HardDisk;
                    qlch.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }

        }
        public DataTable searchLaptops(string keyword)
        {
            var query = from lt in qlch.GetTable<laptop>()
                        where lt.Name.Contains(keyword) || lt.productCompany.Contains(keyword)|| lt.CPU.Contains(keyword)|| lt.RAM.Contains(keyword) || lt.HardDisk.Contains(keyword) 
                        select new
                        {
                            lt.id,
                            lt.Name,
                            lt.idCategory,
                            lt.price,
                            lt.productCompany,
                            lt.monitor,
                            lt.CPU,
                            lt.RAM,
                            lt.Image,
                            lt.GPU,
                            lt.HardDisk,
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("idCategory", typeof(int));
            dataTable.Columns.Add("price", typeof(double));
            dataTable.Columns.Add("productCompany", typeof(string));
            dataTable.Columns.Add("monitor", typeof(double));
            dataTable.Columns.Add("CPU", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("Image", typeof(string));
            dataTable.Columns.Add("GPU", typeof(string));
            dataTable.Columns.Add("HardDisk", typeof(string));


            foreach (var lt in query)
            {
                dataTable.Rows.Add(lt.id, lt.Name, lt.idCategory, lt.price, lt.productCompany, lt.monitor, lt.CPU, lt.RAM, lt.Image, lt.GPU, lt.HardDisk);
            }
            return dataTable;
        }


    }
}
