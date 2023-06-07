using DemoADOModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.DataAccess
{
    internal class ProductDAO
    {
        public List<Product> GetProducts(int CategoryID)
        {
            string sql = @"select P.*, CategoryName from Products P, Categories C 
                            where P.CategoryID = @cid and
                                P.CategoryID = C.CategoryID";
            SqlParameter param1 = new SqlParameter("@cid", SqlDbType.Int);
            param1.Value = CategoryID;
            DataTable dt = DAO.GetDataBySQL(sql, param1);
            List<Product> list = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Product(
                    Convert.ToInt32(dr["ProductId"]),
                    dr["ProductName"].ToString() is null ? "" : dr["ProductName"].ToString(),
                    (float)Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToInt32(dr["CategoryId"]),
                    dr["CategoryName"].ToString() is null ? "" : dr["CategoryName"].ToString()
                    ));
            }
            return list;
        }

        public int InsertProduct(Product c)
        {
            return 0;
        }

        public int UpdateProduct(Product c)
        {
            string sql = @"update Products set
                            ProductName = @name,
                            CategoryId = @cat,
                            UnitPrice = @price
                            where ProductId = @id";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
            param1.Value = c.ProductName;
            SqlParameter param2 = new SqlParameter("@cat", SqlDbType.Int);
            param2.Value = c.CategoryID;
            SqlParameter param3 = new SqlParameter("@price", SqlDbType.Money);
            param3.Value = c.UnitPrice;
            SqlParameter param4 = new SqlParameter("@id", SqlDbType.Int);
            param4.Value = c.ProductID;
            return DAO.ExecuteSQL(sql, param1, param2, param3, param4);
        }

        public int DeleteProduct(int ProductID)
        {
            return 0;
        }
    }
}
