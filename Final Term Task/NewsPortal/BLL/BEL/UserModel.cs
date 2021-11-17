using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        //public virtual ICollection<CommentsModel> CommentsModel { get; set; }
        //public virtual ICollection<News> News { get; set; }
        //public virtual ICollection<React> Reacts { get; set; }
    }
}
