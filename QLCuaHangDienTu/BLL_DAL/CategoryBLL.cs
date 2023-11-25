using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CategoryBLL
    {
        QL_BanHangDienTuDataContext qlch = new QL_BanHangDienTuDataContext();
        public CategoryBLL()
        {

        }
        public DataTable GetCategorys()
        {
            var query = from cate in qlch.GetTable<laptopCategory>()
                        select new
                        {
                            cate.id,
                            cate.Name,                          

                        };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            foreach (var cate in query)
            {
                dataTable.Rows.Add(cate.id,  cate.Name );
            }
            return dataTable;
        }
        public bool addCategorys(laptopCategory newCategorys)
        {
            try
            {
                qlch.laptopCategories.InsertOnSubmit(newCategorys);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCategorys(int idCategory)
        {
            try
            {
                var CategortToDelete = qlch.laptopCategories.SingleOrDefault(cate => cate.id == idCategory);

                if (CategortToDelete != null)
                {
                    qlch.laptopCategories.DeleteOnSubmit(CategortToDelete);
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
        public bool updateCategorys(laptopCategory upCategorys)
        {
            try
            {
                var existingCategorys = qlch.laptopCategories.SingleOrDefault(cate => cate.id == upCategorys.id);

                if (existingCategorys != null)
                {
                    existingCategorys.id = upCategorys.id;
                    existingCategorys.Name = upCategorys.Name;
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
    }
}
