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
                string query = string.Format("Insert into Orders values('{0}','{1}','{2}','{3}')", p.ProductName,p.Price,HttpContext.Current.Session["userId"], "Ordered");
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Order> MyOrder()
        {
            
            string query = string.Format("select * from Orders where UserId='{0}'", HttpContext.Current.Session["userId"]);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order o = new Order()
                {
                    OrderItem = reader.GetString(reader.GetOrdinal("OrderItem")),
                    Price = (float) reader.GetDouble(reader.GetOrdinal("price")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                };
                orders.Add(o);
            }
            return orders;
        }
    }
}