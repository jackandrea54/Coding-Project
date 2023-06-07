using DemoADOModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.DataAccess
{
    internal class CategoryDAO
    {
        public List<Category> GetCategories()
        {
            string sql = "select * from Categories";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Category> list = new List<Category>(); 
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Category(
                    Convert.ToInt32( dr["CategoryId"]),
                    dr["CategoryName"].ToString() is null? "": dr["CategoryName"].ToString()
                    ));
            }
            return list;
        }

        public int InsertCategory(Category c)
        {
            return 0;
        }

        public int UpdateCategory(Category c)
        {
            return 0;
        }

        public int DeleteCategory(int CategoryID)
        {
            return 0;
        }
    }
}
