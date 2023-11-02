using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FactoryProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployeeController : ApiController
    {
        EmployeeBL BL = new EmployeeBL();
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return BL.GetAll();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return BL.GetByID(id);
        }

        // POST: api/Employee
        public string Post(Employee emp)
        {
            return BL.Add(emp);
        }

        // PUT: api/Employee/5
        public string Put(int id, Employee emp)
        {
            return BL.Update(id, emp);
        }

        // DELETE: api/Employee/5
        public string Delete(int id)
        {
            return BL.Delete(id);

        }
    }
}
