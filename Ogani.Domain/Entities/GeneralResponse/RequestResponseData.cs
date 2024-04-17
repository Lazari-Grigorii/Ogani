using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.Domain.Entities.GeneralResponse
{
    public class RequestResponseData
    {
        public bool Status { get; set; }
        public string ResponseMessage {  get; set; } 
        public User.DbModel.User CurrentUser { get; set; }
    }
}
