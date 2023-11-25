using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BillBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();
        public BillBLL()
        {

        }
        public DataTable GetBills()
        {
            var query = from bil in qlch.GetTable<bill>()
                        select new
                        {
                            bil.id,
                            bil.idAccount,
                            bil.status,
                            bil.datepay,
                            
                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("idAccount", typeof(int));
            dataTable.Columns.Add("status", typeof(int));
            dataTable.Columns.Add("datepay", typeof(DateTime));
            
            foreach (var bil in query)
            {
                dataTable.Rows.Add(bil.id,bil.idAccount,bil.status,bil.datepay);
            }
            return dataTable;
        }
       
        public bool deleteBills(int idBill)
        {
            try
            {
                var billToDelete = qlch.bills.SingleOrDefault(bil => bil.id == idBill);

                if (billToDelete != null)
                {
                    qlch.bills.DeleteOnSubmit(billToDelete);
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
        public bool updateBills(bill upBills)
        {
            try
            {
                var existingBill = qlch.bills.SingleOrDefault(bil => bil.id == upBills.id);

                if (existingBill != null)
                {
                    existingBill.id = upBills.id;
                    existingBill.idAccount = upBills.idAccount;
                    existingBill.status = upBills.status;
                    existingBill.datepay = upBills.datepay;
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
        public DataTable searchBills(DateTime keyword)
        {
            var query = from bil in qlch.GetTable<bill>()
                        where bil.datepay.Value == keyword.Date
                        select new
                        {
                            bil.id,
                            bil.idAccount,
                            bil.status,
                            bil.datepay,
                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("idAccount", typeof(int));
            dataTable.Columns.Add("status", typeof(int));
            dataTable.Columns.Add("datepay", typeof(DateTime));

            foreach (var bil in query)
            {
                dataTable.Rows.Add(bil.id, bil.idAccount, bil.status, bil.datepay);
            }
            return dataTable;
        }
    }
}
