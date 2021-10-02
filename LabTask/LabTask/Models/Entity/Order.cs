using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTask.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderItem { get; set; }
        public string TotalPrice { get; set; }
    }
}