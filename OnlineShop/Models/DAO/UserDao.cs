using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Models.DAO
{
    public class UserDao
    {
        OnlineShopEntities db = null;

        public UserDao()
        {
            db = new OnlineShopEntities();
        }
        
        //Insert an user
        public long Insert(User entity)
        {
            db.User.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        //login method
        public bool Login(string userName, string passWord)
        {
            var result = db.User.Count(u => u.UserName == userName && u.PassWord == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUserByID(string userName)
        {
            return db.User.SingleOrDefault(u => u.UserName == userName);
        }

    }
}
