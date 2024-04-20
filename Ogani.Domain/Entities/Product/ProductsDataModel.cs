using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.Domain.Entities.Product
{
    public class ProductsDataModel
    {
        public DBModel.Product SingleProduct { get; set; }
        public List<DBModel.Product> Products { get; set; }
    }
}
