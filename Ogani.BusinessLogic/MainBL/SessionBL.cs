using Ogani.BusinessLogic.Interfaces;
using Ogani.BussinesLogic.Core;
using Ogani.Domain.Entities.User;
using Ogani.Domain.Entities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ogani.BussinesLogic
{
    public class SessionBL : UserAPI, ISession
    {
        public ResponseData UserLogin(LoginData data)
        {
            return UserValidateSession(data);
        }

        public ResponseRegisterData UserRegister(RegisterData userRegisterData)
        {
            return UserRegisterAction(userRegisterData);
        }

        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
        public ResponseData UserLogout()
        {
            return UserLogoutAction();
        }
    }
}