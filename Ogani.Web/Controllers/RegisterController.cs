using Ogani.BusinessLogic.Interfaces;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using Ogani.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ogani.Web.Controllers
{
    public class RegisterController : Controller
    {
        internal ISession _session;
        public RegisterController()
        {
            var logicBL = new BusinessLogic.BusinessLogic();
            _session = logicBL.GetSessionBL();
        }

        // GET: Register
        public ActionResult Index()
        {
            var uiModel = new RegisterData{
                Username = "Egor",
                Password = "123456789abc",
                Email = "egor123@gmail.com"
            };


            var URdata = new URegisterData{
                Username = uiModel.Username,
                Password = uiModel.Password,
                Email = uiModel.Email,
                Ip = "11.22.33.44",
                RegisterDate = DateTime.Now
            };

            RequestResponseData response = _session.UserRegisterAction(URdata);

            return View();
        }

    }
}