using Ogani.Domain.Entities.AuthorizationEntity;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.User;
using Ogani.Domain.Entities.User.DbModel;
using System;
using System.Collections.Generic;
using System.Data;
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
            //
            //
            //

            return new RequestResponseData 
            { 
                Status = false, 
                CurrentUser = new User
                {
                    UserName = "Egor"
                } 
            };
        }
        internal UCookieData UCGenerationAlg(User dataUser)
        {

            //Логика процесса генерации Cookie будкт описана здесь
            //
            //

            return new UCookieData 
            {
                MaxAge = 1710055385, 
                Cookie = "MY Unique ID for this session" 
            };
        }
    }
}
