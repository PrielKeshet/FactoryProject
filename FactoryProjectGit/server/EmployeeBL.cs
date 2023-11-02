using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class EmployeeBL
    {
        FactoryDBEntities DB = new FactoryDBEntities();

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            foreach (var emp in DB.Employee)
            {
                list.Add(emp);
            }

            return list;
        }

        public Employee GetByID(int id)
        {
            return DB.Employee.Where(x => x.ID == id).First();
        }

        public string Add(Employee emp)
        {
            DB.Employee.Add(emp);
            DB.SaveChanges();
            return "added";
        }
        public string Update(int id, Employee emp1)
        {
            Employee emp2 = DB.Employee.Where(x => x.ID == id).First();
            emp2.FName = emp1.FName;
            emp2.LName = emp1.LName;
            emp2.StartWorkYear = emp1.StartWorkYear;
             emp2.DepartmentID = emp1.DepartmentID;
            DB.SaveChanges();

            return "updated";
        }
        public string Delete(int id)
        {
            Employee emp = DB.Employee.Where(x => x.ID == id).First();
            DB.Employee.Remove(emp);
            DB.SaveChanges();
            return "deleted";
        }
    }
}