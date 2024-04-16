using Ogani.BusinessLogic.Core;
using Ogani.BusinessLogic.Interfaces;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic.MainBL
{
    public class SessionBL : UserAPI, ISession
    {
        public RequestResponseData UserLoginAction(ULoginData data)
        {
            return ULASessionCheck(data);
        }
    }
}
