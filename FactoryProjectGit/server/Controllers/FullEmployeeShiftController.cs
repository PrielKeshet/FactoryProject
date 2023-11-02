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
    public class FullEmployeeShiftController : ApiController
    {
        FullEmployeeShiftBL BL = new FullEmployeeShiftBL();
        // GET: api/FullEmployeeShift
        public IEnumerable<FullEmployeeShift> Get()
        {
            return BL.GetAll();
        }

    }
}
