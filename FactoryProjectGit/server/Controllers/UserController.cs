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

    public class UserController : ApiController
    {
      UserBL BL= new UserBL();

        public IEnumerable<User> Get()
        {
            return BL.GetAll();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return BL.GetByID(id);
        }

        public string Put(int id, User user)
        {
            return BL.Update(id, user);
        }

      
    }
}
