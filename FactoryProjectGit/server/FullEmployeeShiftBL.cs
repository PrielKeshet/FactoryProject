using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http.Cors;

namespace FactoryProject
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FullEmployeeShiftBL
    {
      
        FactoryDBEntities DB = new FactoryDBEntities();
        public List<FullEmployeeShift> GetAll()
        {
            List<FullEmployeeShift> MainList = new List<FullEmployeeShift>();
            foreach (var obj in DB.EmployeeShift)
            {
                //פתיחת אובייקט והכנסת המידע הפשוט
                FullEmployeeShift fullEmpShift= new FullEmployeeShift();
                fullEmpShift.ID = obj.ID;
                fullEmpShift.EmployeeID = obj.EmployeeID;
                fullEmpShift.ShiftID=obj.ShiftID;
            //פתיחת רשימה של עובדים לאובייקט
                 fullEmpShift.EmployeeList= new List<Employee>();
            //employeeShiftלרשימה של העובדים, נכניס רק את העובדים מהטבלה 
              //שיש להם את אותו מספר משמרת כמו למשמרת שאנחנו כרגע נמצאים עליה בפוראיצ הגדול  
            foreach(var x in DB.EmployeeShift)
                {
                if(x.ShiftID==obj.ShiftID)
                {
                    fullEmpShift.EmployeeList.Add(DB.Employee.Where(emp => emp.ID == x.EmployeeID).First());
                }
                }

                fullEmpShift.ShiftList = new List<Shift>();
                //נכניס לרשימת משמרות רק את המשמרות של העובד שהתז שלו נמצא באובייקט הראשי של הפוראיצ
                foreach(var x in DB.EmployeeShift)
                {
                    if(x.EmployeeID==obj.EmployeeID)
                    {
                        fullEmpShift.ShiftList.Add(DB.Shift.Where(s=> s.ID==x.ShiftID).First());
                    }
                }
                MainList.Add(fullEmpShift);
 
            }
            return MainList;
        }
    }
}