using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class DepartmentBL
    {
        FactoryDBEntities DB= new FactoryDBEntities();

        public List<Department> GetAll()
        {
            List<Department> list = new List<Department>();
            foreach(var dep in DB.Department)
            {
                list.Add(dep);
            }

            return list;
        }
        
        public Department GetByID(int id) 
        { 
        return DB.Department.Where(x=> x.ID==id).First();
        }

        public string Add(Department dep)
        {
            DB.Department.Add(dep);
            DB.SaveChanges();
            return "added";
        }
        public string Update(int id,Department dep1)
        {
            Department dep2 = DB.Department.Where(x => x.ID==id).First();
            dep2.Name = dep1.Name;
            dep2.Manager = dep1.Manager;
            DB.SaveChanges();
            
            return "updated";
        }
        public string Delete(int id) 
        {
            Department dep = DB.Department.Where(x => x.ID == id).First();
            DB.Department.Remove(dep);
            DB.SaveChanges();
            return "deleted";
        }
    }
}