using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using Converters;

namespace Bll
{
    public class EmployeeBll
    {
        public static List<EmployeeDto> GetAllEmployees()
        {
          
            return EmployeeConverters.ToEmployeeList(EmployeeDal.GetAllEmployees());
        }

        public static void DeleteEmployee(int IdEmployee)
        {

           EmployeeDal.DeleteEmployee(IdEmployee);
        }
        public static void AddEmployee(Employee e)
        {

            EmployeeDal.AddEmployee(e);
        }
        public static void UpdateEmployee(int id, Employee e)
        {

            EmployeeDal.UpdatEmployee(id, e);
        }
    }
}
