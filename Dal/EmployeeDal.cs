using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class EmployeeDal
    {
        public static List<Employee> GetAllEmployees()
        {
            using (Entities2 db = new Entities2())
            {
                return db.Employee.ToList();
            }
        }

        public static void DeleteEmployee(int IdEmployee)
        {
            using (Entities2 db = new Entities2())
            {
                Employee e = db.Employee.Find(IdEmployee);
                try
                {
                    db.Employee.Remove(e);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    e.StatusEmployee = false;
                    db.SaveChanges();
                }


            }
        }
            public static void AddEmployee(Employee e)
            {
                using (Entities2 db = new Entities2())
                {

                db.Employee.Add(e);
                db.SaveChanges();
                }
            }
        public static void UpdatEmployee(int id, Employee e)
        {
            using (Entities2 db = new Entities2())
            {

               Employee em = db.Employee.Find(id);
               if (em!=null)
                {
                    em.IdPosition = e.IdPosition;
                    em.LastNameEmployee = e.LastNameEmployee;
                    em.FirstNameEmployee = e.FirstNameEmployee;
                    em.IdPosition = e.IdPosition;
                    em.StatusEmployee = e.StatusEmployee;
                    db.SaveChanges();
                }
                
               
            }
        } 
     

    }
}
