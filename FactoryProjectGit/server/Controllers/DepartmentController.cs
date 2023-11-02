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
    [EnableCors(origins: "*", headers: "*", methods:"*")]
    public class DepartmentController : ApiController
    {
        DepartmentBL BL=new DepartmentBL();
        // GET: api/Department
        public IEnumerable<Department> Get()
        {
            return BL.GetAll();
        }

        // GET: api/Department/5
        public Department Get(int id)
        {
            return BL.GetByID(id);
        }

        // POST: api/Department
        public string Post(Department dep)
        {
           return BL.Add(dep);
        }

        // PUT: api/Department/5
        public string Put(int id, Department dep)
        {
            return BL.Update(id, dep);
        }

        // DELETE: api/Department/5
        public string Delete(int id)
        {
            return BL.Delete(id);
        }
    }
}
