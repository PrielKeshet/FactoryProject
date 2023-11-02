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
    public class EmployeeShiftController : ApiController
    {
        EmployeeShiftBL BL = new EmployeeShiftBL();
        // GET: api/EmployeeShift
        public IEnumerable<EmployeeShift> Get()
        {
            return BL.GetAll();
        }

        // GET: api/EmployeeShift/5
        public EmployeeShift Get(int id)
        {
            return BL.GetByID(id);
        }

        // POST: api/EmployeeShift
        public string Post(EmployeeShift x)
        {
            return BL.Add(x);
        }

        // PUT: api/EmployeeShift/5
        public string Put(int id, EmployeeShift x)
        {
            return BL.Update(id, x);
        }

        // DELETE: api/EmployeeShift/5
        public string Delete(int id)
        {
            return BL.Delete(id);
        }
    }
}
