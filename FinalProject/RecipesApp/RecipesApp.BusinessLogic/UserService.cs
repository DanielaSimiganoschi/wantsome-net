using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.DAL;
using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace RecipesApp.BusinessLogic
{
    public class UserService
    {
        private readonly GenericRepository<Users> usersRepositoryG;
        private readonly UsersRepository usersRepository;

        public UserService()
        {
            usersRepositoryG = new GenericRepository<Users>();
            usersRepository = new UsersRepository();
        }

        public bool CheckIfUserNameExists(string username)
        {
            var allUsers = usersRepositoryG.GetAll();

            var user = allUsers.Where(x => x.UserName == username).FirstOrDefault();

            if (user != null)
            {
                return true;
            }
            return false;
        }

        public int CheckLoginCredentials(UsersBL user)
        {
            var id = usersRepository.CheckIfUserExistsAndReturnID(user.UserName);
            if (id > 0)
            {
                var password = usersRepository.GetPasswordForUserID(id);
               
                var verify = Crypto.VerifyHashedPassword(password, user.Password);
                if (verify == true) { return 1; }
                else { return -1; }
            }
            else
            {
                return -2;
            }
        }

        public void Create(UsersBL user)
        {

            var hashedPass = Crypto.HashPassword(user.Password);
            var userDAL = new Users()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = hashedPass,
                Salt = "12",
                RoleID = 2
            };
            usersRepositoryG.Create(userDAL);
        }

        public string GetRoleForUserName(string username)
        {
           var role= usersRepository.GetRoleForUserName(username);
            return role;
        }
    }
}
