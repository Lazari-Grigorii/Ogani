using Ogani.Domain.Entities.User;
using Ogani.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ogani.Models
{
    public class UserInfoM
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public List<LoginHistoryD> LoginHistories { get; set; }

        public Role UserRole { get; set; }

    }
}