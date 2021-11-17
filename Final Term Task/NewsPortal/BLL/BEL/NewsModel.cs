using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {

        public int Id { get; set; }
        public string News1 { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string PostedDate { get; set; }

       
    }
}
