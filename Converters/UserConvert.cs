using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Converters
{
   public class UserConvert
    {
        //ממירה מחלקה שלנו לשל מיקרוסופט
        public static User ToDalUser(UserDto u)
        {
            User us = new User();
            us.UserId = u.UserId;
            us.UserName = u.UserName;
            us.Password = u.Password;
            return us;

        }
        //ממירה מחלקה של מיקרוסופט לשלנו
        public static UserDto ToDtoUser(User us)
        {
            UserDto u = new UserDto();
            u.UserId= us.UserId;
            u.UserName= us.UserName;
            u.Password= us.Password;
            return u;

        }

        //ממירה אוסף שלנו לאוסף של מיקרוסופט
        public static List<User> ToDalUserList(List<UserDto> le)
        {
            List<User> lpn = new List<User>();
            foreach (var item in le)
            {
                lpn.Add(ToDalUser(item));
            }
            return lpn;
        }

        //ממירה אוסף של מיקרוסופט לאוסף שלנו
        public static List<UserDto> ToUserList(List<User> le)
        {
            List<UserDto> lpn = new List<UserDto>();
            foreach (var item in le)
            {
                lpn.Add(ToDtoUser(item));
            }
            return lpn;
        }
    }
}
