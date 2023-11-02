using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class ShiftBL
    {
        FactoryDBEntities DB = new FactoryDBEntities();

        public List<Shift> GetAll()
        {
            List<Shift> list = new List<Shift>();
            foreach (var shift1 in DB.Shift)
            {
                list.Add(shift1);
            }

            return list;
        }

        public Shift GetByID(int id)
        {
            return DB.Shift.Where(x => x.ID == id).First();
        }

        public string Add(Shift shift1)
        {
            DB.Shift.Add(shift1);
            DB.SaveChanges();
            return "added";
        }
        public string Update(int id, Shift shift1)
        {
            Shift shift2 = DB.Shift.Where(x => x.ID == id).First();
            shift2.Date = shift1.Date;
            shift2.StartTime = shift1.StartTime;
            shift2.EndTime = shift1.EndTime;
            DB.SaveChanges();

            return "updated";
        }
        public string Delete(int id)
        {
            Shift shift1 = DB.Shift.Where(x => x.ID == id).First();
            DB.Shift.Remove(shift1);
            DB.SaveChanges();
            return "deleted";
        }
    }
}