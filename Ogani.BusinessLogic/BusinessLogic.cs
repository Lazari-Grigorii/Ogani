using Ogani.BusinessLogic.Interfaces;
using Ogani.BusinessLogic.MainBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }

    public IProduct GetProduct() 
    {
        return new ProductBL();
    }
}
