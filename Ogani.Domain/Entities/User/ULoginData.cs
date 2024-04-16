﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.Domain.Entities.User
{
    public class ULoginData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string UserIp { get; set; }
        public DateTime FirstLoginTime { get; set; }
    }
}
