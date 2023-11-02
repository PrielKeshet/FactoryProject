using FactoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject
{
    public class UserBL
    {
        FactoryDBEntities DB = new FactoryDBEntities();

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            foreach(var user in DB.User)
            {
                users.Add(user);
            }
            return users;
        }
        public User GetByID(int id)
        {
            return DB.User.Where(x => x.ID == id).First();
        }
        public string Update(int id, User user1)
        {
            User user2 = DB.User.Where(x => x.ID ==id).First();
            user2.UserName = user1.UserName;
            user2.Password = user1.Password;
            user2.NumOfActions = user1.NumOfActions;
            user2.FullName = user1.FullName;
            DB.SaveChanges();
            return "updated";

        }
    }
}