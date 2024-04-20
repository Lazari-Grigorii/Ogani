using Ogani.BusinessLogic.Core;
using Ogani.BusinessLogic.Interfaces;
using Ogani.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic.MainBL
{
    public class ProductBL : UserAPI, IProduct
    {
        public ProductsDataModel GetProductsToList()
        {
            return ProductActionGetToList();
        }

        public ProductsDataModel GetSingleProduct(int id)
        {
            return ProductGetSingleAction(id);
        }
    }
}
