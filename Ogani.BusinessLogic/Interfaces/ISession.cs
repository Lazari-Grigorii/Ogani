using Ogani.Domain.Entities.AuthorizationEntity;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using Ogani.Domain.Entities.User.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic.Interfaces
{
    public interface ISession
    {
        RequestResponseData UserLoginAction(ULoginData data);
        UCookieData GenGookieAlgorithm(User dataUser);
    }
}
