using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask.Models.Tables
{
    public class Orders
    {
        SqlConnection conn;

        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void AddOrderToCard(List<Product> products)
        {
           
            foreach (var p in products)
            {
                string query = string.Format("Insert into Orders values('{0}','{1}','{2}')", p.ProductName,p.Price,HttpContext.Current.Session["userId"]);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}