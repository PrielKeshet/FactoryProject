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

    public class ShiftController : ApiController
    {
        ShiftBL BL=new ShiftBL();
        // GET: api/Shift
        public IEnumerable<Shift> Get()
        {
            return BL.GetAll();
        }

        // GET: api/Shift/5
        public Shift Get(int id)
        {
            return BL.GetByID(id);
        }

        // POST: api/Shift
        public string Post(Shift shift1)
        {
            return BL.Add(shift1);
        }

        // PUT: api/Shift/5
        public string Put(int id, Shift shift1)
        {
            return BL.Update(id, shift1);
        }

        // DELETE: api/Shift/5
        public string Delete(int id)
        {
            return BL.Delete(id);
        }
    }
}
