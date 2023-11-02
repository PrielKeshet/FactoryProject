using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class EmployeeShiftBL
    {
        FactoryDBEntities DB = new FactoryDBEntities();

        public List<EmployeeShift> GetAll()
        {
            List<EmployeeShift> list = new List<EmployeeShift>();
            foreach (var EmployeeShift1 in DB.EmployeeShift)
            {
                list.Add(EmployeeShift1);
            }

            return list;
        }

        public EmployeeShift GetByID(int id)
        {
            return DB.EmployeeShift.Where(x => x.ID == id).First();
        }

        public string Add(EmployeeShift EmployeeShift1)
        {
            DB.EmployeeShift.Add(EmployeeShift1);
            DB.SaveChanges();
            return "added";
        }
        public string Update(int id, EmployeeShift EmployeeShift1)
        {
            EmployeeShift EmployeeShift2 = DB.EmployeeShift.Where(x => x.ID == id).First();
            EmployeeShift2.EmployeeID = EmployeeShift1.EmployeeID;
            EmployeeShift2.ShiftID = EmployeeShift1.ShiftID;
            DB.SaveChanges();

            return "updated";
        }
        public string Delete(int id)
        {
            EmployeeShift EmployeeShift1 = DB.EmployeeShift.Where(x => x.ID == id).First();
            DB.EmployeeShift.Remove(EmployeeShift1);
            DB.SaveChanges();
            return "deleted";
        }
    }
}