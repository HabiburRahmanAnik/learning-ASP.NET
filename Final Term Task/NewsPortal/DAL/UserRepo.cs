using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static NewsEntities db;

        static UserRepo()
        {
            db = new NewsEntities();
        }

       
    }
}
