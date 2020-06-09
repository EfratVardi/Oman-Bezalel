using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
using Converters;

namespace Bll
{
  public class UserBll
    {
        public static string FindUser(User u)
        {
            return UserDal.FindUser(u);
        }
    }
}
