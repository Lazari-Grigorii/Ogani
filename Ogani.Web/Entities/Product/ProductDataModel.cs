using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ogani.Web.Entities.Product
{
    public class ProductDataModel
    {
     
            public DBModel.Product SingleProduct { get; set; }
            public List<DBModel.Product> Products { get; set; }
        
    }
}