using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class ReactModel
    {
        public int Id { get; set; }
        public string React1 { get; set; }
        public int UserId { get; set; }
        public int NewsId { get; set; }

        //public virtual News News { get; set; }
        //public virtual User User { get; set; }
    }
}
