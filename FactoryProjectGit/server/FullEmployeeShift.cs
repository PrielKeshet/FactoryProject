using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class FullEmployeeShift
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<Shift> ShiftList { get; set; }
    }
}