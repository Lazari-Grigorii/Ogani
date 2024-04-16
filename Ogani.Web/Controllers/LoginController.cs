using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Ogani.BusinessLogic.Interfaces;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using Ogani.Web.Models;  // Добавил, но не уверен

namespace Ogani.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var logicBL = new BusinessLogic.BusinessLogic();
            _session = logicBL.GetSessionBL();  
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginData data) 
        {
            var ULData = new ULoginData
            {
                Credential = data.Username,
                Password = data.Password,
                UserIp = "",
                FirstLoginTime = DateTime.Now
            };

            RequestResponseData response = _session.UserLoginAction(ULData);
            if (response != null && response.Status) 
            {
                //тут будет логика Cookie Generation
            }

            return View();
        }
    }
}