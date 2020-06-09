using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Converters
{
     public class EmployeeConverters
        {
            //ממירה מחלקה שלנו לשל מיקרוסופט
            public static Employee ToDalEmployee(EmployeeDto e)
            {
                Employee en = new Employee();
                en.FirstNameEmployee = e.FirstNameEmployee;
                en.IdEmployee = e.IdEmployee;
                en.IdPosition = e.IdPosition;
                en.LastNameEmployee = e.LastNameEmployee;
                en.UserId = e.UserId;
                return en;

            }
            //ממירה מחלקה של מיקרוסופט לשלנו
            public static EmployeeDto ToDtoEmployee(Employee e)
            {
                EmployeeDto en = new EmployeeDto();
                en.FirstNameEmployee = e.FirstNameEmployee;
                en.IdEmployee = e.IdEmployee;
                en.IdPosition = e.IdPosition;
                en.LastNameEmployee = e.LastNameEmployee;
                en.UserId = e.UserId;
                return en;
            }

            //ממירה אוסף שלנו לאוסף של מיקרוסופט
            public static List<Employee> ToDalEmployeeList(List<EmployeeDto> le)
            {
                List<Employee> lpn = new List<Employee>();
                foreach (var item in le)
                {
                    lpn.Add(ToDalEmployee(item));
                }
                return lpn;
            }

            //ממירה אוסף של מיקרוסופט לאוסף שלנו
            public static List<EmployeeDto> ToEmployeeList(List<Employee> le)
            {
                List<EmployeeDto> lpn = new List<EmployeeDto>();
                foreach (var item in le)
                {
                    lpn.Add(ToDtoEmployee(item));
                }
                return lpn;
            }
        }
    }


