using RecipesApp.BusinessLogic;
using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RecipesApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService userService;

        public AccountController()
        {
            userService = new UserService();
        }
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.LoginIssue = TempData["message"];
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            UsersBL userBL = new UsersBL()
            {
                UserName = user.UserName,
                Password = user.Password
            };
           var i = userService.CheckLoginCredentials(userBL);
            if(i == 1)
            {
             FormsAuthentication.SetAuthCookie(user.UserName, false);
              return RedirectToAction("Index", "Recipe");

            } else if(i == -1)
            {
                TempData["message"] = "THe password is incorrect, please try again.";
                return RedirectToAction("Login", "Account");
            }
            else
            {
                TempData["message"] = "The provided username does not figure in our database";
                return RedirectToAction("Login", "Account");
            }
          
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Recipe");
        }
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = TempData["message"];
            return View();

        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult RegisterAccount(UserRegisterViewModel model)
        {
            UsersBL userBL = new UsersBL();

            if (userService.CheckIfUserNameExists(model.UserName))
            {
                string message = "The provided user name already exists.";
                TempData["message"] = message;
                return RedirectToAction("Register", "Account");
            }
            else
            {
                userBL = new UsersBL
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Password = model.Password
                };
                userService.Create(userBL);

                return RedirectToAction("Login", "Account");
            }

        }
    }
}