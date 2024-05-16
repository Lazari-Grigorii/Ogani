using Ogani.BusinessLogic.Interfaces;
using Ogani.BusinessLogic.Services;
using Ogani.Domain.Enums;
using Ogani.Filters.AuthFilters;
using Ogani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ogani.Web.Controllers
{
    public class PrivateAccountController : BaseController
    {
        private readonly IUsersManagement _usersManagement;
        private readonly IMsgsManagement _msgsManagement;

        public PrivateAccountController()
        {
            var businessLogic = new BusinessLogic.BusinessLogic();
            _usersManagement = businessLogic.GetUsersManagementS();
            _msgsManagement = businessLogic.GetMsgsManagementS();
        }

        public ActionResult Profile()
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [AuthAdmin1]
        [HttpGet]
        public ActionResult AllUsers()
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            UsersInfo usersInfo = new UsersInfo();
            usersInfo.userInfos = _usersManagement.getAllUsers();

            return View(usersInfo);
        }

        [AuthModerator]
        [HttpGet]
        public ActionResult AllMessages()
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            BlogComments blogComments = new BlogComments()
            {
                Comments = new List<BlogComment>(),
            };
            var commentsD = _usersManagement.GetAllMessages();
            for (var i = 0; i < commentsD.Count; i++)
            {
                var tmp = new BlogComment()
                {
                    Id = commentsD[i].Id,
                    UserId = commentsD[i].UserId,
                    Created = commentsD[i].Created,
                    AnnouncementId = commentsD[i].AnnouncementId,
                    MessageType = commentsD[i].MessageType,
                    Comment = commentsD[i].Comment,
                    UserName = commentsD[i].UserName,
                };
                blogComments.Comments.Add(tmp);
            }
            return View(blogComments);
        }

        [AuthModerator]
        [HttpGet]
        public ActionResult DeleteMessage(int Id)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            var response = _msgsManagement.DeleteMessageById(Id);

            return RedirectToAction("AllMessages", "PrivateAccount");
        }

        [AuthAdmin1]
        [HttpGet]
        public ActionResult DeleteUser(int Id)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            var response = _usersManagement.DeleteUserById(Id);

            return RedirectToAction("AllUsers", "PrivateAccount");
        }

        [AuthAdmin1]
        [HttpGet]
        public ActionResult ChangeUsersAccountStatus(int Id)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            var response = _usersManagement.ChangeUsersAccountStatusById(Id);

            return RedirectToAction("AllUsers", "PrivateAccount");
        }

        [AuthAdmin1]
        [HttpPost]
        public ActionResult ChangeUserRole(UserInfoM userInfoM)
        {
            UpdateSessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["SessionStatus"] != "valid")
            {
                return RedirectToAction("Index", "Home");
            }

            UserInfo userInfoD = new UserInfo()
            {
                Id = userInfoM.Id,
                UserRole = userInfoM.UserRole,
            };

            var response = _usersManagement.ChangeUserRole(userInfoD);

            return RedirectToAction("AllUsers", "PrivateAccount");
        }
    }
}
