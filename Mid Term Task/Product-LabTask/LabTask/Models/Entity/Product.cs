using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask.Models.Entity
{
    public class Product
    {
        public int Id { set; get; }
        [Required(ErrorMessage ="Product name can't be Empty")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Price can't be empty")]
        public float Price { get; set; }
        [Required(ErrorMessage ="Quantitycan't be empty")]
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Description can't be empty")]
        public string Description { get; set; }
    }
}