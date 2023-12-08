using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKeBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();
        public DataTable GetThongKe()
        {
            var query = from laptop in qlch.GetTable<laptop>()
                        join billInfo in qlch.GetTable<billInfo>() on laptop.id equals billInfo.idLaptop
                        join bill in qlch.GetTable<bill>() on billInfo.idBill equals bill.id
                        select new
                        {
                            BillInfoId = billInfo.id,
                            BillId = bill.id,
                            BillAccountId = bill.idAccount,
                            LaptopId = laptop.id,
                            LaptopName = laptop.Name,
                            LaptopCategory = laptop.idCategory,
                            BillDatePay = bill.datepay,
                            Counts = billInfo.counts,
                            Price = laptop.price,
                            Total = billInfo.counts * laptop.price,

                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("BillId", typeof(int));
            dataTable.Columns.Add("BillAccountId", typeof(int));
            dataTable.Columns.Add("BillDatePay", typeof(string));
            dataTable.Columns.Add("LaptopId", typeof(int));
            dataTable.Columns.Add("LaptopName", typeof(string));
            dataTable.Columns.Add("Counts", typeof(int));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("Total", typeof(double));
            foreach (var row in query)
            {
                // Add rows to the DataTable based on the selected fields
                dataTable.Rows.Add(row.BillId, row.BillAccountId, row.BillDatePay, row.LaptopId, row.LaptopName, row.Counts, row.Price, row.Total);
            }


            return dataTable;
        }
        public DataTable search(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var query = from laptop in qlch.GetTable<laptop>()
                        join billInfo in qlch.GetTable<billInfo>() on laptop.id equals billInfo.idLaptop
                        join bill in qlch.GetTable<bill>() on billInfo.idBill equals bill.id
                        where bill.datepay.Value >= ngayBatDau.Date && bill.datepay.Value <= ngayKetThuc.Date
                        select new
                        {
                            BillInfoId = billInfo.id,
                            BillId = bill.id,
                            BillAccountId = bill.idAccount,
                            LaptopId = laptop.id,
                            LaptopName = laptop.Name,
                            LaptopCategory = laptop.idCategory,
                            BillDatePay = bill.datepay,
                            Counts = billInfo.counts,
                            Price = laptop.price,
                            Total = billInfo.counts * laptop.price,

                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("BillId", typeof(int));
            dataTable.Columns.Add("BillAccountId", typeof(int));
            dataTable.Columns.Add("BillDatePay", typeof(string));
            dataTable.Columns.Add("LaptopId", typeof(int));
            dataTable.Columns.Add("LaptopName", typeof(string));
            dataTable.Columns.Add("Counts", typeof(int));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("Total", typeof(double));
            foreach (var row in query)
            {
                // Add rows to the DataTable based on the selected fields
                dataTable.Rows.Add(row.BillId, row.BillAccountId,row.BillDatePay, row.LaptopId, row.LaptopName, row.Counts, row.Price, row.Total);
            }

            return dataTable;
        }

    }
}
