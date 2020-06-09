using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public class UserDal
    {
        public static string FindUser(User u)
        {
            using (Entities2 db = new Entities2())
            {
                User e = db.User.FirstOrDefault(o => o.UserName == u.UserName && o.Password == u.Password);
                if (e != null)
                {
                    Employee em = db.Employee.FirstOrDefault(o => o.UserId == e.UserId);
                    if (em!=null)
                        return "employee";
                    return "interested";

                }
                   
                else
                    return "notfound";
            }

        }
    }
}
