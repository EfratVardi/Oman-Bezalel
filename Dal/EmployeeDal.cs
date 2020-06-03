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
            using (Entities1 db = new Entities1())
            {
                return db.Employee.ToList();
            }
        }

        public static void DeleteEmployee(int IdEmployee)
        {
            using (Entities1 db = new Entities1())
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
                using (Entities1 db = new Entities1())
                {

                db.Employee.Add(e);
                db.SaveChanges();
                }
            }
        public static void UpdatEmployee(int id, Employee e)
        {
            using (Entities1 db = new Entities1())
            {

               Employee em = db.Employee.Find(id);
               if (em!=null)
                {
                    em.IdPosition = e.IdPosition;
                    em.LastNameEmployee = e.LastNameEmployee;
                    em.FirstNameEmployee = e.FirstNameEmployee;
                    em.Position = e.Position;
                    em.StatusEmployee = e.StatusEmployee;
                    db.SaveChanges();
                }
                
               
            }
        }

    }
}
