using Ogani.Domain.Entities.AuthorizationEntity;
using Ogani.Domain.Entities.GeneralResponse;
using Ogani.Domain.Entities.Product;
using Ogani.Domain.Entities.Product.DBModel;
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
        //---------------------Auth
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

        //--------------------Product
        internal ProductsDataModel ProductActionGetToList()
        {
            //SELECT FROM DATABASE db.Product -> Products

            var products = new List<Product>();

            return new ProductsDataModel { Products = products };
        }
        internal ProductsDataModel ProductGetSingleAction(int id)
        {
            //SELECT FROM db.Product WHERE ID = id

            var product = new Product();

            return new ProductsDataModel { SingleProduct = product };
        }
    }
}
