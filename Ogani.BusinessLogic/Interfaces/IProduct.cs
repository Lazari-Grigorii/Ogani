using Ogani.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        ProductsDataModel GetProductsToList();
        ProductsDataModel GetSingleProduct(int id);
    }
}
