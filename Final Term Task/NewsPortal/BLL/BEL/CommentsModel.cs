using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class CommentsModel
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }

        //public virtual User User { get; set; }
        //public virtual News News { get; set; }
    }
}
