using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic.Core
{
    public class UserAPI
    {
        internal RequestResponseData ULASessionCheck(ULoginData data)
        {
            //database connection
            return new RequestResponseData { Status = false };
        }
    }
}
