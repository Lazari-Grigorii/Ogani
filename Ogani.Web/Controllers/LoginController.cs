using System;
using System.Web;
using System.Web.Mvc;
using Ogani.BusinessLogic.Interfaces;
using Ogani.Domain.Entities.User;
using Ogani.Web.Models;

namespace Ogani.Web.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ISession _session;

        public LoginController()
        {
            var businessLogic = new BusinessLogic.BusinessLogic();
            _session = businessLogic.GetSessionBL();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        public ActionResult NewPassword()
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult ChangePasswordAction(LoginModel model)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            var loginData = new LoginData()
            {
                Password = model.Password,
            };

            var response = _session.PasswordVerification(loginData);
            if (response)
            {
                return RedirectToAction("NewPassword", "Login");
            }
            else
            {
                return RedirectToAction("ChangePassword", "Login");
            }
        }

        [HttpPost]
        public ActionResult NewPasswordAction(LoginModel model)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            var loginData = new LoginData()
            {
                Password = model.Password,
            };

            var response = _session.ChangePassword(loginData);
            if (response)
            {
                CloseSession();
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return RedirectToAction("ChangePassword", "Login");
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            CloseSession();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAction(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var loginData = new LoginData()
                {
                    Username = model.Username,
                    Password = model.Password,
                    Entry = DateTime.Now,
                    LoginIP = Request.UserHostAddress,
                };

                var authResponse = _session.CredentialsVerification(loginData);
                if (authResponse.Exist)
                {
                    HttpCookie cookie = _session.GenerateCookies(model.Username);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                    UpdateSessionStatus();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", authResponse.ErrorMsg);
                    return RedirectToAction("Login", "Login");
                }
            }
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public ActionResult RegistrationAction(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password1 != model.Password2)
                {
                    ModelState.AddModelError("", "Password was not typed correct the second time!");
                    return RedirectToAction("Registration", "Login");
                }

                var registrationData = new RegistrationData()
                {
                    Email = model.Email,
                    Password = model.Password1,
                    Username = model.Username,
                    LoginIP = Request.UserHostAddress,
                    LastEntry = DateTime.Now,
                };

                var response = _session.CreateUserAccount(registrationData);
                if (!response.Exist)
                {
                    ModelState.AddModelError("", response.ErrorMsg);
                    return RedirectToAction("Registration", "Login");
                }

                return RedirectToAction("Login", "Login");
            }
            return RedirectToAction("Registration", "Login");
        }

        private void UpdateSessionStatus()
        {
            // Implementation of UpdateSessionStatus
        }

        private void CloseSession()
        {
            // Implementation of CloseSession
        }
    }
}
