using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
    public class UsersRepository
    {
        private readonly RecipesDBEntities db;


        public UsersRepository()
        {
            db = new RecipesDBEntities();

        }

        public int CheckIfUserExistsAndReturnID(string userName)
        {

            var ok = db.Users.Where(i => i.UserName == userName).Select(i=> i.UserID).FirstOrDefault();
            return ok;
        }

        public string GetPasswordForUserID(int id)
        {
            var pass = db.Users.Where(i => i.UserID == id).FirstOrDefault().Password;
            return pass;
        }

        public string GetRoleForUserName(string userName)
        {
            var roleID = db.Users.Where(i => i.UserName == userName).FirstOrDefault().RoleID;
            var role = db.Roles.Where(i => i.RoleID == roleID).FirstOrDefault().Name;

            return role;
        }
    }
}
